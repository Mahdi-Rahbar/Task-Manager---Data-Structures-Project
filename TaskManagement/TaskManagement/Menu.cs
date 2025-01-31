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
    public partial class MenuFrm : Form
    {
        public static GeneralTree<Task> MyTasks = new GeneralTree<Task>(new Task("Root", "is Root", DateTime.MinValue, "to do"));

        public MenuFrm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddTaskFrm().ShowDialog();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            new ShowTasksFrm().ShowDialog();
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
