namespace NOpsForm
{
    partial class TestPanel
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
            this.TestPanelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestPanelName
            // 
            this.TestPanelName.AutoSize = true;
            this.TestPanelName.Location = new System.Drawing.Point(57, 37);
            this.TestPanelName.Name = "TestPanelName";
            this.TestPanelName.Size = new System.Drawing.Size(35, 13);
            this.TestPanelName.TabIndex = 0;
            this.TestPanelName.Text = "label1";
            // 
            // TestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TestPanelName);
            this.Name = "TestPanel";
            this.Size = new System.Drawing.Size(375, 85);
            this.Load += new System.EventHandler(this.TestPanel_Load);
            this.MouseLeave += new System.EventHandler(this.TestPanel_MouseLeave);
            this.MouseEnter += new System.EventHandler(this.TestPanel_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestPanelName;
    }
}
