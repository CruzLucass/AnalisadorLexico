﻿
namespace AnalisadorLexico
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.RichTextBox();
            this.grdTblSimbolos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecionaArq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTblSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analisador Léxico";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(11, 88);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(408, 233);
            this.txtEntrada.TabIndex = 1;
            this.txtEntrada.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saída";
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(545, 88);
            this.txtSaida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(408, 233);
            this.txtSaida.TabIndex = 3;
            this.txtSaida.Text = "";
            // 
            // grdTblSimbolos
            // 
            this.grdTblSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTblSimbolos.Location = new System.Drawing.Point(545, 386);
            this.grdTblSimbolos.Margin = new System.Windows.Forms.Padding(2);
            this.grdTblSimbolos.Name = "grdTblSimbolos";
            this.grdTblSimbolos.RowHeadersWidth = 51;
            this.grdTblSimbolos.RowTemplate.Height = 24;
            this.grdTblSimbolos.Size = new System.Drawing.Size(408, 146);
            this.grdTblSimbolos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tabela de Simbolos";
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(459, 95);
            this.btnAnalisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(56, 19);
            this.btnAnalisar.TabIndex = 7;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(459, 137);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelecionaArq
            // 
            this.btnSelecionaArq.Location = new System.Drawing.Point(135, 342);
            this.btnSelecionaArq.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionaArq.Name = "btnSelecionaArq";
            this.btnSelecionaArq.Size = new System.Drawing.Size(113, 29);
            this.btnSelecionaArq.TabIndex = 9;
            this.btnSelecionaArq.Text = "Selecionar Arquivo";
            this.btnSelecionaArq.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 567);
            this.Controls.Add(this.btnSelecionaArq);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdTblSimbolos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.grdTblSimbolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtSaida;
        private System.Windows.Forms.DataGridView grdTblSimbolos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelecionaArq;
    }
}

