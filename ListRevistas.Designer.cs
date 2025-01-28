namespace POO_BIBLIOTECA
{
    partial class ListRevistas
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            edicao = new DataGridViewTextBoxColumn();
            AnoPub = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            leitorBindingSource = new BindingSource(components);
            revistaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)revistaBindingSource).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 5;
            label1.Text = "Filtrar por ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(534, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Titulo, Autor, edicao, AnoPub, ISBN });
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 393);
            dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
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
            // leitorBindingSource
            // 
            leitorBindingSource.DataSource = typeof(Leitor);
            // 
            // revistaBindingSource
            // 
            revistaBindingSource.DataSource = typeof(Revista);
            // 
            // ListRevistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 450);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ListRevistas";
            Text = "ListRevistas";
            Load += ListRevistas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)revistaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn edicao;
        private DataGridViewTextBoxColumn AnoPub;
        private DataGridViewTextBoxColumn ISBN;
        private BindingSource leitorBindingSource;
        private BindingSource revistaBindingSource;
    }
}