﻿namespace PrimeraConexion
{
    partial class Form1
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pboxDiscos = new System.Windows.Forms.PictureBox();
            this.lblDiscos = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.dgvEstilos = new System.Windows.Forms.DataGridView();
            this.lblEstilos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(40, 108);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.Size = new System.Drawing.Size(158, 278);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pboxDiscos
            // 
            this.pboxDiscos.Location = new System.Drawing.Point(517, 159);
            this.pboxDiscos.Name = "pboxDiscos";
            this.pboxDiscos.Size = new System.Drawing.Size(212, 177);
            this.pboxDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDiscos.TabIndex = 1;
            this.pboxDiscos.TabStop = false;
            // 
            // lblDiscos
            // 
            this.lblDiscos.AutoSize = true;
            this.lblDiscos.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscos.Location = new System.Drawing.Point(36, 69);
            this.lblDiscos.Name = "lblDiscos";
            this.lblDiscos.Size = new System.Drawing.Size(67, 21);
            this.lblDiscos.TabIndex = 2;
            this.lblDiscos.Text = "Discos";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(593, 69);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblImagen.Size = new System.Drawing.Size(73, 21);
            this.lblImagen.TabIndex = 3;
            this.lblImagen.Text = "Imagen";
            // 
            // dgvEstilos
            // 
            this.dgvEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstilos.Location = new System.Drawing.Point(296, 108);
            this.dgvEstilos.Name = "dgvEstilos";
            this.dgvEstilos.Size = new System.Drawing.Size(158, 278);
            this.dgvEstilos.TabIndex = 4;
            // 
            // lblEstilos
            // 
            this.lblEstilos.AutoSize = true;
            this.lblEstilos.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilos.Location = new System.Drawing.Point(292, 69);
            this.lblEstilos.Name = "lblEstilos";
            this.lblEstilos.Size = new System.Drawing.Size(71, 21);
            this.lblEstilos.TabIndex = 5;
            this.lblEstilos.Text = "Estilos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 403);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEstilos);
            this.Controls.Add(this.dgvEstilos);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblDiscos);
            this.Controls.Add(this.pboxDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pboxDiscos;
        private System.Windows.Forms.Label lblDiscos;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.DataGridView dgvEstilos;
        private System.Windows.Forms.Label lblEstilos;
        private System.Windows.Forms.Button btnAgregar;
    }
}

