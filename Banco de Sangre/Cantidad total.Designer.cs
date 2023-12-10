
namespace Banco_de_Sangre
{
    partial class Cantidad_total
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
            this.btnRegresoMenu = new System.Windows.Forms.Button();
            this.btnBuscarGpo = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresoMenu
            // 
            this.btnRegresoMenu.Location = new System.Drawing.Point(48, 344);
            this.btnRegresoMenu.Name = "btnRegresoMenu";
            this.btnRegresoMenu.Size = new System.Drawing.Size(151, 65);
            this.btnRegresoMenu.TabIndex = 11;
            this.btnRegresoMenu.Text = "Regresar al menú";
            this.btnRegresoMenu.UseVisualStyleBackColor = true;
            this.btnRegresoMenu.Click += new System.EventHandler(this.btnRegresoMenu_Click);
            // 
            // btnBuscarGpo
            // 
            this.btnBuscarGpo.Location = new System.Drawing.Point(589, 344);
            this.btnBuscarGpo.Name = "btnBuscarGpo";
            this.btnBuscarGpo.Size = new System.Drawing.Size(162, 65);
            this.btnBuscarGpo.TabIndex = 10;
            this.btnBuscarGpo.Text = "Buscar datos";
            this.btnBuscarGpo.UseVisualStyleBackColor = true;
            this.btnBuscarGpo.Click += new System.EventHandler(this.btnBuscarGpo_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(293, 164);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(324, 26);
            this.txtBusqueda.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(97, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrese Grupo \r\nsanguíneo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 92);
            this.label1.TabIndex = 7;
            this.label1.Text = "Centro Estatal de la \r\nTransfusión Sanguínea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "x";
            // 
            // Cantidad_total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(798, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresoMenu);
            this.Controls.Add(this.btnBuscarGpo);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cantidad_total";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad_total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresoMenu;
        private System.Windows.Forms.Button btnBuscarGpo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}