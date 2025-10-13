namespace ButtonHunter
{
    partial class ButtonHunter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonHunter));
            pushButton = new Button();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pushButton
            // 
            pushButton.BackColor = Color.Coral;
            pushButton.Cursor = Cursors.Cross;
            pushButton.Font = new Font("Shojumaru", 14F, FontStyle.Bold | FontStyle.Italic);
            pushButton.Location = new Point(326, 163);
            pushButton.Name = "pushButton";
            pushButton.Size = new Size(147, 58);
            pushButton.TabIndex = 0;
            pushButton.Text = "gomb";
            pushButton.UseVisualStyleBackColor = false;
            pushButton.Click += btnClick;
            // 
            // statusStrip
            // 
            statusStrip.AccessibleName = "statusStrip";
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 418);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 32);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(298, 25);
            statusLabel.Text = "Nyomd meg a gombot a kezdéshez";
            // 
            // ButtonHunter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(pushButton);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "ButtonHunter";
            Text = "ButtonHunter";
            Load += Form1_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pushButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
    }
}
