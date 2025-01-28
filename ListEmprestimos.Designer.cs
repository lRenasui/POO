namespace POO_BIBLIOTECA
{
    partial class ListEmprestimos
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            data_entrega = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(93, 51);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nome, titulo, data_entrega });
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 369);
            dataGridView1.TabIndex = 6;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            // 
            // data_entrega
            // 
            data_entrega.HeaderText = "Data de entrega";
            data_entrega.Name = "data_entrega";
            // 
            // button2
            // 
            button2.Location = new Point(111, 12);
            button2.Name = "button2";
            button2.Size = new Size(84, 51);
            button2.TabIndex = 7;
            button2.Text = "Entregar Livro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(201, 15);
            button3.Name = "button3";
            button3.Size = new Size(75, 45);
            button3.TabIndex = 8;
            button3.Text = "Histórico do Leitor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(282, 15);
            button4.Name = "button4";
            button4.Size = new Size(85, 45);
            button4.TabIndex = 9;
            button4.Text = "Prorrogar Emprestimo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ListEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "ListEmprestimos";
            Text = "ListEmprestimos";
            Load += ListEmprestimos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn data_entrega;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}