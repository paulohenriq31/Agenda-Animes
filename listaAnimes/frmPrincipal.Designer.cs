﻿namespace listaAnimes
{
    partial class frmPrincipal
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
            this.grbOpcao = new System.Windows.Forms.GroupBox();
            this.rbnGeral = new System.Windows.Forms.RadioButton();
            this.rbnSeries = new System.Windows.Forms.RadioButton();
            this.rbnFilmes = new System.Windows.Forms.RadioButton();
            this.rbnAnime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridConteudo = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdiconar = new System.Windows.Forms.Button();
            this.grbOpcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConteudo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOpcao
            // 
            this.grbOpcao.Controls.Add(this.rbnGeral);
            this.grbOpcao.Controls.Add(this.rbnSeries);
            this.grbOpcao.Controls.Add(this.rbnFilmes);
            this.grbOpcao.Controls.Add(this.rbnAnime);
            this.grbOpcao.Location = new System.Drawing.Point(16, 22);
            this.grbOpcao.Name = "grbOpcao";
            this.grbOpcao.Size = new System.Drawing.Size(116, 131);
            this.grbOpcao.TabIndex = 0;
            this.grbOpcao.TabStop = false;
            this.grbOpcao.Text = "Opções";
            // 
            // rbnGeral
            // 
            this.rbnGeral.AutoSize = true;
            this.rbnGeral.Location = new System.Drawing.Point(11, 101);
            this.rbnGeral.Name = "rbnGeral";
            this.rbnGeral.Size = new System.Drawing.Size(50, 17);
            this.rbnGeral.TabIndex = 3;
            this.rbnGeral.TabStop = true;
            this.rbnGeral.Text = "Geral";
            this.rbnGeral.UseVisualStyleBackColor = true;
            this.rbnGeral.CheckedChanged += new System.EventHandler(this.rbnGeral_CheckedChanged);
            // 
            // rbnSeries
            // 
            this.rbnSeries.AutoSize = true;
            this.rbnSeries.Location = new System.Drawing.Point(11, 78);
            this.rbnSeries.Name = "rbnSeries";
            this.rbnSeries.Size = new System.Drawing.Size(54, 17);
            this.rbnSeries.TabIndex = 2;
            this.rbnSeries.TabStop = true;
            this.rbnSeries.Text = "Séries";
            this.rbnSeries.UseVisualStyleBackColor = true;
            // 
            // rbnFilmes
            // 
            this.rbnFilmes.AutoSize = true;
            this.rbnFilmes.Location = new System.Drawing.Point(11, 55);
            this.rbnFilmes.Name = "rbnFilmes";
            this.rbnFilmes.Size = new System.Drawing.Size(54, 17);
            this.rbnFilmes.TabIndex = 1;
            this.rbnFilmes.TabStop = true;
            this.rbnFilmes.Text = "Filmes";
            this.rbnFilmes.UseVisualStyleBackColor = true;
            // 
            // rbnAnime
            // 
            this.rbnAnime.AutoSize = true;
            this.rbnAnime.Location = new System.Drawing.Point(11, 32);
            this.rbnAnime.Name = "rbnAnime";
            this.rbnAnime.Size = new System.Drawing.Size(54, 17);
            this.rbnAnime.TabIndex = 0;
            this.rbnAnime.TabStop = true;
            this.rbnAnime.Text = "Anime";
            this.rbnAnime.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar Conteúdo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridConteudo
            // 
            this.dataGridConteudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConteudo.Location = new System.Drawing.Point(157, 74);
            this.dataGridConteudo.Name = "dataGridConteudo";
            this.dataGridConteudo.Size = new System.Drawing.Size(439, 264);
            this.dataGridConteudo.TabIndex = 3;
            this.dataGridConteudo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConteudo_CellContentClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(620, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAdiconar
            // 
            this.btnAdiconar.Location = new System.Drawing.Point(620, 315);
            this.btnAdiconar.Name = "btnAdiconar";
            this.btnAdiconar.Size = new System.Drawing.Size(75, 23);
            this.btnAdiconar.TabIndex = 5;
            this.btnAdiconar.Text = "Adicionar";
            this.btnAdiconar.UseVisualStyleBackColor = true;
            this.btnAdiconar.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 366);
            this.Controls.Add(this.btnAdiconar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridConteudo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbOpcao);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grbOpcao.ResumeLayout(false);
            this.grbOpcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConteudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpcao;
        private System.Windows.Forms.RadioButton rbnGeral;
        private System.Windows.Forms.RadioButton rbnSeries;
        private System.Windows.Forms.RadioButton rbnFilmes;
        private System.Windows.Forms.RadioButton rbnAnime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridConteudo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAdiconar;
    }
}