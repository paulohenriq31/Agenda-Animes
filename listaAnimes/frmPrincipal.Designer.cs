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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.grbOpcao = new System.Windows.Forms.GroupBox();
            this.rdbFavorito = new System.Windows.Forms.RadioButton();
            this.rbnGeral = new System.Windows.Forms.RadioButton();
            this.rbnSeries = new System.Windows.Forms.RadioButton();
            this.rbnFilmes = new System.Windows.Forms.RadioButton();
            this.rbnAnime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridConteudo = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdiconar = new System.Windows.Forms.Button();
            this.btnAdcionarMinhaLista = new System.Windows.Forms.Button();
            this.grbOpcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConteudo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOpcao
            // 
            this.grbOpcao.Controls.Add(this.rdbFavorito);
            this.grbOpcao.Controls.Add(this.rbnGeral);
            this.grbOpcao.Controls.Add(this.rbnSeries);
            this.grbOpcao.Controls.Add(this.rbnFilmes);
            this.grbOpcao.Controls.Add(this.rbnAnime);
            this.grbOpcao.Location = new System.Drawing.Point(16, 74);
            this.grbOpcao.Name = "grbOpcao";
            this.grbOpcao.Size = new System.Drawing.Size(116, 156);
            this.grbOpcao.TabIndex = 0;
            this.grbOpcao.TabStop = false;
            this.grbOpcao.Text = "Opções";
            // 
            // rdbFavorito
            // 
            this.rdbFavorito.AutoSize = true;
            this.rdbFavorito.Location = new System.Drawing.Point(11, 124);
            this.rdbFavorito.Name = "rdbFavorito";
            this.rdbFavorito.Size = new System.Drawing.Size(68, 17);
            this.rdbFavorito.TabIndex = 4;
            this.rdbFavorito.TabStop = true;
            this.rdbFavorito.Text = "Favoritos";
            this.rdbFavorito.UseVisualStyleBackColor = true;
            this.rdbFavorito.CheckedChanged += new System.EventHandler(this.rdbFavorito_CheckedChanged);
            // 
            // rbnGeral
            // 
            this.rbnGeral.AutoSize = true;
            this.rbnGeral.Location = new System.Drawing.Point(11, 32);
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
            this.rbnSeries.CheckedChanged += new System.EventHandler(this.rbnSeries_CheckedChanged);
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
            this.rbnFilmes.CheckedChanged += new System.EventHandler(this.rbnFilmes_CheckedChanged);
            // 
            // rbnAnime
            // 
            this.rbnAnime.AutoSize = true;
            this.rbnAnime.Location = new System.Drawing.Point(11, 101);
            this.rbnAnime.Name = "rbnAnime";
            this.rbnAnime.Size = new System.Drawing.Size(54, 17);
            this.rbnAnime.TabIndex = 0;
            this.rbnAnime.TabStop = true;
            this.rbnAnime.Text = "Anime";
            this.rbnAnime.UseVisualStyleBackColor = true;
            this.rbnAnime.CheckedChanged += new System.EventHandler(this.rbnAnime_CheckedChanged);
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
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(157, 35);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(590, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // dataGridConteudo
            // 
            this.dataGridConteudo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridConteudo.CausesValidation = false;
            this.dataGridConteudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConteudo.Location = new System.Drawing.Point(157, 74);
            this.dataGridConteudo.MultiSelect = false;
            this.dataGridConteudo.Name = "dataGridConteudo";
            this.dataGridConteudo.Size = new System.Drawing.Size(718, 411);
            this.dataGridConteudo.TabIndex = 3;
            this.dataGridConteudo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridConteudo_CellContentClick);
            this.dataGridConteudo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridConteudo_CellMouseClick);
            this.dataGridConteudo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridConteudo_CellMouseDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(800, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdiconar
            // 
            this.btnAdiconar.Location = new System.Drawing.Point(12, 397);
            this.btnAdiconar.Name = "btnAdiconar";
            this.btnAdiconar.Size = new System.Drawing.Size(116, 41);
            this.btnAdiconar.TabIndex = 5;
            this.btnAdiconar.Text = "Adicionar Conteudo";
            this.btnAdiconar.UseCompatibleTextRendering = true;
            this.btnAdiconar.UseVisualStyleBackColor = true;
            this.btnAdiconar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdcionarMinhaLista
            // 
            this.btnAdcionarMinhaLista.Location = new System.Drawing.Point(12, 444);
            this.btnAdcionarMinhaLista.Name = "btnAdcionarMinhaLista";
            this.btnAdcionarMinhaLista.Size = new System.Drawing.Size(116, 41);
            this.btnAdcionarMinhaLista.TabIndex = 6;
            this.btnAdcionarMinhaLista.Text = "Adcicionar Favoritos";
            this.btnAdcionarMinhaLista.UseCompatibleTextRendering = true;
            this.btnAdcionarMinhaLista.UseVisualStyleBackColor = true;
            this.btnAdcionarMinhaLista.Click += new System.EventHandler(this.btnAdcionarMinhaLista_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 504);
            this.Controls.Add(this.btnAdcionarMinhaLista);
            this.Controls.Add(this.btnAdiconar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridConteudo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbOpcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAdiconar;
        private System.Windows.Forms.Button btnAdcionarMinhaLista;
        private System.Windows.Forms.RadioButton rdbFavorito;
        protected System.Windows.Forms.DataGridView dataGridConteudo;
    }
}