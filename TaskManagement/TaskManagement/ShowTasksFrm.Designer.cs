
namespace TaskManagement
{
    partial class ShowTasksFrm
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
            this.TasksTable = new System.Windows.Forms.DataGridView();
            this.SubtaskTable = new System.Windows.Forms.DataGridView();
            this.doneBtn = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtaskTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksTable
            // 
            this.TasksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksTable.Location = new System.Drawing.Point(32, 12);
            this.TasksTable.Name = "TasksTable";
            this.TasksTable.Size = new System.Drawing.Size(438, 246);
            this.TasksTable.TabIndex = 0;
            this.TasksTable.SelectionChanged += new System.EventHandler(this.TasksTable_SelectionChanged);
            // 
            // SubtaskTable
            // 
            this.SubtaskTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubtaskTable.Location = new System.Drawing.Point(66, 276);
            this.SubtaskTable.Name = "SubtaskTable";
            this.SubtaskTable.Size = new System.Drawing.Size(371, 138);
            this.SubtaskTable.TabIndex = 1;
            // 
            // doneBtn
            // 
            this.doneBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.doneBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Location = new System.Drawing.Point(476, 333);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(96, 34);
            this.doneBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.doneBtn.TabIndex = 9;
            this.doneBtn.Text = "Done";
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // ShowTasksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(609, 443);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.SubtaskTable);
            this.Controls.Add(this.TasksTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowTasksFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Tasks";
            this.Load += new System.EventHandler(this.ShowTasksFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubtaskTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TasksTable;
        private System.Windows.Forms.DataGridView SubtaskTable;
        private DevComponents.DotNetBar.ButtonX doneBtn;
    }
}