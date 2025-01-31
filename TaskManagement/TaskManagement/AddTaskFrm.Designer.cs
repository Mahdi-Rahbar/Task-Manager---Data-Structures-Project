
namespace TaskManagement
{
    partial class AddTaskFrm
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
            this.deadlinePkr = new System.Windows.Forms.DateTimePicker();
            this.deadlineLbl = new System.Windows.Forms.Label();
            this.taskLbl = new System.Windows.Forms.Label();
            this.taskTxb = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.descriptionTxb = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.createBtn = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // deadlinePkr
            // 
            this.deadlinePkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlinePkr.Location = new System.Drawing.Point(120, 130);
            this.deadlinePkr.Name = "deadlinePkr";
            this.deadlinePkr.Size = new System.Drawing.Size(198, 22);
            this.deadlinePkr.TabIndex = 0;
            // 
            // deadlineLbl
            // 
            this.deadlineLbl.AutoSize = true;
            this.deadlineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineLbl.Location = new System.Drawing.Point(14, 130);
            this.deadlineLbl.Name = "deadlineLbl";
            this.deadlineLbl.Size = new System.Drawing.Size(80, 20);
            this.deadlineLbl.TabIndex = 1;
            this.deadlineLbl.Text = "Deadline :";
            // 
            // taskLbl
            // 
            this.taskLbl.AutoSize = true;
            this.taskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLbl.Location = new System.Drawing.Point(17, 179);
            this.taskLbl.Name = "taskLbl";
            this.taskLbl.Size = new System.Drawing.Size(51, 20);
            this.taskLbl.TabIndex = 2;
            this.taskLbl.Text = "Task :";
            // 
            // taskTxb
            // 
            this.taskTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTxb.Location = new System.Drawing.Point(120, 179);
            this.taskTxb.Name = "taskTxb";
            this.taskTxb.Size = new System.Drawing.Size(198, 22);
            this.taskTxb.TabIndex = 3;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(17, 78);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(97, 20);
            this.descriptionLbl.TabIndex = 4;
            this.descriptionLbl.Text = "Description :";
            // 
            // descriptionTxb
            // 
            this.descriptionTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTxb.Location = new System.Drawing.Point(120, 78);
            this.descriptionTxb.Name = "descriptionTxb";
            this.descriptionTxb.Size = new System.Drawing.Size(198, 22);
            this.descriptionTxb.TabIndex = 5;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(17, 29);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 20);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name :";
            // 
            // nameTxb
            // 
            this.nameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxb.Location = new System.Drawing.Point(120, 29);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(198, 22);
            this.nameTxb.TabIndex = 7;
            // 
            // createBtn
            // 
            this.createBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.createBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(170, 227);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(96, 34);
            this.createBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Create";
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // AddTaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(384, 282);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.nameTxb);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.descriptionTxb);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.taskTxb);
            this.Controls.Add(this.taskLbl);
            this.Controls.Add(this.deadlineLbl);
            this.Controls.Add(this.deadlinePkr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTaskFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddTaskFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker deadlinePkr;
        private System.Windows.Forms.Label deadlineLbl;
        private System.Windows.Forms.Label taskLbl;
        private System.Windows.Forms.TextBox taskTxb;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox descriptionTxb;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxb;
        private DevComponents.DotNetBar.ButtonX createBtn;
    }
}