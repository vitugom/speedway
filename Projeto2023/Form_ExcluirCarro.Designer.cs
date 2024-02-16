namespace Projeto2023
{
    partial class Form_ExcluirCarro
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
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lbl_TituloExcluir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carros)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Carros
            // 
            this.Dgv_Carros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_Carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Carros.Location = new System.Drawing.Point(12, 44);
            this.Dgv_Carros.Name = "Dgv_Carros";
            this.Dgv_Carros.Size = new System.Drawing.Size(423, 144);
            this.Dgv_Carros.TabIndex = 0;
            this.Dgv_Carros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Carros_CellClick);
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(360, 197);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirmar.TabIndex = 1;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(264, 197);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Lbl_TituloExcluir
            // 
            this.Lbl_TituloExcluir.AutoSize = true;
            this.Lbl_TituloExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloExcluir.ForeColor = System.Drawing.Color.White;
            this.Lbl_TituloExcluir.Location = new System.Drawing.Point(12, 9);
            this.Lbl_TituloExcluir.Name = "Lbl_TituloExcluir";
            this.Lbl_TituloExcluir.Size = new System.Drawing.Size(287, 25);
            this.Lbl_TituloExcluir.TabIndex = 3;
            this.Lbl_TituloExcluir.Text = "Selecionar carro para excluir";
            // 
            // Form_ExcluirCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(447, 232);
            this.Controls.Add(this.Lbl_TituloExcluir);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Dgv_Carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ExcluirCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_ExcluirCarro";
            this.Load += new System.EventHandler(this.Form_ExcluirCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Carros;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_TituloExcluir;
    }
}