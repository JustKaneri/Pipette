namespace Пипетка
{
    partial class FormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            this.PnlColorShow = new System.Windows.Forms.Panel();
            this.TbxRgb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbxName = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PnlColorShow
            // 
            this.PnlColorShow.Location = new System.Drawing.Point(2, 1);
            this.PnlColorShow.Name = "PnlColorShow";
            this.PnlColorShow.Size = new System.Drawing.Size(347, 88);
            this.PnlColorShow.TabIndex = 0;
            // 
            // TbxRgb
            // 
            this.TbxRgb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxRgb.Location = new System.Drawing.Point(2, 214);
            this.TbxRgb.Name = "TbxRgb";
            this.TbxRgb.ReadOnly = true;
            this.TbxRgb.Size = new System.Drawing.Size(347, 34);
            this.TbxRgb.TabIndex = 1;
            this.TbxRgb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "RGB:";
            // 
            // LbxName
            // 
            this.LbxName.AutoSize = true;
            this.LbxName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbxName.Location = new System.Drawing.Point(5, 109);
            this.LbxName.Name = "LbxName";
            this.LbxName.Size = new System.Drawing.Size(59, 27);
            this.LbxName.TabIndex = 4;
            this.LbxName.Text = "Hex:";
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxName.Location = new System.Drawing.Point(2, 139);
            this.TbxName.Name = "TbxName";
            this.TbxName.ReadOnly = true;
            this.TbxName.Size = new System.Drawing.Size(347, 34);
            this.TbxName.TabIndex = 3;
            this.TbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 262);
            this.Controls.Add(this.LbxName);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxRgb);
            this.Controls.Add(this.PnlColorShow);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Цвет";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlColorShow;
        private System.Windows.Forms.TextBox TbxRgb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbxName;
        private System.Windows.Forms.TextBox TbxName;
    }
}