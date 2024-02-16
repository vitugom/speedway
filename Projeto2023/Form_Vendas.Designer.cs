namespace Projeto2023
{
    partial class Form_Vendas
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
            this.Fpnl_VendasRealizadas = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_vendas = new System.Windows.Forms.Label();
            this.Lbl_venda0 = new System.Windows.Forms.Label();
            this.Fpnl_VendasRealizadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fpnl_VendasRealizadas
            // 
            this.Fpnl_VendasRealizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fpnl_VendasRealizadas.AutoScroll = true;
            this.Fpnl_VendasRealizadas.Controls.Add(this.Lbl_venda0);
            this.Fpnl_VendasRealizadas.Location = new System.Drawing.Point(12, 56);
            this.Fpnl_VendasRealizadas.Name = "Fpnl_VendasRealizadas";
            this.Fpnl_VendasRealizadas.Size = new System.Drawing.Size(575, 343);
            this.Fpnl_VendasRealizadas.TabIndex = 0;
            // 
            // Lbl_vendas
            // 
            this.Lbl_vendas.AutoSize = true;
            this.Lbl_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vendas.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_vendas.Location = new System.Drawing.Point(12, 19);
            this.Lbl_vendas.Name = "Lbl_vendas";
            this.Lbl_vendas.Size = new System.Drawing.Size(190, 25);
            this.Lbl_vendas.TabIndex = 1;
            this.Lbl_vendas.Text = "Vendas realizadas";
            // 
            // Lbl_venda0
            // 
            this.Lbl_venda0.AutoSize = true;
            this.Lbl_venda0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_venda0.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_venda0.Location = new System.Drawing.Point(3, 0);
            this.Lbl_venda0.Name = "Lbl_venda0";
            this.Lbl_venda0.Size = new System.Drawing.Size(380, 33);
            this.Lbl_venda0.TabIndex = 2;
            this.Lbl_venda0.Text = "Nenhuma venda cadastrada";
            // 
            // Form_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.Lbl_vendas);
            this.Controls.Add(this.Fpnl_VendasRealizadas);
            this.Name = "Form_Vendas";
            this.Text = "Form_Vendas";
            this.Load += new System.EventHandler(this.Form_Vendas_Load);
            this.Fpnl_VendasRealizadas.ResumeLayout(false);
            this.Fpnl_VendasRealizadas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Fpnl_VendasRealizadas;
        private System.Windows.Forms.Label Lbl_vendas;
        private System.Windows.Forms.Label Lbl_venda0;
    }
}