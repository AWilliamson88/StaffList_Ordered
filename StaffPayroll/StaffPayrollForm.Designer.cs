
namespace StaffPayroll
{
    partial class StaffPayrollForm
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAutoFill = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SSMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSData = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBDisplay = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(12, 16);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(172, 20);
            this.TBName.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 56);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(432, 35);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(12, 93);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(432, 35);
            this.BtnFind.TabIndex = 2;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(12, 130);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(432, 35);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAutoFill
            // 
            this.BtnAutoFill.Location = new System.Drawing.Point(250, 13);
            this.BtnAutoFill.Name = "BtnAutoFill";
            this.BtnAutoFill.Size = new System.Drawing.Size(75, 23);
            this.BtnAutoFill.TabIndex = 4;
            this.BtnAutoFill.Text = "Auto Fill";
            this.BtnAutoFill.UseVisualStyleBackColor = true;
            this.BtnAutoFill.Click += new System.EventHandler(this.BtnAutoFill_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSMessage,
            this.SSData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SSMessage
            // 
            this.SSMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SSMessage.Name = "SSMessage";
            this.SSMessage.Size = new System.Drawing.Size(60, 17);
            this.SSMessage.Text = "Welcome.";
            // 
            // SSData
            // 
            this.SSData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SSData.Name = "SSData";
            this.SSData.Size = new System.Drawing.Size(10, 17);
            this.SSData.Text = " ";
            this.SSData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBDisplay
            // 
            this.LBDisplay.Location = new System.Drawing.Point(12, 171);
            this.LBDisplay.Name = "LBDisplay";
            this.LBDisplay.Size = new System.Drawing.Size(432, 69);
            this.LBDisplay.TabIndex = 0;
            // 
            // StaffPayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 275);
            this.Controls.Add(this.LBDisplay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnAutoFill);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TBName);
            this.Name = "StaffPayrollForm";
            this.Text = "Staff List";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAutoFill;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SSMessage;
        private System.Windows.Forms.ToolStripStatusLabel SSData;
        private System.Windows.Forms.ListBox LBDisplay;
    }
}

