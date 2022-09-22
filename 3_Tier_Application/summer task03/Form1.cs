using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppProps;
using DAL;
using BLL;

namespace summer_task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGridView();
        }

        UserBLL ubll = new UserBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = textBox2.Text;
            u.Email = textBox3.Text;
            
            if (ubll.AddUserbll(u))
            {
                MessageBox.Show("data inserted");
            }
            else
            {
                MessageBox.Show("Error");
            }

            LoadGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            User u = new User();
            u.Id = int.Parse(textBox1.Text);
            u.Name = textBox2.Text;
            u.Email = textBox3.Text;

            if (ubll.UpdateUserbll(u))
            {
                MessageBox.Show("data updated");
            }
            else
            {
                MessageBox.Show("Error");
            }

            LoadGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            User u = new User();
           u.Id = int.Parse(textBox1.Text);
           
            if (ubll.DeleteUserbll(u))
            {
                MessageBox.Show("data Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadGridView();
        }

         

        

       

        private void LoadGridView()
        {
            userDataGridView.DataSource = ubll.GetallUserbll();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            User u = new User();

            u.Id = int.Parse(textBox1.Text);

            if (ubll.SearchUserbll(u) != null)
            {
                DataTable dataTable = ubll.SearchUserbll(u);

                if (dataTable.Rows.Count > 0)
                {
                    textBox2.Text = dataTable.Rows[0]["name"].ToString();
                    textBox3.Text = dataTable.Rows[0]["email"].ToString();
                    MessageBox.Show("data found");
                }
                else
                {
                    MessageBox.Show("not found");
                }

                LoadGridView();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            User u = new User();

            u.Id = int.Parse(textBox1.Text);



            if (ubll.GetallUserbll() != null)
            {
                DataTable dataTable = ubll.GetallUserbll();

                if (dataTable.Rows.Count > 0)
                {
                    textBox2.Text = dataTable.Rows[0]["name"].ToString();
                    textBox3.Text = dataTable.Rows[0]["email"].ToString();
                    MessageBox.Show("data found");
                }
                else
                {
                    MessageBox.Show("not found");
                }

                LoadGridView();
            }

        }
    }
}
