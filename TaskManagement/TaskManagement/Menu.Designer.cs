
namespace TaskManagement
{
    partial class MenuFrm
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
            this.MenuPnl = new System.Windows.Forms.Panel();
            this.ShowBtn = new DevComponents.DotNetBar.ButtonX();
            this.AddBtn = new DevComponents.DotNetBar.ButtonX();
            this.MenuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPnl
            // 
            this.MenuPnl.BackgroundImage = global::TaskManagement.Properties.Resources.MainMenuBackground;
            this.MenuPnl.Controls.Add(this.ShowBtn);
            this.MenuPnl.Controls.Add(this.AddBtn);
            this.MenuPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPnl.Location = new System.Drawing.Point(0, 0);
            this.MenuPnl.Name = "MenuPnl";
            this.MenuPnl.Size = new System.Drawing.Size(684, 361);
            this.MenuPnl.TabIndex = 0;
            // 
            // ShowBtn
            // 
            this.ShowBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ShowBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.Location = new System.Drawing.Point(33, 163);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(103, 42);
            this.ShowBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "Show Tasks";
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(33, 95);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(103, 42);
            this.AddBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Task";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.MenuPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management";
            this.Load += new System.EventHandler(this.MenuFrm_Load);
            this.MenuPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPnl;
        private DevComponents.DotNetBar.ButtonX AddBtn;
        private DevComponents.DotNetBar.ButtonX ShowBtn;
    }
}

