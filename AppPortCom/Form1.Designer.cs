namespace AppPortCom
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbNomPort = new System.Windows.Forms.ComboBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnEnvoiData = new System.Windows.Forms.Button();
            this.lblConfigPort = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbBaudPort = new System.Windows.Forms.ComboBox();
            this.cbNbrBit = new System.Windows.Forms.ComboBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbPariteBit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDataIn = new System.Windows.Forms.TextBox();
            this.btnRecevoir = new System.Windows.Forms.Button();
            this.lblRecDatas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNomPort
            // 
            this.cbNomPort.FormattingEnabled = true;
            this.cbNomPort.Location = new System.Drawing.Point(175, 71);
            this.cbNomPort.Name = "cbNomPort";
            this.cbNomPort.Size = new System.Drawing.Size(121, 21);
            this.cbNomPort.TabIndex = 0;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(175, 221);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(121, 23);
            this.btnOuvrir.TabIndex = 5;
            this.btnOuvrir.Text = "O U V R I R";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(175, 260);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(121, 23);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "F E R M E R";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(342, 71);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(121, 125);
            this.tbData.TabIndex = 7;
            // 
            // btnEnvoiData
            // 
            this.btnEnvoiData.Location = new System.Drawing.Point(342, 221);
            this.btnEnvoiData.Name = "btnEnvoiData";
            this.btnEnvoiData.Size = new System.Drawing.Size(121, 23);
            this.btnEnvoiData.TabIndex = 8;
            this.btnEnvoiData.Text = "E N V O Y E R";
            this.btnEnvoiData.UseVisualStyleBackColor = true;
            this.btnEnvoiData.Click += new System.EventHandler(this.btnEnvoiData_Click);
            // 
            // lblConfigPort
            // 
            this.lblConfigPort.AutoSize = true;
            this.lblConfigPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigPort.Location = new System.Drawing.Point(90, 39);
            this.lblConfigPort.Name = "lblConfigPort";
            this.lblConfigPort.Size = new System.Drawing.Size(142, 18);
            this.lblConfigPort.TabIndex = 9;
            this.lblConfigPort.Text = "Configuration PORT";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(339, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(136, 18);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Données à envoyer";
            // 
            // cbBaudPort
            // 
            this.cbBaudPort.FormattingEnabled = true;
            this.cbBaudPort.Items.AddRange(new object[] {
            "50",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudPort.Location = new System.Drawing.Point(175, 98);
            this.cbBaudPort.Name = "cbBaudPort";
            this.cbBaudPort.Size = new System.Drawing.Size(121, 21);
            this.cbBaudPort.TabIndex = 11;
            // 
            // cbNbrBit
            // 
            this.cbNbrBit.FormattingEnabled = true;
            this.cbNbrBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbNbrBit.Location = new System.Drawing.Point(175, 125);
            this.cbNbrBit.Name = "cbNbrBit";
            this.cbNbrBit.Size = new System.Drawing.Size(121, 21);
            this.cbNbrBit.TabIndex = 12;
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopBit.Location = new System.Drawing.Point(175, 152);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(121, 21);
            this.cbStopBit.TabIndex = 13;
            // 
            // cbPariteBit
            // 
            this.cbPariteBit.FormattingEnabled = true;
            this.cbPariteBit.Items.AddRange(new object[] {
            "None",
            "odd",
            "even",
            "high",
            "low"});
            this.cbPariteBit.Location = new System.Drawing.Point(175, 179);
            this.cbPariteBit.Name = "cbPariteBit";
            this.cbPariteBit.Size = new System.Drawing.Size(121, 21);
            this.cbPariteBit.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "BAUDS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nbr bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "STOP Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Parité Bit";
            // 
            // tbDataIn
            // 
            this.tbDataIn.Location = new System.Drawing.Point(572, 71);
            this.tbDataIn.Multiline = true;
            this.tbDataIn.Name = "tbDataIn";
            this.tbDataIn.Size = new System.Drawing.Size(121, 125);
            this.tbDataIn.TabIndex = 20;
            // 
            // btnRecevoir
            // 
            this.btnRecevoir.Location = new System.Drawing.Point(572, 221);
            this.btnRecevoir.Name = "btnRecevoir";
            this.btnRecevoir.Size = new System.Drawing.Size(121, 23);
            this.btnRecevoir.TabIndex = 21;
            this.btnRecevoir.Text = "R E C E V O I R";
            this.btnRecevoir.UseVisualStyleBackColor = true;
            this.btnRecevoir.Click += new System.EventHandler(this.btnRecevoir_Click);
            // 
            // lblRecDatas
            // 
            this.lblRecDatas.AutoSize = true;
            this.lblRecDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecDatas.Location = new System.Drawing.Point(569, 39);
            this.lblRecDatas.Name = "lblRecDatas";
            this.lblRecDatas.Size = new System.Drawing.Size(164, 18);
            this.lblRecDatas.TabIndex = 22;
            this.lblRecDatas.Text = "Réception des données";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecDatas);
            this.Controls.Add(this.btnRecevoir);
            this.Controls.Add(this.tbDataIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPariteBit);
            this.Controls.Add(this.cbStopBit);
            this.Controls.Add(this.cbNbrBit);
            this.Controls.Add(this.cbBaudPort);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblConfigPort);
            this.Controls.Add(this.btnEnvoiData);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.cbNomPort);
            this.Name = "Form1";
            this.Text = "PORT COM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomPort;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnEnvoiData;
        private System.Windows.Forms.Label lblConfigPort;
        private System.Windows.Forms.Label lblData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbBaudPort;
        private System.Windows.Forms.ComboBox cbNbrBit;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbPariteBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDataIn;
        private System.Windows.Forms.Button btnRecevoir;
        private System.Windows.Forms.Label lblRecDatas;
    }
}

