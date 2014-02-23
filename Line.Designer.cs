namespace Kredit.UI
{
    partial class Line
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
            this.SuspendLayout();
            // 
            // Line
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.Size = new System.Drawing.Size(100, 2);
            this.SizeChanged += new System.EventHandler(this.Line_SizeChanged);
            this.Resize += new System.EventHandler(this.Line_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
