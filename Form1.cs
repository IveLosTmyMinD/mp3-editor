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
        private String tfile, title, artist, album, genre, year;

        

        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {      
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                int i = 0;
                foreach (String filepath in ofd.FileNames)
                {
                    filenames.Add(filepath);
                    i++;
                    dataGridView1.Rows.Add(filepath);
                }
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        // private void addList()
        // {
        //     int i = 0;
        //     foreach (String filepath in ofd.FileNames)
        //     {
        //         filenames.Add(filepath);
        //         i++;
        //         dataGridView1.Rows.Add(filepath);
        //         var rowi = dataGridView1.CurrentCell.RowIndex;
        //         
        //         
        //     }
        //     toolStripStatusLabel1.Text = i.ToString();
        // }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowi = dataGridView1.CurrentCell.RowIndex;
            parsemp3 parce = new parsemp3();
            var tb = parce.readMusic(filenames[rowi]);
            tb_title.Text = tb;
        }
    }
}
