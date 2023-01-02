using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4GetMeNot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*Text box to add items to the list */

        private void button1_Click(object sender, EventArgs e)
        {

            string sample = "<End of Task>";
            Task taskObject = new Task();
            taskObject.Tasks = textBox1.Text;
            taskObject.Requirement = textBox2.Text;
            taskObject.Person = textBox3.Text + sample ;

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";

        /*List box code to add items */

            ListBoxResults.Items.Add(taskObject.Tasks);
            ListBoxResults.Items.Add(taskObject.Requirement);
            ListBoxResults.Items.Add(taskObject.Person);


        }

        /*Delete items from the list box */

        private void button3_Click(object sender, EventArgs e)
        {
            ListBoxResults.Items.Clear();

        }

        /*Copy items from the listbox */

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in ListBoxResults.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }
    }
}
