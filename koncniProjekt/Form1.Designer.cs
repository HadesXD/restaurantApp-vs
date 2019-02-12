namespace koncniProjekt
{
    partial class menuForm
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
            this.outputbutton = new System.Windows.Forms.Button();
            this.checkbutton = new System.Windows.Forms.Button();
            this.addEditNormsbutton = new System.Windows.Forms.Button();
            this.addEditIngbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputbutton
            // 
            this.outputbutton.Font = new System.Drawing.Font("Open Sans Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputbutton.Location = new System.Drawing.Point(23, 74);
            this.outputbutton.Name = "outputbutton";
            this.outputbutton.Size = new System.Drawing.Size(169, 90);
            this.outputbutton.TabIndex = 4;
            this.outputbutton.Text = "Izpis";
            this.outputbutton.UseVisualStyleBackColor = true;
            this.outputbutton.Click += new System.EventHandler(this.outputbutton_Click);
            // 
            // checkbutton
            // 
            this.checkbutton.Font = new System.Drawing.Font("Open Sans Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbutton.Location = new System.Drawing.Point(249, 74);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(169, 90);
            this.checkbutton.TabIndex = 5;
            this.checkbutton.Text = "Račun";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // addEditNormsbutton
            // 
            this.addEditNormsbutton.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditNormsbutton.Location = new System.Drawing.Point(23, 216);
            this.addEditNormsbutton.Name = "addEditNormsbutton";
            this.addEditNormsbutton.Size = new System.Drawing.Size(169, 90);
            this.addEditNormsbutton.TabIndex = 6;
            this.addEditNormsbutton.Text = "Dodaj/Uredi norme";
            this.addEditNormsbutton.UseVisualStyleBackColor = true;
            this.addEditNormsbutton.Click += new System.EventHandler(this.addEditNormsbutton_Click);
            // 
            // addEditIngbutton
            // 
            this.addEditIngbutton.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditIngbutton.Location = new System.Drawing.Point(249, 216);
            this.addEditIngbutton.Name = "addEditIngbutton";
            this.addEditIngbutton.Size = new System.Drawing.Size(169, 90);
            this.addEditIngbutton.TabIndex = 7;
            this.addEditIngbutton.Text = "Dodaj/Uredi sestavine";
            this.addEditIngbutton.UseVisualStyleBackColor = true;
            this.addEditIngbutton.Click += new System.EventHandler(this.addEditIngbutton_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 329);
            this.Controls.Add(this.addEditIngbutton);
            this.Controls.Add(this.addEditNormsbutton);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.outputbutton);
            this.Name = "menuForm";
            this.Text = "Meni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button outputbutton;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Button addEditNormsbutton;
        private System.Windows.Forms.Button addEditIngbutton;
    }
}

