namespace POO_BIBLIOTECA
{
    partial class AddEmprestimo
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Leitor Comum", "Senior", "Estudante", "Professor" });
            comboBox1.Location = new Point(12, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(13, 146);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Revistas", "Jornais", "Livros Cientificos", "Livros Educativos", "Livros de Ficção" });
            comboBox3.Location = new Point(149, 78);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 2;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(154, 147);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(245, 23);
            comboBox4.TabIndex = 3;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(13, 175);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 52);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Leitor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 54);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Tipo de Livro";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 121);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Leitores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 122);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Livros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 21);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 9;
            label5.Text = "Id:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // AddEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 210);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "AddEmprestimo";
            Text = "AddEmprestimo";
            Load += AddEmprestimo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}