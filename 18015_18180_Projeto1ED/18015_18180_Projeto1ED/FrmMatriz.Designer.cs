﻿namespace _18015_18180_Projeto1ED
{
    partial class frmMatriz
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMatriz1 = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxQualMatriz = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbMultiplicar = new System.Windows.Forms.GroupBox();
            this.txtConstMult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColunaMult = new System.Windows.Forms.TextBox();
            this.txtLinhaMult = new System.Windows.Forms.TextBox();
            this.gbSomar = new System.Windows.Forms.GroupBox();
            this.txtConstSomar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColunaSoma = new System.Windows.Forms.TextBox();
            this.txtLinhaSoma = new System.Windows.Forms.TextBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvMatriz2 = new System.Windows.Forms.DataGridView();
            this.btnArquivo1 = new System.Windows.Forms.Button();
            this.btnArquivo2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).BeginInit();
            this.gbOperacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMultiplicar.SuspendLayout();
            this.gbSomar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatriz1
            // 
            this.dgvMatriz1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMatriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatriz1.ColumnHeadersVisible = false;
            this.dgvMatriz1.Location = new System.Drawing.Point(12, 41);
            this.dgvMatriz1.MultiSelect = false;
            this.dgvMatriz1.Name = "dgvMatriz1";
            this.dgvMatriz1.ReadOnly = true;
            this.dgvMatriz1.RowHeadersVisible = false;
            this.dgvMatriz1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriz1.Size = new System.Drawing.Size(308, 290);
            this.dgvMatriz1.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(96, 26);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(78, 62);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(174, 23);
            this.txtValor.TabIndex = 2;
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.Controls.Add(this.groupBox1);
            this.gbOperacoes.Controls.Add(this.label10);
            this.gbOperacoes.Controls.Add(this.label11);
            this.gbOperacoes.Controls.Add(this.label9);
            this.gbOperacoes.Controls.Add(this.gbMultiplicar);
            this.gbOperacoes.Controls.Add(this.gbSomar);
            this.gbOperacoes.Controls.Add(this.txtLinha);
            this.gbOperacoes.Controls.Add(this.txtColuna);
            this.gbOperacoes.Controls.Add(this.txtValor);
            this.gbOperacoes.Controls.Add(this.btnInserir);
            this.gbOperacoes.Controls.Add(this.btnRemover);
            this.gbOperacoes.Controls.Add(this.btnProcurar);
            this.gbOperacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperacoes.Location = new System.Drawing.Point(640, 41);
            this.gbOperacoes.Name = "gbOperacoes";
            this.gbOperacoes.Size = new System.Drawing.Size(328, 586);
            this.gbOperacoes.TabIndex = 3;
            this.gbOperacoes.TabStop = false;
            this.gbOperacoes.Text = "Operações";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.cbxQualMatriz);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(6, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qual Matriz?";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(99, 27);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(18, 27);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // cbxQualMatriz
            // 
            this.cbxQualMatriz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQualMatriz.FormattingEnabled = true;
            this.cbxQualMatriz.Location = new System.Drawing.Point(71, 62);
            this.cbxQualMatriz.Name = "cbxQualMatriz";
            this.cbxQualMatriz.Size = new System.Drawing.Size(174, 25);
            this.cbxQualMatriz.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Matriz:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Linha: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Coluna:";
            // 
            // gbMultiplicar
            // 
            this.gbMultiplicar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMultiplicar.Controls.Add(this.txtConstMult);
            this.gbMultiplicar.Controls.Add(this.label6);
            this.gbMultiplicar.Controls.Add(this.label5);
            this.gbMultiplicar.Controls.Add(this.label3);
            this.gbMultiplicar.Controls.Add(this.label4);
            this.gbMultiplicar.Controls.Add(this.txtColunaMult);
            this.gbMultiplicar.Controls.Add(this.txtLinhaMult);
            this.gbMultiplicar.Location = new System.Drawing.Point(6, 306);
            this.gbMultiplicar.Name = "gbMultiplicar";
            this.gbMultiplicar.Size = new System.Drawing.Size(316, 138);
            this.gbMultiplicar.TabIndex = 4;
            this.gbMultiplicar.TabStop = false;
            this.gbMultiplicar.Text = "Multiplicar Por Constante";
            // 
            // txtConstMult
            // 
            this.txtConstMult.Location = new System.Drawing.Point(23, 106);
            this.txtConstMult.Name = "txtConstMult";
            this.txtConstMult.Size = new System.Drawing.Size(100, 23);
            this.txtConstMult.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Constante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "OU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coluna:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Linha: ";
            // 
            // txtColunaMult
            // 
            this.txtColunaMult.Location = new System.Drawing.Point(193, 48);
            this.txtColunaMult.Name = "txtColunaMult";
            this.txtColunaMult.Size = new System.Drawing.Size(100, 23);
            this.txtColunaMult.TabIndex = 1;
            this.txtColunaMult.TextChanged += new System.EventHandler(this.txtColunaMult_TextChanged);
            this.txtColunaMult.Leave += new System.EventHandler(this.txtColunaMult_Leave);
            // 
            // txtLinhaMult
            // 
            this.txtLinhaMult.Location = new System.Drawing.Point(23, 48);
            this.txtLinhaMult.Name = "txtLinhaMult";
            this.txtLinhaMult.Size = new System.Drawing.Size(100, 23);
            this.txtLinhaMult.TabIndex = 0;
            this.txtLinhaMult.TextChanged += new System.EventHandler(this.txtLinhaMult_TextChanged);
            this.txtLinhaMult.Leave += new System.EventHandler(this.txtLinhaMult_Leave);
            // 
            // gbSomar
            // 
            this.gbSomar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSomar.Controls.Add(this.txtConstSomar);
            this.gbSomar.Controls.Add(this.label1);
            this.gbSomar.Controls.Add(this.label2);
            this.gbSomar.Controls.Add(this.label7);
            this.gbSomar.Controls.Add(this.label8);
            this.gbSomar.Controls.Add(this.txtColunaSoma);
            this.gbSomar.Controls.Add(this.txtLinhaSoma);
            this.gbSomar.Location = new System.Drawing.Point(6, 162);
            this.gbSomar.Name = "gbSomar";
            this.gbSomar.Size = new System.Drawing.Size(316, 138);
            this.gbSomar.TabIndex = 3;
            this.gbSomar.TabStop = false;
            this.gbSomar.Text = "Somar Constante";
            // 
            // txtConstSomar
            // 
            this.txtConstSomar.Location = new System.Drawing.Point(17, 101);
            this.txtConstSomar.Name = "txtConstSomar";
            this.txtConstSomar.Size = new System.Drawing.Size(100, 23);
            this.txtConstSomar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Constante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "OU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Coluna:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Linha: ";
            // 
            // txtColunaSoma
            // 
            this.txtColunaSoma.Location = new System.Drawing.Point(187, 43);
            this.txtColunaSoma.Name = "txtColunaSoma";
            this.txtColunaSoma.Size = new System.Drawing.Size(100, 23);
            this.txtColunaSoma.TabIndex = 9;
            this.txtColunaSoma.TextChanged += new System.EventHandler(this.txtColunaSoma_TextChanged);
            this.txtColunaSoma.Leave += new System.EventHandler(this.txtColunaSoma_Leave);
            // 
            // txtLinhaSoma
            // 
            this.txtLinhaSoma.Location = new System.Drawing.Point(17, 43);
            this.txtLinhaSoma.Name = "txtLinhaSoma";
            this.txtLinhaSoma.Size = new System.Drawing.Size(100, 23);
            this.txtLinhaSoma.TabIndex = 8;
            this.txtLinhaSoma.TextChanged += new System.EventHandler(this.txtLinhaSoma_TextChanged);
            this.txtLinhaSoma.Leave += new System.EventHandler(this.txtLinhaSoma_Leave);
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(78, 120);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(174, 23);
            this.txtLinha.TabIndex = 2;
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(78, 91);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(174, 23);
            this.txtColuna.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(15, 26);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(177, 26);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 337);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(308, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvMatriz2
            // 
            this.dgvMatriz2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMatriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatriz2.ColumnHeadersVisible = false;
            this.dgvMatriz2.Location = new System.Drawing.Point(326, 41);
            this.dgvMatriz2.MultiSelect = false;
            this.dgvMatriz2.Name = "dgvMatriz2";
            this.dgvMatriz2.ReadOnly = true;
            this.dgvMatriz2.RowHeadersVisible = false;
            this.dgvMatriz2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMatriz2.Size = new System.Drawing.Size(308, 290);
            this.dgvMatriz2.TabIndex = 0;
            // 
            // btnArquivo1
            // 
            this.btnArquivo1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnArquivo1.Location = new System.Drawing.Point(12, 12);
            this.btnArquivo1.Name = "btnArquivo1";
            this.btnArquivo1.Size = new System.Drawing.Size(84, 23);
            this.btnArquivo1.TabIndex = 4;
            this.btnArquivo1.Text = "Arquivo 1";
            this.btnArquivo1.UseVisualStyleBackColor = true;
            this.btnArquivo1.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnArquivo2
            // 
            this.btnArquivo2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnArquivo2.Location = new System.Drawing.Point(102, 12);
            this.btnArquivo2.Name = "btnArquivo2";
            this.btnArquivo2.Size = new System.Drawing.Size(84, 23);
            this.btnArquivo2.TabIndex = 4;
            this.btnArquivo2.Text = "Arquivo 2";
            this.btnArquivo2.UseVisualStyleBackColor = true;
            this.btnArquivo2.Click += new System.EventHandler(this.btnArquivo2_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 639);
            this.Controls.Add(this.btnArquivo2);
            this.Controls.Add(this.btnArquivo1);
            this.Controls.Add(this.gbOperacoes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvMatriz2);
            this.Controls.Add(this.dgvMatriz1);
            this.Name = "frmMatriz";
            this.Text = "Operações com Matriz Esparsa | Estrutura de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz1)).EndInit();
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMultiplicar.ResumeLayout(false);
            this.gbMultiplicar.PerformLayout();
            this.gbSomar.ResumeLayout(false);
            this.gbSomar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriz1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox gbOperacoes;
        private System.Windows.Forms.GroupBox gbSomar;
        private System.Windows.Forms.GroupBox gbMultiplicar;
        private System.Windows.Forms.TextBox txtConstMult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColunaMult;
        private System.Windows.Forms.TextBox txtLinhaMult;
        private System.Windows.Forms.TextBox txtConstSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColunaSoma;
        private System.Windows.Forms.TextBox txtLinhaSoma;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvMatriz2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxQualMatriz;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnArquivo1;
        private System.Windows.Forms.Button btnArquivo2;
    }
}

