
namespace Lista_de_compras
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
            this.lst_produtos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_compras = new System.Windows.Forms.ListBox();
            this.label_total = new System.Windows.Forms.Label();
            this.cmd_nova_compra = new System.Windows.Forms.Button();
            this.cmd_finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_produtos
            // 
            this.lst_produtos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_produtos.FormattingEnabled = true;
            this.lst_produtos.ItemHeight = 18;
            this.lst_produtos.Location = new System.Drawing.Point(12, 24);
            this.lst_produtos.Name = "lst_produtos";
            this.lst_produtos.Size = new System.Drawing.Size(246, 274);
            this.lst_produtos.TabIndex = 0;
            this.lst_produtos.DoubleClick += new System.EventHandler(this.lst_produtos_DoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COMPRAS";
            // 
            // lst_compras
            // 
            this.lst_compras.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_compras.FormattingEnabled = true;
            this.lst_compras.ItemHeight = 18;
            this.lst_compras.Location = new System.Drawing.Point(264, 24);
            this.lst_compras.Name = "lst_compras";
            this.lst_compras.Size = new System.Drawing.Size(244, 220);
            this.lst_compras.TabIndex = 2;
            // 
            // label_total
            // 
            this.label_total.BackColor = System.Drawing.Color.White;
            this.label_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_total.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(261, 247);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(247, 51);
            this.label_total.TabIndex = 4;
            this.label_total.Text = "COMPRAS";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmd_nova_compra
            // 
            this.cmd_nova_compra.Location = new System.Drawing.Point(12, 304);
            this.cmd_nova_compra.Name = "cmd_nova_compra";
            this.cmd_nova_compra.Size = new System.Drawing.Size(126, 45);
            this.cmd_nova_compra.TabIndex = 5;
            this.cmd_nova_compra.Text = "NOVA COMPRA";
            this.cmd_nova_compra.UseVisualStyleBackColor = true;
            this.cmd_nova_compra.Click += new System.EventHandler(this.cmd_nova_compra_Click_1);
            // 
            // cmd_finalizar
            // 
            this.cmd_finalizar.Location = new System.Drawing.Point(382, 304);
            this.cmd_finalizar.Name = "cmd_finalizar";
            this.cmd_finalizar.Size = new System.Drawing.Size(126, 45);
            this.cmd_finalizar.TabIndex = 6;
            this.cmd_finalizar.Text = "FINALIZAR";
            this.cmd_finalizar.UseVisualStyleBackColor = true;
            this.cmd_finalizar.Click += new System.EventHandler(this.cmd_finalizar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 361);
            this.Controls.Add(this.cmd_finalizar);
            this.Controls.Add(this.cmd_nova_compra);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_compras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_produtos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_compras;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button cmd_nova_compra;
        private System.Windows.Forms.Button cmd_finalizar;
    }
}

