
namespace StaffList_Ordered
{
    partial class StaffOrderedByNameForm
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
            this.TBDisplay = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(13, 13);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(13, 40);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(13, 70);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(75, 23);
            this.BtnFind.TabIndex = 2;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(13, 100);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnAutoFill
            // 
            this.BtnAutoFill.Location = new System.Drawing.Point(162, 13);
            this.BtnAutoFill.Name = "BtnAutoFill";
            this.BtnAutoFill.Size = new System.Drawing.Size(75, 23);
            this.BtnAutoFill.TabIndex = 4;
            this.BtnAutoFill.Text = "Auto Fill";
            this.BtnAutoFill.UseVisualStyleBackColor = true;
            this.BtnAutoFill.Click += new System.EventHandler(this.BtnAutoFill_Click);
            // 
            // TBDisplay
            // 
            this.TBDisplay.Location = new System.Drawing.Point(13, 130);
            this.TBDisplay.Multiline = true;
            this.TBDisplay.Name = "TBDisplay";
            this.TBDisplay.Size = new System.Drawing.Size(639, 71);
            this.TBDisplay.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SSLabel
            // 
            this.SSLabel.Name = "SSLabel";
            this.SSLabel.Size = new System.Drawing.Size(60, 17);
            this.SSLabel.Text = "Welcome.";
            // 
            // StaffOrderedByNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 233);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TBDisplay);
            this.Controls.Add(this.BtnAutoFill);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TBName);
            this.Name = "StaffOrderedByNameForm";
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
        private System.Windows.Forms.TextBox TBDisplay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SSLabel;
    }
}

