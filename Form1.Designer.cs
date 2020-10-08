namespace mp3_editor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mS1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sS1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_cover = new System.Windows.Forms.Label();
            this.bt_image = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.lb_genre = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.lb_album = new System.Windows.Forms.Label();
            this.lb_artist = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.tb_album = new System.Windows.Forms.TextBox();
            this.tb_artist = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mS1.SuspendLayout();
            this.sS1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mS1
            // 
            this.mS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mS1.Location = new System.Drawing.Point(0, 0);
            this.mS1.Name = "mS1";
            this.mS1.Size = new System.Drawing.Size(800, 24);
            this.mS1.TabIndex = 0;
            this.mS1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // sS1
            // 
            this.sS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sS1.Location = new System.Drawing.Point(0, 428);
            this.sS1.Name = "sS1";
            this.sS1.Size = new System.Drawing.Size(800, 22);
            this.sS1.TabIndex = 1;
            this.sS1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_cover);
            this.panel1.Controls.Add(this.bt_image);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Controls.Add(this.lb_genre);
            this.panel1.Controls.Add(this.lb_year);
            this.panel1.Controls.Add(this.tb_genre);
            this.panel1.Controls.Add(this.tb_year);
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.lb_album);
            this.panel1.Controls.Add(this.lb_artist);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.tb_album);
            this.panel1.Controls.Add(this.tb_artist);
            this.panel1.Controls.Add(this.tb_title);
            this.panel1.Location = new System.Drawing.Point(0, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 177);
            this.panel1.TabIndex = 3;
            // 
            // lb_cover
            // 
            this.lb_cover.Location = new System.Drawing.Point(667, 49);
            this.lb_cover.Name = "lb_cover";
            this.lb_cover.Size = new System.Drawing.Size(100, 16);
            this.lb_cover.TabIndex = 13;
            this.lb_cover.Text = "Cover";
            // 
            // bt_image
            // 
            this.bt_image.Location = new System.Drawing.Point(667, 68);
            this.bt_image.Name = "bt_image";
            this.bt_image.Size = new System.Drawing.Size(75, 23);
            this.bt_image.TabIndex = 12;
            this.bt_image.Text = "Choose";
            this.bt_image.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(476, 117);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(172, 23);
            this.bt_save.TabIndex = 11;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // lb_genre
            // 
            this.lb_genre.AutoSize = true;
            this.lb_genre.Location = new System.Drawing.Point(249, 102);
            this.lb_genre.Name = "lb_genre";
            this.lb_genre.Size = new System.Drawing.Size(36, 13);
            this.lb_genre.TabIndex = 10;
            this.lb_genre.Text = "Genre";
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(15, 102);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(29, 13);
            this.lb_year.TabIndex = 9;
            this.lb_year.Text = "Year";
            // 
            // tb_genre
            // 
            this.tb_genre.Location = new System.Drawing.Point(249, 120);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(172, 20);
            this.tb_genre.TabIndex = 8;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(13, 121);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(172, 20);
            this.tb_year.TabIndex = 7;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(12, 12);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(140, 23);
            this.bt_clear.TabIndex = 6;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // lb_album
            // 
            this.lb_album.AutoSize = true;
            this.lb_album.Location = new System.Drawing.Point(476, 49);
            this.lb_album.Name = "lb_album";
            this.lb_album.Size = new System.Drawing.Size(36, 13);
            this.lb_album.TabIndex = 5;
            this.lb_album.Text = "Album";
            // 
            // lb_artist
            // 
            this.lb_artist.AutoSize = true;
            this.lb_artist.Location = new System.Drawing.Point(246, 49);
            this.lb_artist.Name = "lb_artist";
            this.lb_artist.Size = new System.Drawing.Size(30, 13);
            this.lb_artist.TabIndex = 4;
            this.lb_artist.Text = "Artist";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(12, 49);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(27, 13);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Title";
            // 
            // tb_album
            // 
            this.tb_album.Location = new System.Drawing.Point(476, 68);
            this.tb_album.Name = "tb_album";
            this.tb_album.Size = new System.Drawing.Size(172, 20);
            this.tb_album.TabIndex = 2;
            // 
            // tb_artist
            // 
            this.tb_artist.Location = new System.Drawing.Point(249, 68);
            this.tb_artist.Name = "tb_artist";
            this.tb_artist.Size = new System.Drawing.Size(172, 20);
            this.tb_artist.TabIndex = 1;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(13, 68);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(172, 20);
            this.tb_title.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Multiselect = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArtist,
            this.colTitle,
            this.colAlbum});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 227);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colArtist
            // 
            this.colArtist.HeaderText = "Artist";
            this.colArtist.Name = "colArtist";
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            // 
            // colAlbum
            // 
            this.colAlbum.HeaderText = "Album";
            this.colAlbum.Name = "colAlbum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sS1);
            this.Controls.Add(this.mS1);
            this.MainMenuStrip = this.mS1;
            this.Name = "Form1";
            this.Text = "MP3 Editor";
            this.mS1.ResumeLayout(false);
            this.mS1.PerformLayout();
            this.sS1.ResumeLayout(false);
            this.sS1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.MenuStrip mS1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.StatusStrip sS1;

        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_image;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lb_album;
        private System.Windows.Forms.Label lb_artist;
        private System.Windows.Forms.Label lb_cover;
        private System.Windows.Forms.Label lb_genre;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_album;
        private System.Windows.Forms.TextBox tb_artist;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlbum;
    }
}

