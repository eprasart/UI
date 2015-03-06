namespace kUI
{
    partial class ButtonFlatMove
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
            // Table
            // 
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Khmer OS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.UseVisualStyleBackColor = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Table_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Table_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Table_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
