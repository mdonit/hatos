
namespace VikingLotto0515Szimulacio
{
    partial class LottoTabla
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSorsol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.tarolo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSorsol
            // 
            this.btnSorsol.Location = new System.Drawing.Point(618, 157);
            this.btnSorsol.Name = "btnSorsol";
            this.btnSorsol.Size = new System.Drawing.Size(75, 23);
            this.btnSorsol.TabIndex = 0;
            this.btnSorsol.Text = "Sorsol";
            this.btnSorsol.UseVisualStyleBackColor = true;
            this.btnSorsol.Click += new System.EventHandler(this.btnSorsol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(618, 261);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 1;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // tarolo
            // 
            this.tarolo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tarolo.Location = new System.Drawing.Point(68, 54);
            this.tarolo.Name = "tarolo";
            this.tarolo.Size = new System.Drawing.Size(500, 357);
            this.tarolo.TabIndex = 2;
            // 
            // LottoTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 501);
            this.Controls.Add(this.tarolo);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnSorsol);
            this.Name = "LottoTabla";
            this.Text = "Lottó Tábla";
            this.Load += new System.EventHandler(this.LottoTabla_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSorsol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Panel tarolo;
    }
}

