
using System.Windows.Forms;

namespace LaBomba
{
    partial class frmBomba
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
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCenter
            // 
            this.btnCenter.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnCenter.Location = new System.Drawing.Point(180, 147);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 0;
            this.btnCenter.Text = "Bomba";
            this.btnCenter.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnLeft.Location = new System.Drawing.Point(58, 147);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Bom";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnRight.Location = new System.Drawing.Point(300, 147);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "ba";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnCenter);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 329);
            this.panel1.TabIndex = 3;
            // 
            // frmBomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(422, 337);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 364);
            this.MinimumSize = new System.Drawing.Size(430, 364);
            this.Name = "frmBomba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private Panel panel1;

        public System.Windows.Forms.Button BtnCenter{
            get { return this.btnCenter; } 
        }

        public System.Windows.Forms.Button BtnRight{
            get { return this.btnRight; }
        }

        public System.Windows.Forms.Button BtnLeft{
            get { return this.btnLeft; }
        }

    }
}

