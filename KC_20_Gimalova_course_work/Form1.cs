using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace KC_20_Gimalova_course_work
{
    public partial class Form1 : Form
    {
        //поля
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        DataBase dataBase = new DataBase();

        Forms.FormResult formResult = new Forms.FormResult();

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            //удаляю ControlBox
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //методы

        //Выбираем рандомный цвет из списка цветов для темы
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            //Если цвет уже был использован, мы выбираем другой
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        //Выделяем активную кнопку
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    //увеличительный эффект
                    currentButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    //изменение цвета фона логотима и TitleBar
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //работа с кнопкой закрытия вложенной формы
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        //Деактивация кнопки (дефолтное значение)
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(193, 173, 234);
                    previousBtn.ForeColor = Color.FromArgb(230, 230, 230);
                    previousBtn.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        //Создаем метод, открывающий форму в container panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Курсы";
            OpenChildForm(new Forms.FormCourses(), sender);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Тесты";
            OpenChildForm(new Forms.FormTests(), sender);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Результаты";
            OpenChildForm(new Forms.FormResult(), sender);
         
        }



        private void Reset()
        {
            //работа с кнопкой закрытия вложенной формы
            DisableButton();
            lblTitle.Text = "Домашняя страница";
            panelTitleBar.BackColor = Color.FromArgb(199, 204, 251);
            panelLogo.BackColor = Color.FromArgb(163, 132, 225);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }       
        
    }
}
