namespace Projeto2023
{
    partial class Form_SelecionaCarro
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
            this.Dgv_Carros = new System.Windows.Forms.DataGridView();
            this.Lbl_Escolha = new System.Windows.Forms.Label();
            this.Btn_Continuar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carros)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Carros
            // 
            this.Dgv_Carros.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.Dgv_Carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Carros.Location = new System.Drawing.Point(12, 58);
            this.Dgv_Carros.Name = "Dgv_Carros";
            this.Dgv_Carros.Size = new System.Drawing.Size(439, 150);
            this.Dgv_Carros.TabIndex = 0;
            this.Dgv_Carros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Carros_CellClick);
            // 
            // Lbl_Escolha
            // 
            this.Lbl_Escolha.AutoSize = true;
            this.Lbl_Escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Escolha.ForeColor = System.Drawing.Color.White;
            this.Lbl_Escolha.Location = new System.Drawing.Point(12, 18);
            this.Lbl_Escolha.Name = "Lbl_Escolha";
            this.Lbl_Escolha.Size = new System.Drawing.Size(409, 24);
            this.Lbl_Escolha.TabIndex = 1;
            this.Lbl_Escolha.Text = "Escolha o veículo para prosseguir com a venda";
            // 
            // Btn_Continuar
            // 
            this.Btn_Continuar.Location = new System.Drawing.Point(355, 227);
            this.Btn_Continuar.Name = "Btn_Continuar";
            this.Btn_Continuar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Continuar.TabIndex = 2;
            this.Btn_Continuar.Text = "Continuar";
            this.Btn_Continuar.UseVisualStyleBackColor = true;
            this.Btn_Continuar.Click += new System.EventHandler(this.Btn_Continuar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(239, 227);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(96, 32);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Form_SelecionaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(463, 271);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Continuar);
            this.Controls.Add(this.Lbl_Escolha);
            this.Controls.Add(this.Dgv_Carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SelecionaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_SelecionaCarro";
            this.Load += new System.EventHandler(this.Form_SelecionaCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Carros;
        private System.Windows.Forms.Label Lbl_Escolha;
        private System.Windows.Forms.Button Btn_Continuar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}