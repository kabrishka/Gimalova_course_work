namespace KC_20_Gimalova_course_work.Forms
{
    partial class FormCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxSub = new System.Windows.Forms.GroupBox();
            this.btnTheme3 = new System.Windows.Forms.Button();
            this.btnTheme1 = new System.Windows.Forms.Button();
            this.boxChemBond = new System.Windows.Forms.GroupBox();
            this.btnTheme4 = new System.Windows.Forms.Button();
            this.btnTheme2 = new System.Windows.Forms.Button();
            this.boxSub.SuspendLayout();
            this.boxChemBond.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxSub
            // 
            this.boxSub.Controls.Add(this.btnTheme3);
            this.boxSub.Controls.Add(this.btnTheme1);
            this.boxSub.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 16.2F);
            this.boxSub.ForeColor = System.Drawing.Color.Black;
            this.boxSub.Location = new System.Drawing.Point(106, 24);
            this.boxSub.Name = "boxSub";
            this.boxSub.Size = new System.Drawing.Size(702, 223);
            this.boxSub.TabIndex = 0;
            this.boxSub.TabStop = false;
            this.boxSub.Text = "Вещество";
            // 
            // btnTheme3
            // 
            this.btnTheme3.FlatAppearance.BorderSize = 0;
            this.btnTheme3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.btnTheme3.Location = new System.Drawing.Point(21, 124);
            this.btnTheme3.Name = "btnTheme3";
            this.btnTheme3.Size = new System.Drawing.Size(666, 76);
            this.btnTheme3.TabIndex = 1;
            this.btnTheme3.Text = "Периодический закон и Периодическая система элементов";
            this.btnTheme3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme3.UseVisualStyleBackColor = true;
            this.btnTheme3.Click += new System.EventHandler(this.btnTheme3_Click);
            // 
            // btnTheme1
            // 
            this.btnTheme1.FlatAppearance.BorderSize = 0;
            this.btnTheme1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.btnTheme1.Location = new System.Drawing.Point(21, 42);
            this.btnTheme1.Name = "btnTheme1";
            this.btnTheme1.Size = new System.Drawing.Size(666, 76);
            this.btnTheme1.TabIndex = 0;
            this.btnTheme1.Text = "Атомы и молекулы. Химический элемент. Простые и сложные вещества";
            this.btnTheme1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme1.UseVisualStyleBackColor = true;
            this.btnTheme1.Click += new System.EventHandler(this.btnTheme1_Click);
            // 
            // boxChemBond
            // 
            this.boxChemBond.Controls.Add(this.btnTheme4);
            this.boxChemBond.Controls.Add(this.btnTheme2);
            this.boxChemBond.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 16.2F);
            this.boxChemBond.ForeColor = System.Drawing.Color.Black;
            this.boxChemBond.Location = new System.Drawing.Point(106, 253);
            this.boxChemBond.Name = "boxChemBond";
            this.boxChemBond.Size = new System.Drawing.Size(702, 223);
            this.boxChemBond.TabIndex = 2;
            this.boxChemBond.TabStop = false;
            this.boxChemBond.Text = "Химические связи";
            // 
            // btnTheme4
            // 
            this.btnTheme4.FlatAppearance.BorderSize = 0;
            this.btnTheme4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.btnTheme4.Location = new System.Drawing.Point(21, 124);
            this.btnTheme4.Name = "btnTheme4";
            this.btnTheme4.Size = new System.Drawing.Size(666, 76);
            this.btnTheme4.TabIndex = 1;
            this.btnTheme4.Text = "Валентность и степень окисления химических элементов";
            this.btnTheme4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme4.UseVisualStyleBackColor = true;
            this.btnTheme4.Click += new System.EventHandler(this.btnTheme4_Click);
            // 
            // btnTheme2
            // 
            this.btnTheme2.FlatAppearance.BorderSize = 0;
            this.btnTheme2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F);
            this.btnTheme2.Location = new System.Drawing.Point(21, 42);
            this.btnTheme2.Name = "btnTheme2";
            this.btnTheme2.Size = new System.Drawing.Size(666, 76);
            this.btnTheme2.TabIndex = 0;
            this.btnTheme2.Text = "Строение атома. Строение электронных оболочек атомов";
            this.btnTheme2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheme2.UseVisualStyleBackColor = true;
            this.btnTheme2.Click += new System.EventHandler(this.btnTheme2_Click);
            // 
            // FormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 563);
            this.Controls.Add(this.boxChemBond);
            this.Controls.Add(this.boxSub);
            this.Name = "FormCourses";
            this.Text = "FormCourses";
            this.boxSub.ResumeLayout(false);
            this.boxChemBond.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxSub;
        private System.Windows.Forms.Button btnTheme3;
        private System.Windows.Forms.Button btnTheme1;
        private System.Windows.Forms.GroupBox boxChemBond;
        private System.Windows.Forms.Button btnTheme4;
        private System.Windows.Forms.Button btnTheme2;
    }
}