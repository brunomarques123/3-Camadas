﻿
namespace Apresentacao
{
    partial class DisciplinaForm
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
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.lbnCargaHoraria = new System.Windows.Forms.Label();
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(273, 63);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_Inserir.TabIndex = 0;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 23);
            this.textBox1.TabIndex = 1;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(100, 64);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(167, 23);
            this.txtCargaHoraria.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(12, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(43, 15);
            this.txtNome.TabIndex = 3;
            this.txtNome.Text = "Nome:";
            // 
            // lbnCargaHoraria
            // 
            this.lbnCargaHoraria.AutoSize = true;
            this.lbnCargaHoraria.Location = new System.Drawing.Point(12, 67);
            this.lbnCargaHoraria.Name = "lbnCargaHoraria";
            this.lbnCargaHoraria.Size = new System.Drawing.Size(85, 15);
            this.lbnCargaHoraria.TabIndex = 4;
            this.lbnCargaHoraria.Text = "Carga-Horaria:";
            // 
            // dgvDisciplinas
            // 
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Location = new System.Drawing.Point(12, 93);
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.RowTemplate.Height = 25;
            this.dgvDisciplinas.Size = new System.Drawing.Size(336, 250);
            this.dgvDisciplinas.TabIndex = 5;
            // 
            // DisciplinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 355);
            this.Controls.Add(this.dgvDisciplinas);
            this.Controls.Add(this.lbnCargaHoraria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Inserir);
            this.Name = "DisciplinaForm";
            this.Text = "DisciplinaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label lbnCargaHoraria;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
    }
}