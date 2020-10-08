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
                    dataGridView1.Rows.Add(String.Concat(TagLib.File.Create(filepath).Tag.Performers), 
                        TagLib.File.Create(filepath).Tag.Title,
                        TagLib.File.Create(filepath).Tag.Album);
                }
                toolStripStatusLabel1.Text = i.ToString();
            }            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowi = dataGridView1.CurrentCell.RowIndex;
            parsemp3 parce = new parsemp3();
            tb_artist.Text = parce.getArtist(filenames[rowi]);
            tb_genre.Text = parce.getGenre(filenames[rowi]);
            tb_title.Text = parce.getTitle(filenames[rowi]);
            tb_album.Text = parce.getAlbum(filenames[rowi]);
            tb_year.Text = parce.getYear(filenames[rowi]);
        }
    }
}
