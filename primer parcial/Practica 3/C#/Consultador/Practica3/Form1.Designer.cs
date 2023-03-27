
namespace Practica3
{
    partial class Informacionweb
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text = new System.Windows.Forms.Label();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Text.Location = new System.Drawing.Point(1, 20);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(168, 17);
            this.Text.TabIndex = 0;
            this.Text.Text = "Introduzca direccion web:";
            // 
            // txt_in
            // 
            this.txt_in.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_in.Location = new System.Drawing.Point(175, 19);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(172, 20);
            this.txt_in.TabIndex = 1;
            this.txt_in.Click += new System.EventHandler(this.txt_url_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_aceptar.Location = new System.Drawing.Point(353, 17);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_limpiar.Location = new System.Drawing.Point(4, 240);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(171, 23);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AutoSize = true;
            this.lbl_informacion.Location = new System.Drawing.Point(12, 47);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(0, 13);
            this.lbl_informacion.TabIndex = 4;
            // 
            // txt_out
            // 
            this.txt_out.Location = new System.Drawing.Point(4, 47);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.ReadOnly = true;
            this.txt_out.Size = new System.Drawing.Size(424, 187);
            this.txt_out.TabIndex = 5;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ayuda.Location = new System.Drawing.Point(258, 240);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(170, 23);
            this.btn_ayuda.TabIndex = 6;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // Informacionweb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.lbl_informacion);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.Text);
            this.MaximizeBox = false;
            this.Name = "Informacionweb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Button btn_ayuda;
    }
}

