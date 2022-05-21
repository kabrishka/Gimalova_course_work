namespace KC_20_Gimalova_course_work
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(173)))), ((int)(((byte)(234)))));
            this.panelMenu.Controls.Add(this.btnResult);
            this.panelMenu.Controls.Add(this.btnTest);
            this.panelMenu.Controls.Add(this.btnCourses);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 572);
            this.panelMenu.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
            this.btnResult.Location = new System.Drawing.Point(0, 198);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(200, 61);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Результаты";
            this.btnResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(0, 137);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(200, 61);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Тесты";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnCourses.Image")));
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(0, 76);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(200, 61);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Курсы";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(132)))), ((int)(((byte)(225)))));
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 76);
            this.panelLogo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(60, 58);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogo.Location = new System.Drawing.Point(78, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(76, 58);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Easy\r\nChem";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(204)))), ((int)(((byte)(251)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.btnCollapse);
            this.panelTitleBar.Controls.Add(this.btnIncrease);
            this.panelTitleBar.Controls.Add(this.btnCloseAll);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(863, 76);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChildForm.Location = new System.Drawing.Point(6, 9);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(62, 61);
            this.btnCloseChildForm.TabIndex = 6;
            this.btnCloseChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChildForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCollapse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnCollapse.Location = new System.Drawing.Point(734, 3);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(24, 29);
            this.btnCollapse.TabIndex = 5;
            this.btnCollapse.Text = "O";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnIncrease.Location = new System.Drawing.Point(785, 3);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(24, 29);
            this.btnIncrease.TabIndex = 4;
            this.btnIncrease.Text = "O";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseAll.FlatAppearance.BorderSize = 0;
            this.btnCloseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAll.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.btnCloseAll.Location = new System.Drawing.Point(836, 3);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(24, 29);
            this.btnCloseAll.TabIndex = 3;
            this.btnCloseAll.Text = "O";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(52)))));
            this.lblTitle.Location = new System.Drawing.Point(234, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 29);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Домашняя страница";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(200, 76);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(863, 496);
            this.desktopPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1063, 572);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}

