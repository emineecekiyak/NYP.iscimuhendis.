namespace Nyp.Odev._24._10
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
            adTxt = new TextBox();
            adresTxt = new TextBox();
            yasTxt = new TextBox();
            mesaiTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // adTxt
            // 
            adTxt.Location = new Point(86, 37);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 0;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(86, 105);
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(125, 27);
            adresTxt.TabIndex = 1;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(86, 177);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(125, 27);
            yasTxt.TabIndex = 2;
            // 
            // mesaiTxt
            // 
            mesaiTxt.Location = new Point(86, 246);
            mesaiTxt.Name = "mesaiTxt";
            mesaiTxt.Size = new Size(125, 27);
            mesaiTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 5;
            label1.Text = "ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 112);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 184);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 7;
            label3.Text = "yas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 253);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "mesai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 321);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "unvan";
            // 
            // button1
            // 
            button1.Location = new Point(86, 378);
            button1.Name = "button1";
            button1.Size = new Size(199, 51);
            button1.TabIndex = 10;
            button1.Text = "Personel Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(86, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mesaiTxt);
            Controls.Add(yasTxt);
            Controls.Add(adresTxt);
            Controls.Add(adTxt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox adTxt;
        private TextBox adresTxt;
        private TextBox yasTxt;
        private TextBox mesaiTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ComboBox comboBox1;
    }
}