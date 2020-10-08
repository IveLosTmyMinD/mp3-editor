using System;
using System.Collections.Generic;
using System.Text;
using TagLib;

namespace mp3_editor
{
    public class parsemp3
    {
        public string getTitle(String filepath)
        {
            String title;
            var tfile = TagLib.File.Create(filepath);
            title = tfile.Tag.Title;
            return title;
        }
        public string getAlbum(String filepath)
        {
            String album;
            var tfile = TagLib.File.Create(filepath);
            album = tfile.Tag.Album;
            return album;
        }
        public string getYear(String filepath)
        {
            String year;
            var tfile = TagLib.File.Create(filepath);
            year = Convert.ToString(tfile.Tag.Year);
            return year;
        }
        public string getArtist(String filepath)
        {
            String[] art;
            string Artists;
            var tfile = TagLib.File.Create(filepath);
            art = tfile.Tag.Performers;
            Artists = String.Concat(art);
            return Artists;
        }
        public string getGenre(String filepath)
        {
            String[] gen;
            string Genres;
            var tfile = TagLib.File.Create(filepath);
            gen = tfile.Tag.Genres;
            Genres = String.Concat(gen);
            return Genres;
        }
    }
}