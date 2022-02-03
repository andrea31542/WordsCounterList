
namespace WordsCounterList
{
    partial class LoadingWindow
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
            this.processing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processing
            // 
            this.processing.AccessibleName = "";
            this.processing.AutoSize = true;
            this.processing.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processing.ForeColor = System.Drawing.Color.DarkGreen;
            this.processing.Location = new System.Drawing.Point(77, 33);
            this.processing.Name = "processing";
            this.processing.Size = new System.Drawing.Size(133, 31);
            this.processing.TabIndex = 0;
            this.processing.Text = "Loading...";
            this.processing.UseMnemonic = false;
            // 
            // LoadingWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(282, 103);
            this.ControlBox = false;
            this.Controls.Add(this.processing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "loadingWindow";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label processing;
    }
}