
namespace ChristinaProject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAlleBesucherAustragen = new System.Windows.Forms.Button();
            this.btnAusgewählteBesucherAustragen = new System.Windows.Forms.Button();
            this.listBesucher = new System.Windows.Forms.ListView();
            this.clmVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFortbewegungsmittel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmKennzeichen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFehlermeldung = new System.Windows.Forms.Label();
            this.txtKennzeichen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBesucherEintragen = new System.Windows.Forms.Button();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.listFortbewegungsmittel = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 326);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.btnAlleBesucherAustragen);
            this.panel3.Controls.Add(this.btnAusgewählteBesucherAustragen);
            this.panel3.Controls.Add(this.listBesucher);
            this.panel3.Location = new System.Drawing.Point(526, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 320);
            this.panel3.TabIndex = 1;
            // 
            // btnAlleBesucherAustragen
            // 
            this.btnAlleBesucherAustragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlleBesucherAustragen.Location = new System.Drawing.Point(18, 263);
            this.btnAlleBesucherAustragen.Name = "btnAlleBesucherAustragen";
            this.btnAlleBesucherAustragen.Size = new System.Drawing.Size(454, 44);
            this.btnAlleBesucherAustragen.TabIndex = 2;
            this.btnAlleBesucherAustragen.Text = "Alle Besucher austragen";
            this.btnAlleBesucherAustragen.UseVisualStyleBackColor = true;
            this.btnAlleBesucherAustragen.Click += new System.EventHandler(this.btnAlleBesucherAustragen_Click);
            // 
            // btnAusgewählteBesucherAustragen
            // 
            this.btnAusgewählteBesucherAustragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAusgewählteBesucherAustragen.Location = new System.Drawing.Point(18, 211);
            this.btnAusgewählteBesucherAustragen.Name = "btnAusgewählteBesucherAustragen";
            this.btnAusgewählteBesucherAustragen.Size = new System.Drawing.Size(454, 46);
            this.btnAusgewählteBesucherAustragen.TabIndex = 1;
            this.btnAusgewählteBesucherAustragen.Text = "Ausgewählte Besucher austragen";
            this.btnAusgewählteBesucherAustragen.UseVisualStyleBackColor = true;
            this.btnAusgewählteBesucherAustragen.Click += new System.EventHandler(this.btnAusgewählteBesucherAustragen_Click);
            // 
            // listBesucher
            // 
            this.listBesucher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmVorname,
            this.clmNachname,
            this.clmFortbewegungsmittel,
            this.clmKennzeichen});
            this.listBesucher.HideSelection = false;
            this.listBesucher.Location = new System.Drawing.Point(18, 18);
            this.listBesucher.Name = "listBesucher";
            this.listBesucher.Size = new System.Drawing.Size(454, 178);
            this.listBesucher.TabIndex = 0;
            this.listBesucher.UseCompatibleStateImageBehavior = false;
            this.listBesucher.View = System.Windows.Forms.View.Details;
            // 
            // clmVorname
            // 
            this.clmVorname.Text = "Vorname";
            // 
            // clmNachname
            // 
            this.clmNachname.Text = "Nachname";
            // 
            // clmFortbewegungsmittel
            // 
            this.clmFortbewegungsmittel.Text = "Fortbewegungsmittel";
            // 
            // clmKennzeichen
            // 
            this.clmKennzeichen.Text = "Kennzeichen";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lblFehlermeldung);
            this.panel2.Controls.Add(this.txtKennzeichen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnBesucherEintragen);
            this.panel2.Controls.Add(this.txtNachname);
            this.panel2.Controls.Add(this.txtVorname);
            this.panel2.Controls.Add(this.listFortbewegungsmittel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 320);
            this.panel2.TabIndex = 0;
            // 
            // lblFehlermeldung
            // 
            this.lblFehlermeldung.AutoSize = true;
            this.lblFehlermeldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFehlermeldung.Location = new System.Drawing.Point(15, 211);
            this.lblFehlermeldung.Name = "lblFehlermeldung";
            this.lblFehlermeldung.Size = new System.Drawing.Size(0, 29);
            this.lblFehlermeldung.TabIndex = 9;
            // 
            // txtKennzeichen
            // 
            this.txtKennzeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKennzeichen.Location = new System.Drawing.Point(176, 98);
            this.txtKennzeichen.Name = "txtKennzeichen";
            this.txtKennzeichen.Size = new System.Drawing.Size(196, 35);
            this.txtKennzeichen.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kennzeichen";
            // 
            // btnBesucherEintragen
            // 
            this.btnBesucherEintragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBesucherEintragen.Location = new System.Drawing.Point(176, 156);
            this.btnBesucherEintragen.Name = "btnBesucherEintragen";
            this.btnBesucherEintragen.Size = new System.Drawing.Size(311, 40);
            this.btnBesucherEintragen.TabIndex = 6;
            this.btnBesucherEintragen.Text = "Besucher eintragen\r\n";
            this.btnBesucherEintragen.UseVisualStyleBackColor = true;
            this.btnBesucherEintragen.Click += new System.EventHandler(this.btnBesucherEintragen_Click);
            // 
            // txtNachname
            // 
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachname.Location = new System.Drawing.Point(176, 57);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(196, 35);
            this.txtNachname.TabIndex = 5;
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(176, 18);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(196, 35);
            this.txtVorname.TabIndex = 4;
            // 
            // listFortbewegungsmittel
            // 
            this.listFortbewegungsmittel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFortbewegungsmittel.FormattingEnabled = true;
            this.listFortbewegungsmittel.ItemHeight = 29;
            this.listFortbewegungsmittel.Items.AddRange(new object[] {
            "Zu Fuß",
            "Fahrrad",
            "PKW",
            "LKW"});
            this.listFortbewegungsmittel.Location = new System.Drawing.Point(378, 18);
            this.listFortbewegungsmittel.Name = "listFortbewegungsmittel";
            this.listFortbewegungsmittel.Size = new System.Drawing.Size(120, 120);
            this.listFortbewegungsmittel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 350);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Besucher anmelden";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBesucherEintragen;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.ListBox listFortbewegungsmittel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlleBesucherAustragen;
        private System.Windows.Forms.Button btnAusgewählteBesucherAustragen;
        private System.Windows.Forms.ListView listBesucher;
        private System.Windows.Forms.ColumnHeader clmVorname;
        private System.Windows.Forms.ColumnHeader clmNachname;
        private System.Windows.Forms.ColumnHeader clmFortbewegungsmittel;
        private System.Windows.Forms.ColumnHeader clmKennzeichen;
        private System.Windows.Forms.Label lblFehlermeldung;
        private System.Windows.Forms.TextBox txtKennzeichen;
        private System.Windows.Forms.Label label3;
    }
}

