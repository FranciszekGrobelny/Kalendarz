namespace FranciszekGrobelnyLab3Zad1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewCalendar = new System.Windows.Forms.DataGridView();
            this.textBoxSelectDay = new System.Windows.Forms.TextBox();
            this.textBoxAddEvent = new System.Windows.Forms.TextBox();
            this.buttonSelectDay = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxAddMonth = new System.Windows.Forms.TextBox();
            this.textBoxAddDay = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxStopTime = new System.Windows.Forms.TextBox();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.labelStopTime = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInstruction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCalendar
            // 
            this.dataGridViewCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCalendar.Name = "dataGridViewCalendar";
            this.dataGridViewCalendar.Size = new System.Drawing.Size(414, 254);
            this.dataGridViewCalendar.TabIndex = 0;
            // 
            // textBoxSelectDay
            // 
            this.textBoxSelectDay.Location = new System.Drawing.Point(612, 355);
            this.textBoxSelectDay.Name = "textBoxSelectDay";
            this.textBoxSelectDay.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectDay.TabIndex = 1;
            // 
            // textBoxAddEvent
            // 
            this.textBoxAddEvent.Location = new System.Drawing.Point(225, 356);
            this.textBoxAddEvent.Name = "textBoxAddEvent";
            this.textBoxAddEvent.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddEvent.TabIndex = 2;
            // 
            // buttonSelectDay
            // 
            this.buttonSelectDay.Location = new System.Drawing.Point(612, 381);
            this.buttonSelectDay.Name = "buttonSelectDay";
            this.buttonSelectDay.Size = new System.Drawing.Size(100, 57);
            this.buttonSelectDay.TabIndex = 3;
            this.buttonSelectDay.Text = "Wyszukaj według dnia";
            this.buttonSelectDay.UseVisualStyleBackColor = true;
            this.buttonSelectDay.Click += new System.EventHandler(this.buttonSelectDay_Click);
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(12, 382);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(527, 23);
            this.buttonAddEvent.TabIndex = 4;
            this.buttonAddEvent.Text = "Dodaj wydarzenie";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(569, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(143, 34);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Wczytaj wydarzenia";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxAddMonth
            // 
            this.textBoxAddMonth.Location = new System.Drawing.Point(119, 356);
            this.textBoxAddMonth.Name = "textBoxAddMonth";
            this.textBoxAddMonth.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddMonth.TabIndex = 8;
            // 
            // textBoxAddDay
            // 
            this.textBoxAddDay.Location = new System.Drawing.Point(13, 356);
            this.textBoxAddDay.Name = "textBoxAddDay";
            this.textBoxAddDay.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddDay.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(13, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(526, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Usuń wydarzenie";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(13, 337);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(34, 13);
            this.labelDay.TabIndex = 11;
            this.labelDay.Text = "Dzień";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(119, 336);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(43, 13);
            this.labelMonth.TabIndex = 12;
            this.labelMonth.Text = "Miesiąc";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(225, 335);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Nazwa wydarzenia";
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(332, 356);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartTime.TabIndex = 14;
            // 
            // textBoxStopTime
            // 
            this.textBoxStopTime.Location = new System.Drawing.Point(439, 355);
            this.textBoxStopTime.Name = "textBoxStopTime";
            this.textBoxStopTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopTime.TabIndex = 15;
            // 
            // labelTimeStart
            // 
            this.labelTimeStart.AutoSize = true;
            this.labelTimeStart.Location = new System.Drawing.Point(332, 337);
            this.labelTimeStart.Name = "labelTimeStart";
            this.labelTimeStart.Size = new System.Drawing.Size(106, 13);
            this.labelTimeStart.TabIndex = 16;
            this.labelTimeStart.Text = "Godzina rozpoczęcia";
            // 
            // labelStopTime
            // 
            this.labelStopTime.AutoSize = true;
            this.labelStopTime.Location = new System.Drawing.Point(439, 336);
            this.labelStopTime.Name = "labelStopTime";
            this.labelStopTime.Size = new System.Drawing.Size(109, 13);
            this.labelStopTime.TabIndex = 17;
            this.labelStopTime.Text = "Godzina zakończenia";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(13, 444);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(526, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Dodaj godziny do wydarzenia";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.Location = new System.Drawing.Point(569, 72);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(143, 79);
            this.buttonInstruction.TabIndex = 19;
            this.buttonInstruction.Text = "Instrukcja obsługi";
            this.buttonInstruction.UseVisualStyleBackColor = true;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 480);
            this.Controls.Add(this.buttonInstruction);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelStopTime);
            this.Controls.Add(this.labelTimeStart);
            this.Controls.Add(this.textBoxStopTime);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxAddDay);
            this.Controls.Add(this.textBoxAddMonth);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.buttonSelectDay);
            this.Controls.Add(this.textBoxAddEvent);
            this.Controls.Add(this.textBoxSelectDay);
            this.Controls.Add(this.dataGridViewCalendar);
            this.Name = "FormMain";
            this.Text = "Terminarz";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCalendar;
        private System.Windows.Forms.TextBox textBoxSelectDay;
        private System.Windows.Forms.TextBox textBoxAddEvent;
        private System.Windows.Forms.Button buttonSelectDay;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxAddMonth;
        private System.Windows.Forms.TextBox textBoxAddDay;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxStopTime;
        private System.Windows.Forms.Label labelTimeStart;
        private System.Windows.Forms.Label labelStopTime;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInstruction;
    }
}

