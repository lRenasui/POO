namespace POO_BIBLIOTECA
{
    partial class Historico
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
            Nome = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            data_entrega = new DataGridViewTextBoxColumn();
            Entregue = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nome, titulo, data_entrega, Entregue });
            dataGridView1.Location = new Point(244, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 426);
            dataGridView1.TabIndex = 7;
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
            // Entregue
            // 
            Entregue.HeaderText = "Entregue";
            Entregue.Name = "Entregue";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Professor", "Estudante", "Leitor Comum", "Senior" });
            comboBox1.Location = new Point(12, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(226, 23);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 10;
            label1.Text = "Tipo de Leitores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 11;
            label2.Text = "Leitores";
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Historico";
            Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn data_entrega;
        private DataGridViewTextBoxColumn Entregue;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
    }
}