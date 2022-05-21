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

namespace KC_20_Gimalova_course_work.Forms
{
    public partial class FormTests : Form
    {
        public FormTests()
        {
            InitializeComponent();
            
        }


        private void LoadTheme()
        {
            foreach (Control btns in boxSubForTest.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.FromArgb(0, 0, 0);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            foreach (Control btns in boxChemBondForTest.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.FromArgb(0, 0, 0);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            boxSubForTest.ForeColor = ThemeColor.SecondaryColor;
            boxChemBondForTest.ForeColor = ThemeColor.SecondaryColor;
        }

        private void callShowFunct(string filePath)
        {
            Tests.Test1 test1 = new Tests.Test1();
            test1.Show();
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            DataBank.testFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tests\testsTxt\test1.txt");
            callShowFunct(DataBank.testFilePath);
        }

        private void btnTest3_Click(object sender, EventArgs e)
        {
            DataBank.testFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tests\testsTxt\test3.txt");
            callShowFunct(DataBank.testFilePath);
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            DataBank.testFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tests\testsTxt\test2.txt");
            callShowFunct(DataBank.testFilePath);
        }

        private void btnTest4_Click(object sender, EventArgs e)
        {
            DataBank.testFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"Tests\testsTxt\test4.txt");
            callShowFunct(DataBank.testFilePath);
        }

        private void FormTests_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
