using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoList
{
    public partial class toDoList_form : Form
    {
        public toDoList_form()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addTask_btn_Click(object sender, EventArgs e)
        {
            DateTime date = date_dp.Value;
            string task = task_txtb.Text;
            
            if(task == "" || task == null)
                MessageBox.Show("Preencha todos os campos!");
            else
                toDos_lb.Items.Add($"{date:d} - {task}");
                if (toDos_lb.Items.Count >= 0)
                    deleteTask_btn.Enabled = true;



        }

        private void deleteTask_btn_Click(object sender, EventArgs e)
        {
            int taskIndex = toDos_lb.SelectedIndex;
            toDos_lb.Items.RemoveAt(taskIndex);

            if(toDos_lb.Items.Count < 1)
                deleteTask_btn.Enabled = false;
        }

        private void toDoList_form_Load(object sender, EventArgs e)
        {
            
        }

        private void toDos_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
