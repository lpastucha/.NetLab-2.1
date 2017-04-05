namespace DateDiffer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.timeFromLbl = new System.Windows.Forms.Label();
            this.timeToLbl = new System.Windows.Forms.Label();
            this.calculateDiffBtn = new System.Windows.Forms.Button();
            this.daysLbl = new System.Windows.Forms.Label();
            this.daysL = new System.Windows.Forms.Label();
            this.hoursL = new System.Windows.Forms.Label();
            this.hoursLbl = new System.Windows.Forms.Label();
            this.minutesL = new System.Windows.Forms.Label();
            this.minutesLbl = new System.Windows.Forms.Label();
            this.SecondL = new System.Windows.Forms.Label();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "yyyy:MM:dd hh:mm:ss";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(47, 31);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // timeFromLbl
            // 
            this.timeFromLbl.AutoSize = true;
            this.timeFromLbl.Location = new System.Drawing.Point(44, 15);
            this.timeFromLbl.Name = "timeFromLbl";
            this.timeFromLbl.Size = new System.Drawing.Size(48, 13);
            this.timeFromLbl.TabIndex = 2;
            this.timeFromLbl.Text = "Czas od:";
            // 
            // timeToLbl
            // 
            this.timeToLbl.AutoSize = true;
            this.timeToLbl.Location = new System.Drawing.Point(44, 71);
            this.timeToLbl.Name = "timeToLbl";
            this.timeToLbl.Size = new System.Drawing.Size(48, 13);
            this.timeToLbl.TabIndex = 3;
            this.timeToLbl.Text = "Czas do:";
            // 
            // calculateDiffBtn
            // 
            this.calculateDiffBtn.Location = new System.Drawing.Point(91, 113);
            this.calculateDiffBtn.Name = "calculateDiffBtn";
            this.calculateDiffBtn.Size = new System.Drawing.Size(156, 23);
            this.calculateDiffBtn.TabIndex = 4;
            this.calculateDiffBtn.Text = "Podaj róznicę czasu";
            this.calculateDiffBtn.UseVisualStyleBackColor = true;
            this.calculateDiffBtn.Click += new System.EventHandler(this.calculateDiffBtn_Click);
            // 
            // daysLbl
            // 
            this.daysLbl.AutoSize = true;
            this.daysLbl.Location = new System.Drawing.Point(12, 164);
            this.daysLbl.Name = "daysLbl";
            this.daysLbl.Size = new System.Drawing.Size(29, 13);
            this.daysLbl.TabIndex = 5;
            this.daysLbl.Text = "Dni: ";
            // 
            // daysL
            // 
            this.daysL.AutoSize = true;
            this.daysL.Location = new System.Drawing.Point(57, 164);
            this.daysL.Name = "daysL";
            this.daysL.Size = new System.Drawing.Size(10, 13);
            this.daysL.TabIndex = 6;
            this.daysL.Text = " ";
            // 
            // hoursL
            // 
            this.hoursL.AutoSize = true;
            this.hoursL.Location = new System.Drawing.Point(57, 187);
            this.hoursL.Name = "hoursL";
            this.hoursL.Size = new System.Drawing.Size(10, 13);
            this.hoursL.TabIndex = 8;
            this.hoursL.Text = " ";
            // 
            // hoursLbl
            // 
            this.hoursLbl.AutoSize = true;
            this.hoursLbl.Location = new System.Drawing.Point(12, 187);
            this.hoursLbl.Name = "hoursLbl";
            this.hoursLbl.Size = new System.Drawing.Size(46, 13);
            this.hoursLbl.TabIndex = 7;
            this.hoursLbl.Text = "Godzin: ";
            // 
            // minutesL
            // 
            this.minutesL.AutoSize = true;
            this.minutesL.Location = new System.Drawing.Point(57, 213);
            this.minutesL.Name = "minutesL";
            this.minutesL.Size = new System.Drawing.Size(10, 13);
            this.minutesL.TabIndex = 10;
            this.minutesL.Text = " ";
            // 
            // minutesLbl
            // 
            this.minutesLbl.AutoSize = true;
            this.minutesLbl.Location = new System.Drawing.Point(12, 213);
            this.minutesLbl.Name = "minutesLbl";
            this.minutesLbl.Size = new System.Drawing.Size(39, 13);
            this.minutesLbl.TabIndex = 9;
            this.minutesLbl.Text = "Minut: ";
            // 
            // SecondL
            // 
            this.SecondL.AutoSize = true;
            this.SecondL.Location = new System.Drawing.Point(57, 239);
            this.SecondL.Name = "SecondL";
            this.SecondL.Size = new System.Drawing.Size(10, 13);
            this.SecondL.TabIndex = 12;
            this.SecondL.Text = " ";
            // 
            // secondsLbl
            // 
            this.secondsLbl.AutoSize = true;
            this.secondsLbl.Location = new System.Drawing.Point(12, 239);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(50, 13);
            this.secondsLbl.TabIndex = 11;
            this.secondsLbl.Text = "Sekund: ";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "yyyy:MM:dd hh:mm:ss";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(47, 87);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.SecondL);
            this.Controls.Add(this.secondsLbl);
            this.Controls.Add(this.minutesL);
            this.Controls.Add(this.minutesLbl);
            this.Controls.Add(this.hoursL);
            this.Controls.Add(this.hoursLbl);
            this.Controls.Add(this.daysL);
            this.Controls.Add(this.daysLbl);
            this.Controls.Add(this.calculateDiffBtn);
            this.Controls.Add(this.timeToLbl);
            this.Controls.Add(this.timeFromLbl);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label timeFromLbl;
        private System.Windows.Forms.Label timeToLbl;
        private System.Windows.Forms.Button calculateDiffBtn;
        private System.Windows.Forms.Label daysLbl;
        private System.Windows.Forms.Label daysL;
        private System.Windows.Forms.Label hoursL;
        private System.Windows.Forms.Label hoursLbl;
        private System.Windows.Forms.Label minutesL;
        private System.Windows.Forms.Label minutesLbl;
        private System.Windows.Forms.Label SecondL;
        private System.Windows.Forms.Label secondsLbl;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}

