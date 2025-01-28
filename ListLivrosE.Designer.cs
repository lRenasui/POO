namespace POO_BIBLIOTECA
{
    partial class ListLivrosE
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            AnodeEscolaridade = new DataGridViewTextBoxColumn();
            AnoPub = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, titulo, autor, AnodeEscolaridade, AnoPub, ISBN });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 397);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.Name = "autor";
            // 
            // AnodeEscolaridade
            // 
            AnodeEscolaridade.HeaderText = "Ano de Escolaridade";
            AnodeEscolaridade.Name = "AnodeEscolaridade";
            // 
            // AnoPub
            // 
            AnoPub.HeaderText = "Ano de Publicação";
            AnoPub.Name = "AnoPub";
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListLivrosE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ListLivrosE";
            Text = "ListLivrosE";
            Load += ListLivrosE_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn AnodeEscolaridade;
        private DataGridViewTextBoxColumn AnoPub;
        private DataGridViewTextBoxColumn ISBN;
    }
}