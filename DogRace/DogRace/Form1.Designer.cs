namespace DogRace
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
            this.components = new System.ComponentModel.Container();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.rdJoe = new System.Windows.Forms.RadioButton();
            this.rdBob = new System.Windows.Forms.RadioButton();
            this.rdAl = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.bettingAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.btnRace = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblJoeBet = new System.Windows.Forms.Label();
            this.lblBobBet = new System.Windows.Forms.Label();
            this.lblAlBet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.ImageLocation = "C:\\Users\\wbein\\Downloads\\lab1\\racetrack.png";
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(634, 210);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.ImageLocation = "C:\\Users\\wbein\\Downloads\\lab1\\dog.png";
            this.dog1.Location = new System.Drawing.Point(12, 24);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(90, 21);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.ImageLocation = "C:\\Users\\wbein\\Downloads\\lab1\\dog.png";
            this.dog2.Location = new System.Drawing.Point(12, 71);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(90, 25);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.ImageLocation = "C:\\Users\\wbein\\Downloads\\lab1\\dog.png";
            this.dog3.Location = new System.Drawing.Point(12, 125);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(90, 23);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.ImageLocation = "C:\\Users\\wbein\\Downloads\\lab1\\dog.png";
            this.dog4.Location = new System.Drawing.Point(12, 182);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(90, 23);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Betting Parlor";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(15, 271);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(107, 12);
            this.lblMinimum.TabIndex = 6;
            this.lblMinimum.Text = "minimumBetLabel";
            // 
            // rdJoe
            // 
            this.rdJoe.AutoSize = true;
            this.rdJoe.Location = new System.Drawing.Point(15, 299);
            this.rdJoe.Name = "rdJoe";
            this.rdJoe.Size = new System.Drawing.Size(92, 16);
            this.rdJoe.TabIndex = 7;
            this.rdJoe.TabStop = true;
            this.rdJoe.Text = "radioButton1";
            this.rdJoe.UseVisualStyleBackColor = true;
            // 
            // rdBob
            // 
            this.rdBob.AutoSize = true;
            this.rdBob.Location = new System.Drawing.Point(15, 322);
            this.rdBob.Name = "rdBob";
            this.rdBob.Size = new System.Drawing.Size(92, 16);
            this.rdBob.TabIndex = 8;
            this.rdBob.TabStop = true;
            this.rdBob.Text = "radioButton2";
            this.rdBob.UseVisualStyleBackColor = true;
            // 
            // rdAl
            // 
            this.rdAl.AutoSize = true;
            this.rdAl.Location = new System.Drawing.Point(15, 345);
            this.rdAl.Name = "rdAl";
            this.rdAl.Size = new System.Drawing.Size(92, 16);
            this.rdAl.TabIndex = 9;
            this.rdAl.TabStop = true;
            this.rdAl.Text = "radioButton3";
            this.rdAl.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 391);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 12);
            this.lblName.TabIndex = 10;
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBet.Location = new System.Drawing.Point(74, 386);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 11;
            this.btnBet.Text = "Bets";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // bettingAmount
            // 
            this.bettingAmount.Location = new System.Drawing.Point(167, 388);
            this.bettingAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.bettingAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bettingAmount.Name = "bettingAmount";
            this.bettingAmount.Size = new System.Drawing.Size(59, 21);
            this.bettingAmount.TabIndex = 12;
            this.bettingAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "bucks on dog number";
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(367, 389);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(56, 21);
            this.dogNumber.TabIndex = 14;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.ValueChanged += new System.EventHandler(this.dogNumber_ValueChanged);
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRace.Location = new System.Drawing.Point(439, 299);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(159, 62);
            this.btnRace.TabIndex = 15;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(169, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bets";
            // 
            // lblJoeBet
            // 
            this.lblJoeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoeBet.Location = new System.Drawing.Point(169, 299);
            this.lblJoeBet.Name = "lblJoeBet";
            this.lblJoeBet.Size = new System.Drawing.Size(232, 23);
            this.lblJoeBet.TabIndex = 17;
            // 
            // lblBobBet
            // 
            this.lblBobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBobBet.Location = new System.Drawing.Point(169, 324);
            this.lblBobBet.Name = "lblBobBet";
            this.lblBobBet.Size = new System.Drawing.Size(232, 23);
            this.lblBobBet.TabIndex = 18;
            // 
            // lblAlBet
            // 
            this.lblAlBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlBet.Location = new System.Drawing.Point(169, 347);
            this.lblAlBet.Name = "lblAlBet";
            this.lblAlBet.Size = new System.Drawing.Size(232, 23);
            this.lblAlBet.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(439, 244);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(159, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Again!";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 426);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAlBet);
            this.Controls.Add(this.lblBobBet);
            this.Controls.Add(this.lblJoeBet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.dogNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bettingAmount);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rdAl);
            this.Controls.Add(this.rdBob);
            this.Controls.Add(this.rdJoe);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.RadioButton rdJoe;
        private System.Windows.Forms.RadioButton rdBob;
        private System.Windows.Forms.RadioButton rdAl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown bettingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblJoeBet;
        private System.Windows.Forms.Label lblBobBet;
        private System.Windows.Forms.Label lblAlBet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReset;
        //        private System.Windows.Forms.Timer timer1;
    }
}

