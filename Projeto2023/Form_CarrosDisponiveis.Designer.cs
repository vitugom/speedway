namespace Projeto2023
{
    partial class Form_CarrosDisponiveis
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
            this.Ms_ModificaCarros = new System.Windows.Forms.MenuStrip();
            this.gerenciarVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Flp_ContainerCarro = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_Carros0 = new System.Windows.Forms.Label();
            this.Ms_ModificaCarros.SuspendLayout();
            this.Flp_ContainerCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ms_ModificaCarros
            // 
            this.Ms_ModificaCarros.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Ms_ModificaCarros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarVeiculosToolStripMenuItem});
            this.Ms_ModificaCarros.Location = new System.Drawing.Point(0, 0);
            this.Ms_ModificaCarros.Name = "Ms_ModificaCarros";
            this.Ms_ModificaCarros.Size = new System.Drawing.Size(599, 24);
            this.Ms_ModificaCarros.TabIndex = 0;
            this.Ms_ModificaCarros.Text = "menuStrip1";
            // 
            // gerenciarVeiculosToolStripMenuItem
            // 
            this.gerenciarVeiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirCarroToolStripMenuItem,
            this.editarCarroToolStripMenuItem});
            this.gerenciarVeiculosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gerenciarVeiculosToolStripMenuItem.Name = "gerenciarVeiculosToolStripMenuItem";
            this.gerenciarVeiculosToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gerenciarVeiculosToolStripMenuItem.Text = "Gerenciar veiculos";
            // 
            // excluirCarroToolStripMenuItem
            // 
            this.excluirCarroToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.excluirCarroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excluirCarroToolStripMenuItem.Name = "excluirCarroToolStripMenuItem";
            this.excluirCarroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirCarroToolStripMenuItem.Text = "Excluir carro";
            this.excluirCarroToolStripMenuItem.Click += new System.EventHandler(this.excluirCarroToolStripMenuItem_Click);
            // 
            // editarCarroToolStripMenuItem
            // 
            this.editarCarroToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.editarCarroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarCarroToolStripMenuItem.Name = "editarCarroToolStripMenuItem";
            this.editarCarroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarCarroToolStripMenuItem.Text = "Editar carro";
            this.editarCarroToolStripMenuItem.Click += new System.EventHandler(this.editarCarroToolStripMenuItem_Click);
            // 
            // Flp_ContainerCarro
            // 
            this.Flp_ContainerCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flp_ContainerCarro.AutoScroll = true;
            this.Flp_ContainerCarro.Controls.Add(this.Lbl_Carros0);
            this.Flp_ContainerCarro.Location = new System.Drawing.Point(12, 37);
            this.Flp_ContainerCarro.Name = "Flp_ContainerCarro";
            this.Flp_ContainerCarro.Size = new System.Drawing.Size(575, 362);
            this.Flp_ContainerCarro.TabIndex = 1;
            // 
            // Lbl_Carros0
            // 
            this.Lbl_Carros0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Carros0.AutoSize = true;
            this.Lbl_Carros0.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Carros0.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_Carros0.Location = new System.Drawing.Point(3, 0);
            this.Lbl_Carros0.Name = "Lbl_Carros0";
            this.Lbl_Carros0.Size = new System.Drawing.Size(556, 55);
            this.Lbl_Carros0.TabIndex = 0;
            this.Lbl_Carros0.Text = "Nenhum carro disponível";
            this.Lbl_Carros0.Visible = false;
            // 
            // Form_CarrosDisponiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.Flp_ContainerCarro);
            this.Controls.Add(this.Ms_ModificaCarros);
            this.MainMenuStrip = this.Ms_ModificaCarros;
            this.Name = "Form_CarrosDisponiveis";
            this.Text = "Form_CarrosDisponiveis";
            this.Load += new System.EventHandler(this.Form_CarrosDisponiveis_Load);
            this.Ms_ModificaCarros.ResumeLayout(false);
            this.Ms_ModificaCarros.PerformLayout();
            this.Flp_ContainerCarro.ResumeLayout(false);
            this.Flp_ContainerCarro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Ms_ModificaCarros;
        private System.Windows.Forms.ToolStripMenuItem gerenciarVeiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCarroToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel Flp_ContainerCarro;
        private System.Windows.Forms.Label Lbl_Carros0;
    }
}