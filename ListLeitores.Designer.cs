namespace POO_BIBLIOTECA
{
    partial class ListLeitores
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            tempodev = new DataGridViewTextBoxColumn();
            leitorBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, tempodev });
            dataGridView1.Location = new Point(13, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 338);
            dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // tempodev
            // 
            tempodev.HeaderText = "Tempo de Devolução";
            tempodev.Name = "tempodev";
            // 
            // leitorBindingSource
            // 
            leitorBindingSource.DataSource = typeof(Leitor);
            // 
            // ListLeitores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 404);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "ListLeitores";
            Text = "ListLeitores";
            Load += ListLeitores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leitorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource leitorBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn tempodev;
    }
}