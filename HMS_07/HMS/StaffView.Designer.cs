namespace HMS
{
    partial class StaffView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffView));
            this.dgvstaff = new System.Windows.Forms.DataGridView();
            this.bttnshow = new System.Windows.Forms.Button();
            this.bttnlogout = new System.Windows.Forms.Button();
            this.bttnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstaff
            // 
            this.dgvstaff.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstaff.Location = new System.Drawing.Point(306, 25);
            this.dgvstaff.Name = "dgvstaff";
            this.dgvstaff.ReadOnly = true;
            this.dgvstaff.RowTemplate.Height = 24;
            this.dgvstaff.Size = new System.Drawing.Size(501, 224);
            this.dgvstaff.TabIndex = 0;
            // 
            // bttnshow
            // 
            this.bttnshow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnshow.Location = new System.Drawing.Point(501, 270);
            this.bttnshow.Name = "bttnshow";
            this.bttnshow.Size = new System.Drawing.Size(117, 36);
            this.bttnshow.TabIndex = 1;
            this.bttnshow.Text = "Show";
            this.bttnshow.UseVisualStyleBackColor = false;
            this.bttnshow.Click += new System.EventHandler(this.bttnshow_Click);
            // 
            // bttnlogout
            // 
            this.bttnlogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnlogout.Location = new System.Drawing.Point(960, 286);
            this.bttnlogout.Name = "bttnlogout";
            this.bttnlogout.Size = new System.Drawing.Size(97, 47);
            this.bttnlogout.TabIndex = 2;
            this.bttnlogout.Text = "Logout";
            this.bttnlogout.UseVisualStyleBackColor = false;
            this.bttnlogout.Click += new System.EventHandler(this.bttnlogout_Click);
            // 
            // bttnsearch
            // 
            this.bttnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsearch.Location = new System.Drawing.Point(90, 117);
            this.bttnsearch.Name = "bttnsearch";
            this.bttnsearch.Size = new System.Drawing.Size(108, 39);
            this.bttnsearch.TabIndex = 3;
            this.bttnsearch.Text = "Search";
            this.bttnsearch.UseVisualStyleBackColor = false;
            this.bttnsearch.Click += new System.EventHandler(this.bttnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(67, 80);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(158, 22);
            this.txtsearch.TabIndex = 4;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1108, 351);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.bttnsearch);
            this.Controls.Add(this.bttnlogout);
            this.Controls.Add(this.bttnshow);
            this.Controls.Add(this.dgvstaff);
            this.Name = "StaffView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstaff;
        private System.Windows.Forms.Button bttnshow;
        private System.Windows.Forms.Button bttnlogout;
        private System.Windows.Forms.Button bttnsearch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}