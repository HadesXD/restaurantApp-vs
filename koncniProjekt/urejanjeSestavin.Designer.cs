namespace koncniProjekt
{
    partial class urejanjeSestavin
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
            this.inglabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxEnote = new System.Windows.Forms.ComboBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.comboBoxKategorije = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKategorija = new System.Windows.Forms.Button();
            this.labelKolicinaSestavine = new System.Windows.Forms.Label();
            this.textBoxVnos = new System.Windows.Forms.TextBox();
            this.buttonPristej = new System.Windows.Forms.Button();
            this.buttonEnota = new System.Windows.Forms.Button();
            this.buttonMassInport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxIzbris = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // inglabel
            // 
            this.inglabel.AutoSize = true;
            this.inglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inglabel.Location = new System.Drawing.Point(51, 91);
            this.inglabel.Name = "inglabel";
            this.inglabel.Size = new System.Drawing.Size(99, 25);
            this.inglabel.TabIndex = 0;
            this.inglabel.Text = "Sestavina";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Uredi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(155, 254);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(141, 22);
            this.imeTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(155, 379);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 74);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Dodaj sestavino";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 92);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBox1, "Izberite sestavino s seznama, ali pa vpišite ime.");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            // 
            // comboBoxEnote
            // 
            this.comboBoxEnote.FormattingEnabled = true;
            this.comboBoxEnote.Location = new System.Drawing.Point(155, 311);
            this.comboBoxEnote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEnote.Name = "comboBoxEnote";
            this.comboBoxEnote.Size = new System.Drawing.Size(116, 24);
            this.comboBoxEnote.TabIndex = 7;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(155, 283);
            this.textBoxKolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(140, 22);
            this.textBoxKolicina.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Količina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enota";
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbrisi.Location = new System.Drawing.Point(224, 121);
            this.buttonIzbrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(141, 74);
            this.buttonIzbrisi.TabIndex = 12;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // comboBoxKategorije
            // 
            this.comboBoxKategorije.FormattingEnabled = true;
            this.comboBoxKategorije.Location = new System.Drawing.Point(155, 345);
            this.comboBoxKategorije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKategorije.Name = "comboBoxKategorije";
            this.comboBoxKategorije.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKategorije.TabIndex = 13;
            this.comboBoxKategorije.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxKategorije_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kategorija";
            // 
            // buttonKategorija
            // 
            this.buttonKategorija.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKategorija.Location = new System.Drawing.Point(408, 234);
            this.buttonKategorija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKategorija.Name = "buttonKategorija";
            this.buttonKategorija.Size = new System.Drawing.Size(141, 74);
            this.buttonKategorija.TabIndex = 16;
            this.buttonKategorija.Text = "Dodaj kategorijo";
            this.buttonKategorija.UseVisualStyleBackColor = true;
            this.buttonKategorija.Click += new System.EventHandler(this.buttonKategorija_Click);
            // 
            // labelKolicinaSestavine
            // 
            this.labelKolicinaSestavine.AutoSize = true;
            this.labelKolicinaSestavine.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKolicinaSestavine.Location = new System.Drawing.Point(379, 66);
            this.labelKolicinaSestavine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolicinaSestavine.Name = "labelKolicinaSestavine";
            this.labelKolicinaSestavine.Size = new System.Drawing.Size(148, 23);
            this.labelKolicinaSestavine.TabIndex = 18;
            this.labelKolicinaSestavine.Text = "Izberite sestavino";
            // 
            // textBoxVnos
            // 
            this.textBoxVnos.Enabled = false;
            this.textBoxVnos.Location = new System.Drawing.Point(383, 91);
            this.textBoxVnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVnos.Name = "textBoxVnos";
            this.textBoxVnos.Size = new System.Drawing.Size(141, 22);
            this.textBoxVnos.TabIndex = 19;
            // 
            // buttonPristej
            // 
            this.buttonPristej.Enabled = false;
            this.buttonPristej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPristej.Location = new System.Drawing.Point(383, 121);
            this.buttonPristej.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPristej.Name = "buttonPristej";
            this.buttonPristej.Size = new System.Drawing.Size(141, 74);
            this.buttonPristej.TabIndex = 20;
            this.buttonPristej.Text = "Dodaj kolicino";
            this.buttonPristej.UseVisualStyleBackColor = true;
            this.buttonPristej.Click += new System.EventHandler(this.buttonPristej_Click);
            // 
            // buttonEnota
            // 
            this.buttonEnota.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEnota.Location = new System.Drawing.Point(408, 315);
            this.buttonEnota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnota.Name = "buttonEnota";
            this.buttonEnota.Size = new System.Drawing.Size(141, 74);
            this.buttonEnota.TabIndex = 17;
            this.buttonEnota.Text = "Dodaj enoto";
            this.buttonEnota.UseVisualStyleBackColor = true;
            this.buttonEnota.Click += new System.EventHandler(this.buttonEnota_Click);
            // 
            // buttonMassInport
            // 
            this.buttonMassInport.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMassInport.Location = new System.Drawing.Point(313, 397);
            this.buttonMassInport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMassInport.Name = "buttonMassInport";
            this.buttonMassInport.Size = new System.Drawing.Size(141, 74);
            this.buttonMassInport.TabIndex = 21;
            this.buttonMassInport.Text = "Uvozi sestavine";
            this.buttonMassInport.UseVisualStyleBackColor = true;
            this.buttonMassInport.Click += new System.EventHandler(this.buttonMassInport_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(462, 398);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 48);
            this.button3.TabIndex = 22;
            this.button3.Text = "Vzorec za uvoz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxIzbris
            // 
            this.checkBoxIzbris.AutoSize = true;
            this.checkBoxIzbris.Location = new System.Drawing.Point(461, 450);
            this.checkBoxIzbris.Name = "checkBoxIzbris";
            this.checkBoxIzbris.Size = new System.Drawing.Size(162, 21);
            this.checkBoxIzbris.TabIndex = 23;
            this.checkBoxIzbris.Text = "Izbriši prejšnje vnose";
            this.checkBoxIzbris.UseVisualStyleBackColor = true;
            // 
            // urejanjeSestavin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 518);
            this.Controls.Add(this.checkBoxIzbris);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonMassInport);
            this.Controls.Add(this.buttonPristej);
            this.Controls.Add(this.textBoxVnos);
            this.Controls.Add(this.labelKolicinaSestavine);
            this.Controls.Add(this.buttonEnota);
            this.Controls.Add(this.buttonKategorija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxKategorije);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.comboBoxEnote);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inglabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "urejanjeSestavin";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Urejanje sestavin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.urejanjeSestavin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inglabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxEnote;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.ComboBox comboBoxKategorije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKategorija;
        private System.Windows.Forms.Label labelKolicinaSestavine;
        private System.Windows.Forms.TextBox textBoxVnos;
        private System.Windows.Forms.Button buttonPristej;
        private System.Windows.Forms.Button buttonEnota;
        private System.Windows.Forms.Button buttonMassInport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxIzbris;
    }
}