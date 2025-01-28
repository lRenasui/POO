namespace POO_BIBLIOTECA
{
    partial class AddReserva
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
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 178);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 33);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 14;
            label6.Text = "Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 134);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 13;
            label7.Text = "Livros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 133);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 12;
            label8.Text = "Leitores";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 64);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 11;
            label9.Text = "Tipo de Livro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 64);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 10;
            label10.Text = "Tipo de Leitor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(151, 151);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(245, 23);
            comboBox5.TabIndex = 19;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Revistas", "Jornais", "Livros Cientificos", "Livros Educativos", "Livros de Ficção" });
            comboBox6.Location = new Point(151, 82);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 18;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(10, 150);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(121, 23);
            comboBox7.TabIndex = 17;
            comboBox7.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Leitor Comum", "Senior", "Estudante", "Professor" });
            comboBox8.Location = new Point(9, 82);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(121, 23);
            comboBox8.TabIndex = 16;
            comboBox8.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
            // 
            // AddReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 208);
            Controls.Add(comboBox5);
            Controls.Add(comboBox6);
            Controls.Add(comboBox7);
            Controls.Add(comboBox8);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(button1);
            Name = "AddReserva";
            Text = "AddReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
    }
}