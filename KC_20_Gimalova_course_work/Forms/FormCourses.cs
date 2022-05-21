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
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace KC_20_Gimalova_course_work.Forms
{
    public partial class FormCourses : Form
    {
        public FormCourses()
        {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in boxSub.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.FromArgb(0, 0, 0);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            foreach (Control btns in boxChemBond.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.FromArgb(0, 0, 0);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            boxSub.ForeColor = ThemeColor.SecondaryColor;
            boxChemBond.ForeColor = ThemeColor.SecondaryColor;
        }

        private void btnTheme1_Click(object sender, EventArgs e)
        {
            DataBank.filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tasks\task1.pptx");
            openPowerPoint(DataBank.filePath);
        }

        private void btnTheme3_Click(object sender, EventArgs e)
        {
            DataBank.filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tasks\task3.pptx");
            openPowerPoint(DataBank.filePath);
        }

        private void btnTheme2_Click(object sender, EventArgs e)
        {
            DataBank.filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tasks\task2.pptx");
            openPowerPoint(DataBank.filePath);
        }

        private void btnTheme4_Click(object sender, EventArgs e)
        {
            DataBank.filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tasks\task4.pptx");
            openPowerPoint(DataBank.filePath);
        }

        void openPowerPoint(string path)
        {
            PowerPoint.Application app = new PowerPoint.Application();
            app.Visible = Microsoft.Office.Core.MsoTriState.msoCTrue;
            app.Presentations.Open2007($"{path}");

        }


    }
}
