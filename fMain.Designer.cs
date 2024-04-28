namespace lap14_oop
{
    partial class fMain
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
            System.Windows.Forms.Button btnExpand;
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCircles = new System.Windows.Forms.ComboBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCreateNewSquare = new System.Windows.Forms.Button();
            this.btnCreateNewTriangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSquares = new System.Windows.Forms.ComboBox();
            this.cbTriangles = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            btnExpand = new System.Windows.Forms.Button();
            this.pnMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExpand
            // 
            btnExpand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnExpand.Location = new System.Drawing.Point(1018, 319);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new System.Drawing.Size(75, 40);
            btnExpand.TabIndex = 8;
            btnExpand.Text = "Expand";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Controls.Add(this.tabControl1);
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(879, 514);
            this.pnMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Круги";
            // 
            // cbCircles
            // 
            this.cbCircles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCircles.FormattingEnabled = true;
            this.cbCircles.Location = new System.Drawing.Point(885, 28);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(101, 24);
            this.cbCircles.TabIndex = 2;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(885, 58);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(100, 24);
            this.btnCreateNew.TabIndex = 3;
            this.btnCreateNew.Text = "Створити круг";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(900, 252);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(97, 29);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(900, 217);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(97, 29);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.Location = new System.Drawing.Point(1018, 234);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(75, 33);
            this.btnUpFar.TabIndex = 6;
            this.btnUpFar.Text = "UpFar";
            this.btnUpFar.UseVisualStyleBackColor = true;
            this.btnUpFar.Click += new System.EventHandler(this.btnUpFar_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1018, 273);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 40);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(1018, 365);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(75, 40);
            this.btnCollapse.TabIndex = 9;
            this.btnCollapse.Text = "Collapse";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1018, 411);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 40);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.Location = new System.Drawing.Point(1018, 457);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(75, 33);
            this.btnDownFar.TabIndex = 11;
            this.btnDownFar.Text = "DownFar";
            this.btnDownFar.UseVisualStyleBackColor = true;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(967, 319);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(45, 86);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.Location = new System.Drawing.Point(919, 319);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(42, 86);
            this.btnLeftFar.TabIndex = 13;
            this.btnLeftFar.Text = "L Far";
            this.btnLeftFar.UseVisualStyleBackColor = true;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnRightFar
            // 
            this.btnRightFar.Location = new System.Drawing.Point(1150, 319);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(42, 86);
            this.btnRightFar.TabIndex = 14;
            this.btnRightFar.Text = "R Far";
            this.btnRightFar.UseVisualStyleBackColor = true;
            this.btnRightFar.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1099, 319);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(45, 86);
            this.btnRight.TabIndex = 15;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.brnRight_Click);
            // 
            // btnCreateNewSquare
            // 
            this.btnCreateNewSquare.Location = new System.Drawing.Point(992, 58);
            this.btnCreateNewSquare.Name = "btnCreateNewSquare";
            this.btnCreateNewSquare.Size = new System.Drawing.Size(101, 24);
            this.btnCreateNewSquare.TabIndex = 16;
            this.btnCreateNewSquare.Text = "Створити квадрат";
            this.btnCreateNewSquare.UseVisualStyleBackColor = true;
            this.btnCreateNewSquare.Click += new System.EventHandler(this.btnCreateNewSquare_Click_1);
            // 
            // btnCreateNewTriangle
            // 
            this.btnCreateNewTriangle.Location = new System.Drawing.Point(1102, 58);
            this.btnCreateNewTriangle.Name = "btnCreateNewTriangle";
            this.btnCreateNewTriangle.Size = new System.Drawing.Size(102, 24);
            this.btnCreateNewTriangle.TabIndex = 17;
            this.btnCreateNewTriangle.Text = "Створити трикутник";
            this.btnCreateNewTriangle.UseVisualStyleBackColor = true;
            this.btnCreateNewTriangle.Click += new System.EventHandler(this.btnCreateNewTriangle_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(989, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Квадрати";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1099, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Трикутники";
            // 
            // cbSquares
            // 
            this.cbSquares.FormattingEnabled = true;
            this.cbSquares.Location = new System.Drawing.Point(992, 28);
            this.cbSquares.Name = "cbSquares";
            this.cbSquares.Size = new System.Drawing.Size(101, 24);
            this.cbSquares.TabIndex = 20;
            // 
            // cbTriangles
            // 
            this.cbTriangles.FormattingEnabled = true;
            this.cbTriangles.Location = new System.Drawing.Point(1102, 28);
            this.cbTriangles.Name = "cbTriangles";
            this.cbTriangles.Size = new System.Drawing.Size(102, 24);
            this.cbTriangles.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 24);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(350, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Круги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(350, 115);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Квадрати";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(273, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Трикутники";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 516);
            this.Controls.Add(this.cbTriangles);
            this.Controls.Add(this.cbSquares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateNewTriangle);
            this.Controls.Add(this.btnCreateNewSquare);
            this.Controls.Add(this.btnRightFar);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeftFar);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDownFar);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(btnExpand);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnUpFar);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.cbCircles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnMain);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаб14";
            this.pnMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCircles;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCreateNewSquare;
        private System.Windows.Forms.Button btnCreateNewTriangle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSquares;
        private System.Windows.Forms.ComboBox cbTriangles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

