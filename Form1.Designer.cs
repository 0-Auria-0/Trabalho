namespace Trabalho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvVeiculos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 40);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.Location = new Point(111, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LavenderBlush;
            textBox2.Location = new Point(466, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 65);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Modelo:";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LavenderBlush;
            textBox3.Location = new Point(466, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 94);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Marca:";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LavenderBlush;
            textBox4.Location = new Point(111, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(271, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 65);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Ano:";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LavenderBlush;
            textBox5.Location = new Point(111, 91);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(271, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 94);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Placa:";
            label5.Click += label5_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LavenderBlush;
            textBox6.Location = new Point(466, 33);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(256, 23);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 35);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Dono:";
            label6.Click += label6_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LavenderBlush;
            btnSalvar.Location = new Point(67, 145);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar Veículo";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LavenderBlush;
            btnEditar.Location = new Point(342, 145);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 23);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar Selecionado";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LavenderBlush;
            btnExcluir.Location = new Point(622, 145);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 23);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir Veículo";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.BackgroundColor = Color.WhiteSmoke;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Location = new Point(67, 174);
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.Size = new Size(655, 272);
            dgvVeiculos.TabIndex = 15;
            dgvVeiculos.CellClick += dgvVeiculos_CellClick;
            dgvVeiculos.CellContentClick += dgvVeiculos_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(805, 488);
            Controls.Add(dgvVeiculos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CadastrarVeículos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvVeiculos;
    }
}
