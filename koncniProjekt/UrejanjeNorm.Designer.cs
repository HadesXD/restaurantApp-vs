namespace koncniProjekt
{
    partial class UrejanjeNorm
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
            this.components = new System.ComponentModel.Container();
            this.chooseNormlabel = new System.Windows.Forms.Label();
            this.addNormbutton = new System.Windows.Forms.Button();
            this.addFieldbutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonIzbrisiPolje = new System.Windows.Forms.Button();
            this.buttonIzbrisiNormo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMassInport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseNormlabel
            // 
            this.chooseNormlabel.AutoSize = true;
            this.chooseNormlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseNormlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseNormlabel.Location = new System.Drawing.Point(17, 67);
            this.chooseNormlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseNormlabel.Name = "chooseNormlabel";
            this.chooseNormlabel.Size = new System.Drawing.Size(130, 24);
            this.chooseNormlabel.TabIndex = 0;
            this.chooseNormlabel.Text = "Izberite normo";
            // 
            // addNormbutton
            // 
            this.addNormbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNormbutton.Location = new System.Drawing.Point(319, 67);
            this.addNormbutton.Margin = new System.Windows.Forms.Padding(2);
            this.addNormbutton.Name = "addNormbutton";
            this.addNormbutton.Size = new System.Drawing.Size(114, 33);
            this.addNormbutton.TabIndex = 5;
            this.addNormbutton.Text = "Dodaj normo";
            this.addNormbutton.UseVisualStyleBackColor = true;
            this.addNormbutton.Click += new System.EventHandler(this.addNormbutton_Click);
            // 
            // addFieldbutton
            // 
            this.addFieldbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFieldbutton.Location = new System.Drawing.Point(99, 198);
            this.addFieldbutton.Margin = new System.Windows.Forms.Padding(2);
            this.addFieldbutton.Name = "addFieldbutton";
            this.addFieldbutton.Size = new System.Drawing.Size(122, 43);
            this.addFieldbutton.TabIndex = 9;
            this.addFieldbutton.Text = "Dodaj polje";
            this.addFieldbutton.UseVisualStyleBackColor = true;
            this.addFieldbutton.Click += new System.EventHandler(this.addFieldbutton_Click);
            // 
            // changebutton
            // 
            this.changebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changebutton.Location = new System.Drawing.Point(226, 198);
            this.changebutton.Margin = new System.Windows.Forms.Padding(2);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(121, 43);
            this.changebutton.TabIndex = 10;
            this.changebutton.Text = "Potrdi";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(151, 99);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 95);
            this.listBox1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.listBox1, "Za urejanje kliknite dvakrat.");
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 75);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.comboBox1, "Izberite normo.");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            // 
            // buttonIzbrisiPolje
            // 
            this.buttonIzbrisiPolje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbrisiPolje.Location = new System.Drawing.Point(99, 246);
            this.buttonIzbrisiPolje.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzbrisiPolje.Name = "buttonIzbrisiPolje";
            this.buttonIzbrisiPolje.Size = new System.Drawing.Size(122, 43);
            this.buttonIzbrisiPolje.TabIndex = 13;
            this.buttonIzbrisiPolje.Text = "Izbriši polje";
            this.buttonIzbrisiPolje.UseVisualStyleBackColor = true;
            this.buttonIzbrisiPolje.Click += new System.EventHandler(this.buttonIzbrisiPolje_Click);
            // 
            // buttonIzbrisiNormo
            // 
            this.buttonIzbrisiNormo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbrisiNormo.Location = new System.Drawing.Point(226, 246);
            this.buttonIzbrisiNormo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzbrisiNormo.Name = "buttonIzbrisiNormo";
            this.buttonIzbrisiNormo.Size = new System.Drawing.Size(122, 43);
            this.buttonIzbrisiNormo.TabIndex = 14;
            this.buttonIzbrisiNormo.Text = "Izbriši normo";
            this.buttonIzbrisiNormo.UseVisualStyleBackColor = true;
            this.buttonIzbrisiNormo.Click += new System.EventHandler(this.buttonIzbrisiNormo_Click);
            // 
            // buttonMassInport
            // 
            this.buttonMassInport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMassInport.Location = new System.Drawing.Point(112, 293);
            this.buttonMassInport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMassInport.Name = "buttonMassInport";
            this.buttonMassInport.Size = new System.Drawing.Size(122, 43);
            this.buttonMassInport.TabIndex = 15;
            this.buttonMassInport.Text = "Množični vnos";
            this.buttonMassInport.UseVisualStyleBackColor = true;
            this.buttonMassInport.Click += new System.EventHandler(this.buttonMassInport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Vzorec za množični vnos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrejanjeNorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMassInport);
            this.Controls.Add(this.buttonIzbrisiNormo);
            this.Controls.Add(this.buttonIzbrisiPolje);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.addFieldbutton);
            this.Controls.Add(this.addNormbutton);
            this.Controls.Add(this.chooseNormlabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UrejanjeNorm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Urejanje norm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UrejanjeNorm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseNormlabel;
        private System.Windows.Forms.Button addNormbutton;
        private System.Windows.Forms.Button addFieldbutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonIzbrisiPolje;
        private System.Windows.Forms.Button buttonIzbrisiNormo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonMassInport;
        private System.Windows.Forms.Button button1;
    }
}