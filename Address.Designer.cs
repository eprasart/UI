namespace kUI
{
    partial class Address
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Address));
            this.btnAddress = new System.Windows.Forms.Button();
            this.mnuAddress = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.businessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAddress = new kUI.TextBox(this.components);
            this.mnuAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddress
            // 
            this.btnAddress.Image = ((System.Drawing.Image)(resources.GetObject("btnAddress.Image")));
            this.btnAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddress.Location = new System.Drawing.Point(0, 0);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(83, 23);
            this.btnAddress.TabIndex = 0;
            this.btnAddress.Text = "Business";
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            this.btnAddress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAddress_MouseDown);
            // 
            // mnuAddress
            // 
            this.mnuAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.businessToolStripMenuItem,
            this.billToToolStripMenuItem,
            this.shipToToolStripMenuItem,
            this.warehouseToolStripMenuItem,
            this.legalToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.postalToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.mnuAddress.Name = "contextMenuStrip1";
            this.mnuAddress.Size = new System.Drawing.Size(153, 202);
            // 
            // businessToolStripMenuItem
            // 
            this.businessToolStripMenuItem.Name = "businessToolStripMenuItem";
            this.businessToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.businessToolStripMenuItem.Tag = "0";
            this.businessToolStripMenuItem.Text = "Business";
            this.businessToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // billToToolStripMenuItem
            // 
            this.billToToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billToToolStripMenuItem.Name = "billToToolStripMenuItem";
            this.billToToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.billToToolStripMenuItem.Tag = "1";
            this.billToToolStripMenuItem.Text = "Bill To";
            this.billToToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // shipToToolStripMenuItem
            // 
            this.shipToToolStripMenuItem.Name = "shipToToolStripMenuItem";
            this.shipToToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shipToToolStripMenuItem.Tag = "2";
            this.shipToToolStripMenuItem.Text = "Ship To";
            this.shipToToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.warehouseToolStripMenuItem.Tag = "3";
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            this.warehouseToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // legalToolStripMenuItem
            // 
            this.legalToolStripMenuItem.Name = "legalToolStripMenuItem";
            this.legalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.legalToolStripMenuItem.Tag = "4";
            this.legalToolStripMenuItem.Text = "Legal";
            this.legalToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Tag = "5";
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // postalToolStripMenuItem
            // 
            this.postalToolStripMenuItem.Name = "postalToolStripMenuItem";
            this.postalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.postalToolStripMenuItem.Tag = "6";
            this.postalToolStripMenuItem.Text = "Postal";
            this.postalToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem.Tag = "7";
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = true;
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(83, 0);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 57);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TabOnEnter = false;
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAddress);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Address";
            this.Size = new System.Drawing.Size(354, 57);
            this.mnuAddress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddress;
        private TextBox txtAddress;
        private System.Windows.Forms.ContextMenuStrip mnuAddress;
        private System.Windows.Forms.ToolStripMenuItem businessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
    }
}
