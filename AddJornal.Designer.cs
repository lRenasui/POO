namespace POO_BIBLIOTECA
{
    partial class AddJornal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 70);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 143);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 5;
            label4.Text = "Ano de Publicação:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 119);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 94);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 3;
            label6.Text = "Edição:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 168);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 6;
            label7.Text = "ISSN:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 91);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(85, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(52, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(58, 165);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(127, 23);
            textBox7.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(12, 194);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddJornal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 225);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddJornal";
            Text = "AddJornal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button2;
    }
}