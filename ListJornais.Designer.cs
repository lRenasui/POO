namespace POO_BIBLIOTECA
{
    partial class ListJornais
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
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            edicao = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            Anopub = new DataGridViewTextBoxColumn();
            issn = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Autor, edicao, categoria, Anopub, issn });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 397);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            // 
            // edicao
            // 
            edicao.HeaderText = "Edição";
            edicao.Name = "edicao";
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            // 
            // Anopub
            // 
            Anopub.HeaderText = "Ano de Publicação";
            Anopub.Name = "Anopub";
            // 
            // issn
            // 
            issn.HeaderText = "ISSN";
            issn.Name = "issn";
            // 
            // ListJornais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "ListJornais";
            Text = "ListJornais";
            Load += ListJornais_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn edicao;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn Anopub;
        private DataGridViewTextBoxColumn issn;
    }
}