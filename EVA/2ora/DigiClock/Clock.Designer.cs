namespace DigiClock
{
    partial class Clock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cityLabel = new Label();
            timeLabel = new Label();
            SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.Font = new Font("Consolas", 10F, FontStyle.Bold);
            cityLabel.Location = new Point(0, 22);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(150, 38);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "cityLabel";
            cityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.Fixed3D;
            timeLabel.Font = new Font("Consolas", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(21, 74);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(111, 40);
            timeLabel.TabIndex = 1;
            timeLabel.Text = "00:00";
            timeLabel.Click += label1_Click;
            // 
            // Clock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeLabel);
            Controls.Add(cityLabel);
            Name = "Clock";
            ResumeLayout(false);
        }

        #endregion

        private Label cityLabel;
        private Label timeLabel;
    }
}
