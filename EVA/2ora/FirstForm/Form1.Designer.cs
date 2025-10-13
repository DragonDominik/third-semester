namespace FirstForm
{
    partial class Form1
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
            quitButton = new Button();
            SuspendLayout();
            // 
            // quitButton
            // 
            quitButton.BackColor = SystemColors.Info;
            quitButton.Cursor = Cursors.Hand;
            quitButton.Font = new Font("Shojumaru", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            quitButton.Location = new Point(297, 156);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(234, 100);
            quitButton.TabIndex = 0;
            quitButton.Text = "Gomb";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quitButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button quitButton;
    }
}
