namespace pryTeatro
{
    partial class frmPrincipal
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
            this.btnQuenaken = new System.Windows.Forms.Button();
            this.btnOnas = new System.Windows.Forms.Button();
            this.btnTobas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuenaken
            // 
            this.btnQuenaken.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenaken.Location = new System.Drawing.Point(22, 26);
            this.btnQuenaken.Name = "btnQuenaken";
            this.btnQuenaken.Size = new System.Drawing.Size(240, 196);
            this.btnQuenaken.TabIndex = 0;
            this.btnQuenaken.Text = "QUENAKEN";
            this.btnQuenaken.UseVisualStyleBackColor = true;
            this.btnQuenaken.Click += new System.EventHandler(this.btnQuenaken_Click);
            // 
            // btnOnas
            // 
            this.btnOnas.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnas.Location = new System.Drawing.Point(282, 26);
            this.btnOnas.Name = "btnOnas";
            this.btnOnas.Size = new System.Drawing.Size(240, 196);
            this.btnOnas.TabIndex = 1;
            this.btnOnas.Text = "ONAS";
            this.btnOnas.UseVisualStyleBackColor = true;
            this.btnOnas.Click += new System.EventHandler(this.btnOnas_Click);
            // 
            // btnTobas
            // 
            this.btnTobas.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTobas.Location = new System.Drawing.Point(548, 26);
            this.btnTobas.Name = "btnTobas";
            this.btnTobas.Size = new System.Drawing.Size(240, 196);
            this.btnTobas.TabIndex = 2;
            this.btnTobas.Text = "TOBAS";
            this.btnTobas.UseVisualStyleBackColor = true;
            this.btnTobas.Click += new System.EventHandler(this.btnTobas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 242);
            this.Controls.Add(this.btnTobas);
            this.Controls.Add(this.btnOnas);
            this.Controls.Add(this.btnQuenaken);
            this.Name = "frmPrincipal";
            this.Text = "Seleccionar un teatro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuenaken;
        private System.Windows.Forms.Button btnOnas;
        private System.Windows.Forms.Button btnTobas;
    }
}