namespace TaskForYourType
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Vect1X = new TextBox();
            Vect1Y = new TextBox();
            Vect1Z = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Vect2X = new TextBox();
            Vect2Y = new TextBox();
            Vect2Z = new TextBox();
            Sum = new Button();
            Sub = new Button();
            Dot = new Button();
            Cross = new Button();
            LenVect1 = new Button();
            LenVect2 = new Button();
            SumRes = new Label();
            SubRes = new Label();
            DotRes = new Label();
            CrossRes = new Label();
            LenVect1Res = new Label();
            LenVect2Res = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(214, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите координаты первого вектора";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 54);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 87);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 120);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 3;
            label4.Text = "Z";
            // 
            // Vect1X
            // 
            Vect1X.Location = new Point(47, 51);
            Vect1X.Name = "Vect1X";
            Vect1X.Size = new Size(100, 23);
            Vect1X.TabIndex = 4;
            Vect1X.Text = "0";
            // 
            // Vect1Y
            // 
            Vect1Y.Location = new Point(47, 87);
            Vect1Y.Name = "Vect1Y";
            Vect1Y.Size = new Size(100, 23);
            Vect1Y.TabIndex = 5;
            Vect1Y.Text = "0";
            // 
            // Vect1Z
            // 
            Vect1Z.Location = new Point(47, 117);
            Vect1Z.Name = "Vect1Z";
            Vect1Z.Size = new Size(100, 23);
            Vect1Z.TabIndex = 6;
            Vect1Z.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 23);
            label5.Name = "label5";
            label5.Size = new Size(213, 15);
            label5.TabIndex = 7;
            label5.Text = "Введите координаты второго вектора";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 120);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 10;
            label6.Text = "Z";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(301, 87);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 9;
            label7.Text = "Y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 54);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 8;
            label8.Text = "X";
            // 
            // Vect2X
            // 
            Vect2X.Location = new Point(321, 51);
            Vect2X.Name = "Vect2X";
            Vect2X.Size = new Size(100, 23);
            Vect2X.TabIndex = 11;
            Vect2X.Text = "0";
            // 
            // Vect2Y
            // 
            Vect2Y.Location = new Point(321, 87);
            Vect2Y.Name = "Vect2Y";
            Vect2Y.Size = new Size(100, 23);
            Vect2Y.TabIndex = 12;
            Vect2Y.Text = "0";
            // 
            // Vect2Z
            // 
            Vect2Z.Location = new Point(321, 120);
            Vect2Z.Name = "Vect2Z";
            Vect2Z.Size = new Size(100, 23);
            Vect2Z.TabIndex = 13;
            Vect2Z.Text = "0";
            // 
            // Sum
            // 
            Sum.Location = new Point(27, 168);
            Sum.Name = "Sum";
            Sum.Size = new Size(120, 23);
            Sum.TabIndex = 14;
            Sum.Text = "Сумма векторов";
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Sum_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(27, 211);
            Sub.Name = "Sub";
            Sub.Size = new Size(129, 21);
            Sub.TabIndex = 15;
            Sub.Text = "Вычитание векторов";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Dot
            // 
            Dot.Location = new Point(27, 253);
            Dot.Name = "Dot";
            Dot.Size = new Size(162, 23);
            Dot.TabIndex = 16;
            Dot.Text = "Скалярное произведение";
            Dot.UseVisualStyleBackColor = true;
            Dot.Click += Dot_Click;
            // 
            // Cross
            // 
            Cross.Location = new Point(27, 296);
            Cross.Name = "Cross";
            Cross.Size = new Size(162, 23);
            Cross.TabIndex = 17;
            Cross.Text = "Векторное произведение";
            Cross.UseVisualStyleBackColor = true;
            Cross.Click += Cross_Click;
            // 
            // LenVect1
            // 
            LenVect1.Location = new Point(27, 335);
            LenVect1.Name = "LenVect1";
            LenVect1.Size = new Size(162, 23);
            LenVect1.TabIndex = 18;
            LenVect1.Text = "Длина первого вектора";
            LenVect1.UseVisualStyleBackColor = true;
            LenVect1.Click += LenVect1_Click;
            // 
            // LenVect2
            // 
            LenVect2.Location = new Point(27, 380);
            LenVect2.Name = "LenVect2";
            LenVect2.Size = new Size(162, 23);
            LenVect2.TabIndex = 19;
            LenVect2.Text = "Длина второго вектора";
            LenVect2.UseVisualStyleBackColor = true;
            LenVect2.Click += LenVect2_Click;
            // 
            // SumRes
            // 
            SumRes.AutoSize = true;
            SumRes.Location = new Point(301, 168);
            SumRes.Name = "SumRes";
            SumRes.Size = new Size(45, 15);
            SumRes.TabIndex = 20;
            SumRes.Text = "Сумма";
            // 
            // SubRes
            // 
            SubRes.AutoSize = true;
            SubRes.Location = new Point(301, 211);
            SubRes.Name = "SubRes";
            SubRes.Size = new Size(68, 15);
            SubRes.TabIndex = 21;
            SubRes.Text = "Вычитание";
            // 
            // DotRes
            // 
            DotRes.AutoSize = true;
            DotRes.Location = new Point(301, 253);
            DotRes.Name = "DotRes";
            DotRes.Size = new Size(147, 15);
            DotRes.TabIndex = 22;
            DotRes.Text = "Скалярное произведение";
            // 
            // CrossRes
            // 
            CrossRes.AutoSize = true;
            CrossRes.Location = new Point(301, 296);
            CrossRes.Name = "CrossRes";
            CrossRes.Size = new Size(145, 15);
            CrossRes.TabIndex = 23;
            CrossRes.Text = "Векторное произведение";
            // 
            // LenVect1Res
            // 
            LenVect1Res.AutoSize = true;
            LenVect1Res.Location = new Point(301, 335);
            LenVect1Res.Name = "LenVect1Res";
            LenVect1Res.Size = new Size(136, 15);
            LenVect1Res.TabIndex = 24;
            LenVect1Res.Text = "Длина первого вектора";
            // 
            // LenVect2Res
            // 
            LenVect2Res.AutoSize = true;
            LenVect2Res.Location = new Point(301, 380);
            LenVect2Res.Name = "LenVect2Res";
            LenVect2Res.Size = new Size(135, 15);
            LenVect2Res.TabIndex = 25;
            LenVect2Res.Text = "Длина второго вектора";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 692);
            Controls.Add(LenVect2Res);
            Controls.Add(LenVect1Res);
            Controls.Add(CrossRes);
            Controls.Add(DotRes);
            Controls.Add(SubRes);
            Controls.Add(SumRes);
            Controls.Add(LenVect2);
            Controls.Add(LenVect1);
            Controls.Add(Cross);
            Controls.Add(Dot);
            Controls.Add(Sub);
            Controls.Add(Sum);
            Controls.Add(Vect2Z);
            Controls.Add(Vect2Y);
            Controls.Add(Vect2X);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(Vect1Z);
            Controls.Add(Vect1Y);
            Controls.Add(Vect1X);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Vect1X;
        private TextBox Vect1Y;
        private TextBox Vect1Z;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Vect2X;
        private TextBox Vect2Y;
        private TextBox Vect2Z;
        private Button Sum;
        private Button Sub;
        private Button Dot;
        private Button Cross;
        private Button LenVect1;
        private Button LenVect2;
        private Label SumRes;
        private Label SubRes;
        private Label DotRes;
        private Label CrossRes;
        private Label LenVect1Res;
        private Label LenVect2Res;
    }
}
