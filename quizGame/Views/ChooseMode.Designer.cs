namespace quizGame.Views
{
    partial class ChooseMode
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModeDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timeMode = new System.Windows.Forms.RadioButton();
            this.basicMode = new System.Windows.Forms.RadioButton();
            this.fastMode = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ModeDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 193);
            this.panel2.TabIndex = 1;
            // 
            // ModeDescription
            // 
            this.ModeDescription.AutoEllipsis = true;
            this.ModeDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModeDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModeDescription.Location = new System.Drawing.Point(0, 0);
            this.ModeDescription.Name = "ModeDescription";
            this.ModeDescription.Size = new System.Drawing.Size(1283, 75);
            this.ModeDescription.TabIndex = 0;
            this.ModeDescription.Text = "Basic mode: No time";
            this.ModeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.39697F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.60303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 408F));
            this.tableLayoutPanel1.Controls.Add(this.timeMode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.basicMode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fastMode, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 432);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // timeMode
            // 
            this.timeMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.timeMode.AutoEllipsis = true;
            this.timeMode.BackColor = System.Drawing.Color.Cyan;
            this.timeMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeMode.FlatAppearance.BorderSize = 0;
            this.timeMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.timeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeMode.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeMode.Location = new System.Drawing.Point(417, 3);
            this.timeMode.Name = "timeMode";
            this.timeMode.Padding = new System.Windows.Forms.Padding(10);
            this.timeMode.Size = new System.Drawing.Size(454, 426);
            this.timeMode.TabIndex = 2;
            this.timeMode.TabStop = true;
            this.timeMode.Tag = "M02";
            this.timeMode.Text = "Time mode";
            this.timeMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeMode.UseMnemonic = false;
            this.timeMode.UseVisualStyleBackColor = false;
            this.timeMode.CheckedChanged += new System.EventHandler(this.timeMode_CheckedChanged);
            // 
            // basicMode
            // 
            this.basicMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.basicMode.AutoEllipsis = true;
            this.basicMode.BackColor = System.Drawing.Color.Cyan;
            this.basicMode.Checked = true;
            this.basicMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.basicMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicMode.FlatAppearance.BorderSize = 0;
            this.basicMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.basicMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicMode.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicMode.Location = new System.Drawing.Point(3, 3);
            this.basicMode.Name = "basicMode";
            this.basicMode.Padding = new System.Windows.Forms.Padding(10);
            this.basicMode.Size = new System.Drawing.Size(408, 426);
            this.basicMode.TabIndex = 1;
            this.basicMode.TabStop = true;
            this.basicMode.Tag = "M01";
            this.basicMode.Text = "Basic mode";
            this.basicMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.basicMode.UseMnemonic = false;
            this.basicMode.UseVisualStyleBackColor = false;
            this.basicMode.CheckedChanged += new System.EventHandler(this.basicMode_CheckedChanged);
            // 
            // fastMode
            // 
            this.fastMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.fastMode.AutoEllipsis = true;
            this.fastMode.BackColor = System.Drawing.Color.Cyan;
            this.fastMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fastMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastMode.FlatAppearance.BorderSize = 0;
            this.fastMode.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.fastMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastMode.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastMode.Location = new System.Drawing.Point(877, 3);
            this.fastMode.Name = "fastMode";
            this.fastMode.Padding = new System.Windows.Forms.Padding(10);
            this.fastMode.Size = new System.Drawing.Size(403, 426);
            this.fastMode.TabIndex = 3;
            this.fastMode.TabStop = true;
            this.fastMode.Tag = "M03";
            this.fastMode.Text = "Fast mode";
            this.fastMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fastMode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.fastMode.UseMnemonic = false;
            this.fastMode.UseVisualStyleBackColor = false;
            this.fastMode.CheckedChanged += new System.EventHandler(this.fastMode_CheckedChanged);
            // 
            // ChooseMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1283, 625);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseMode";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton timeMode;
        private System.Windows.Forms.RadioButton basicMode;
        private System.Windows.Forms.RadioButton fastMode;
        private System.Windows.Forms.Label ModeDescription;
    }
}