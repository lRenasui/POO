namespace POO_BIBLIOTECA
{
    partial class ListMultas
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
            Id_p = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            TipoP = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 41);
            button1.TabIndex = 0;
            button1.Text = "Pagar Multa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Id_p, nome, TipoP, Valor });
            dataGridView1.Location = new Point(12, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(533, 379);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Id_p
            // 
            Id_p.HeaderText = "Id do Leitor";
            Id_p.Name = "Id_p";
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // TipoP
            // 
            TipoP.HeaderText = "Tipo de Leitor";
            TipoP.Name = "TipoP";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // ListMultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "ListMultas";
            Text = "ListMultas";
            Load += ListMultas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Id_p;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn TipoP;
        private DataGridViewTextBoxColumn Valor;
    }
}