using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KC_20_Gimalova_course_work.Tests
{
    public partial class Test1 : Form
    {
        DataBase dataBase = new DataBase();

        //счётчик вопросов
        int questionCount;
        //кол-во неправильных ответов
        int wrongAnswer;
        //массив для хранения информации
        string[] array;
        //номер правильного ответа
        int correctAnswerNumber;
        //номер выбранного ответа
        int selectedResponse;

        

        //для считывания инфы с файла
        System.IO.StreamReader reader;
        public Test1()
        {
            InitializeComponent();
        }

        void Start(string filePath)
        {
            var encoding = Encoding.GetEncoding(65001);
            //чтение вопроса
            try
            {
                reader = new StreamReader(filePath, encoding);
                this.Text = reader.ReadLine();

                questionCount = 0;
                DataBank.correctAnswer = 0;
                wrongAnswer = 0;

                array = new string[10];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            readQuestion();
        }

        void readQuestion()
        {
            labelQuestion.Text = reader.ReadLine();

            radioButton1.Text = reader.ReadLine();
            radioButton2.Text = reader.ReadLine();
            radioButton3.Text = reader.ReadLine();

            correctAnswerNumber = int.Parse(reader.ReadLine());

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            btnNext.Enabled = false;
            questionCount = questionCount + 1;

            if (reader.EndOfStream == true)
            {
                btnNext.Text = "Закончить";
            }
        }

        void switchState(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnNext.Focus();
            RadioButton switchBtn = (RadioButton)sender;
            var tmp = switchBtn.Name;

            selectedResponse = int.Parse(tmp.Substring(11));

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //подсчет баллов
            if (selectedResponse == correctAnswerNumber)
            {
                DataBank.correctAnswer = DataBank.correctAnswer + 1;
            }
            if (selectedResponse != correctAnswerNumber)
            {
                wrongAnswer = wrongAnswer + 1;

                array[wrongAnswer] = labelQuestion.Text;
            }

            //повторный запуск
            if (btnNext.Text == "Заново")
            {
                btnNext.Text = "Следующий вопрос";

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                    
                Start(DataBank.testFilePath);
                return;
            }

            if (btnNext.Text == "Закончить")
            {
                reader.Close();

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;

                labelQuestion.Text = String.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Набранные баллы: {2:F2}.", DataBank.correctAnswer, questionCount, (DataBank.correctAnswer * 5.0F / questionCount));

                //добавление результатов в БД
                dataBase.openConnection();
               
                var command = new SqlCommand($"INSERT INTO [Rezults] (Date,Rezult) VALUES (@Date,@Rezult)", dataBase.getConnection());
                command.Parameters.Add("Date", DataBank.date.ToString("yyyy/MM/dd"));
                command.Parameters.Add("Rezult", DataBank.correctAnswer);
                command.ExecuteNonQuery();


                btnNext.Text = "Заново";

                var str = "Список ошибок " + ":\n\n";
                for (int i = 1; i <= wrongAnswer; i++)
                {
                    str = str + array[i] + "\n";
                }

                if (wrongAnswer != 0)
                {
                    MessageBox.Show(str, "Тест завершен");
                }
            }
            if (btnNext.Text == "Следующий вопрос")
            {
                readQuestion();
            }
        }

        private void Test1_Load(object sender, EventArgs e)
        {
            btnNext.Text = "Следующий вопрос";
            btnClose.Text = "Закрыть";

            radioButton1.CheckedChanged += new EventHandler(switchState);
            radioButton2.CheckedChanged += new EventHandler(switchState);
            radioButton3.CheckedChanged += new EventHandler(switchState);

            Start(DataBank.testFilePath);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
