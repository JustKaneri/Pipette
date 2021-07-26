namespace Пипетка
{
    partial class FormProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProperties));
            this.CbxAutoLoad = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxKeys = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxAutoLoad
            // 
            this.CbxAutoLoad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxAutoLoad.Location = new System.Drawing.Point(12, 12);
            this.CbxAutoLoad.Name = "CbxAutoLoad";
            this.CbxAutoLoad.Size = new System.Drawing.Size(328, 61);
            this.CbxAutoLoad.TabIndex = 0;
            this.CbxAutoLoad.Text = "Запуск приложения вместе с Windows";
            this.CbxAutoLoad.UseVisualStyleBackColor = true;
            this.CbxAutoLoad.CheckedChanged += new System.EventHandler(this.CbxAutoLoad_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxKeys);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кнопка включения:";
            // 
            // CbxKeys
            // 
            this.CbxKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxKeys.FormattingEnabled = true;
            this.CbxKeys.Location = new System.Drawing.Point(6, 47);
            this.CbxKeys.Name = "CbxKeys";
            this.CbxKeys.Size = new System.Drawing.Size(316, 34);
            this.CbxKeys.TabIndex = 0;
            this.CbxKeys.SelectedIndexChanged += new System.EventHandler(this.CbxKeys_SelectedIndexChanged);
            // 
            // FormProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 210);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CbxAutoLoad);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProperties_FormClosing);
            this.Load += new System.EventHandler(this.FormProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox CbxAutoLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxKeys;
    }
}