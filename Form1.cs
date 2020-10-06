using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3_editor
{
    public partial class Form1 : Form
    {
        List<String> filenames = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            

            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                
                foreach (String filename in ofd.FileNames)
                {
                    filenames.Add(filename);
                    i++;
                    dataGridView1.Rows.Add(filename);
                }
            }

            toolStripStatusLabel1.Text = i.ToString();
        }
    }
}
