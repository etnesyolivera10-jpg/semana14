namespace ejercicio6
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
            this.lblTituloRanking = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRestablecerRanking = new System.Windows.Forms.Button();
            this.lstRanking = new System.Windows.Forms.ListBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloRanking
            // 
            this.lblTituloRanking.AutoSize = true;
            this.lblTituloRanking.Location = new System.Drawing.Point(305, 53);
            this.lblTituloRanking.Name = "lblTituloRanking";
            this.lblTituloRanking.Size = new System.Drawing.Size(161, 13);
            this.lblTituloRanking.TabIndex = 0;
            this.lblTituloRanking.Text = "Ranking de estudiantes por nota";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.AccessibleName = "btnOrdenar";
            this.btnOrdenar.Location = new System.Drawing.Point(243, 97);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(114, 36);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar ranking";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnRestablecerRanking
            // 
            this.btnRestablecerRanking.AccessibleName = "btnRestablecerRanking";
            this.btnRestablecerRanking.Location = new System.Drawing.Point(404, 97);
            this.btnRestablecerRanking.Name = "btnRestablecerRanking";
            this.btnRestablecerRanking.Size = new System.Drawing.Size(114, 36);
            this.btnRestablecerRanking.TabIndex = 2;
            this.btnRestablecerRanking.Text = "Restablecer";
            this.btnRestablecerRanking.UseVisualStyleBackColor = true;
            this.btnRestablecerRanking.Click += new System.EventHandler(this.btnRestablecerRanking_Click);
            // 
            // lstRanking
            // 
            this.lstRanking.AccessibleName = "lstRanking";
            this.lstRanking.FormattingEnabled = true;
            this.lstRanking.Location = new System.Drawing.Point(79, 178);
            this.lstRanking.Name = "lstRanking";
            this.lstRanking.Size = new System.Drawing.Size(599, 160);
            this.lstRanking.TabIndex = 3;
            // 
            // lblMayor
            // 
            this.lblMayor.AccessibleName = "lblMayor";
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(76, 356);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(80, 13);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Primer puesto: -";
            // 
            // Form1
            // 
            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lstRanking);
            this.Controls.Add(this.btnRestablecerRanking);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.lblTituloRanking);
            this.Name = "Form1";
            this.Text = "|";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRanking;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnRestablecerRanking;
        private System.Windows.Forms.ListBox lstRanking;
        private System.Windows.Forms.Label lblMayor;
    }
}