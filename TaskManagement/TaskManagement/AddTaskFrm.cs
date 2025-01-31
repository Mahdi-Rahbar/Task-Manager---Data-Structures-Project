using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement
{
    public partial class AddTaskFrm : Form
    {
        public AddTaskFrm()
        {
            InitializeComponent();
        }

        private void AddTaskFrm_Load(object sender, EventArgs e)
        {
            deadlinePkr.Format = DateTimePickerFormat.Custom;
            deadlinePkr.CustomFormat = "yyyy/MM/dd hh:mm";
            deadlinePkr.ShowUpDown = true;

        }

        private void createBtn_Click(object sender, EventArgs e)
        {


            if (nameTxb.Text == "")
            {
                MessageBox.Show("Please complete Name field!");
                return;
            }

            if (descriptionTxb.Text == "")
            {
                MessageBox.Show("Please complete Description field!");
                return;
            }

            if (taskTxb.Text == "")
            {
                MenuFrm.MyTasks.AddChild(MenuFrm.MyTasks.root, new Task(nameTxb.Text, descriptionTxb.Text, deadlinePkr.Value, "to do"));

                MessageBox.Show("Task created successfully!");
                return;
            }

            Node<Task> parent = MenuFrm.MyTasks.FindNodeByProperty(MenuFrm.MyTasks.root, "Name", taskTxb.Text);

            if (parent == null)
            {
                MessageBox.Show("This task not found!");
                return;
            }

            MenuFrm.MyTasks.AddChild(parent, new Task(nameTxb.Text, descriptionTxb.Text, deadlinePkr.Value, "to do"));

            MessageBox.Show("Subtask created successfully!");
        }
    }
}
