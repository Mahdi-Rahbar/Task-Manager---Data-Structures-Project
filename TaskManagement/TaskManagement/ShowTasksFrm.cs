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
    public partial class ShowTasksFrm : Form
    {
        List<Node<Task>> Tasks = MenuFrm.MyTasks.root.children;
        public int num;
        public ShowTasksFrm()
        {
            InitializeComponent();
        }

        private void ShowTasksFrm_Load(object sender, EventArgs e)
        {
            List<Node<Task>> TasksNodes = MenuFrm.MyTasks.root.children;

            var sortedList = TasksNodes.OrderBy(node => node.data.Deadline).ToList();

            Tasks = sortedList;

            TasksTable.Columns.Add("Name", "Name");
            TasksTable.Columns.Add("Description", "Description");
            TasksTable.Columns.Add("deadline", "deadline");
            TasksTable.Columns.Add("Status", "Status");

            foreach (var node in Tasks)
            {
                TasksTable.Rows.Add(node.data.Name, node.data.Description, node.data.Deadline, node.data.Status);

            }
        }

        private void TasksTable_SelectionChanged(object sender, EventArgs e)
        {
            SubtaskTable.Rows.Clear();
            SubtaskTable.Columns.Clear();

            if (TasksTable.SelectedRows.Count > 0)
            {
                var selectedNode = Tasks[TasksTable.SelectedRows[0].Index];

                num = MenuFrm.MyTasks.ChilderNum(selectedNode);

                SubtaskTable.Columns.Add("Name", "Name");
                SubtaskTable.Columns.Add("Description", "Description");
                SubtaskTable.Columns.Add("deadline", "deadline");
                SubtaskTable.Columns.Add("Status", "Status");


                foreach (var childNode in selectedNode.children)
                {
                    SubtaskTable.Rows.Add(childNode.data.Name, childNode.data.Description, childNode.data.Deadline, childNode.data.Status);
                }
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            num--;
            if (num == 0 && TasksTable.CurrentRow != null)
            {
                TasksTable.CurrentRow.Cells["Status"].Value = "done";
            }

            if (SubtaskTable.CurrentRow != null)
            {
                SubtaskTable.CurrentRow.Cells["Status"].Value = "done";
            }
        }
    }
}
