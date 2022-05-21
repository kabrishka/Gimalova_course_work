using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace KC_20_Gimalova_course_work.Forms
{
    //состояние данных в таблице
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class FormResult : Form
    {
        DataBase dataBase = new DataBase();
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter = null;
        DataSet dataSet = null;
        DataTable dataTable = null;
        public FormResult()
        {
            InitializeComponent();
        }



        //название стобцов в DataGridView
        private void createColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Date", "Дата");
            dataGridView1.Columns.Add("Rezult", "Результат");
        }
        //IDataRecord - предоставляет доступ к значениям столбцов для каждой строки
        private void readSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetDateTime(1).ToShortDateString(), record.GetInt32(2));
        }

        //вывод данных в таблицу
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT id,Date,Rezult FROM Rezults";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readSingleRow(dgw, sqlDataReader);
            }

            sqlDataReader.Close();
        }


        private void FormResult_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            createColumns();
            refreshDataGrid(dataGridView1);
            dataGridView1.BackgroundColor = ThemeColor.PrimaryColor;



            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Rezults",dataBase.getConnection());

            dataSet = new DataSet();
            //получение к таблице в бд
            sqlDataAdapter.Fill(dataSet, "Rezults");

            dataTable = dataSet.Tables["Rezults"];

            //отображение визуальных элементов
            SeriesCollection series = new SeriesCollection();

            //засечки, данные на линии
            ChartValues<int> rezValues = new ChartValues<int>();

            //даты на оси X

            List<string> dates = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                rezValues.Add(Convert.ToInt32(row["Rezult"]));

                dates.Add(Convert.ToDateTime(row["Date"]).ToShortDateString());
            }

            //установление оси X
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis()
            {
                Title = "Даты",
                Labels = dates
            });

            //линия
            LineSeries rezLine = new LineSeries();

            rezLine.Title = "Пользователь";
            rezLine.Values = rezValues;

            series.Add(rezLine);

            cartesianChart1.Series = series;

            cartesianChart1.LegendLocation = LegendLocation.Bottom;

        }
           
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
