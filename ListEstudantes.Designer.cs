namespace POO_BIBLIOTECA
{
    partial class ListEstudantes
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
            nome = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            N_Livro_Requesitados = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, Ano, N_Livro_Requesitados });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 249);
            dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // Ano
            // 
            Ano.HeaderText = "Ano";
            Ano.Name = "Ano";
            // 
            // N_Livro_Requesitados
            // 
            N_Livro_Requesitados.HeaderText = "Número de Livros Requesitados";
            N_Livro_Requesitados.Name = "N_Livro_Requesitados";
            // 
            // ListEstudantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 298);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "ListEstudantes";
            Text = "ListEstudantes";
            Load += ListEstudantes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewTextBoxColumn N_Livro_Requesitados;
    }
}