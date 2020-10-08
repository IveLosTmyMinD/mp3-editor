using System;
using TagLib;

namespace mp3_editor
{
    public class parsemp3
    {
        
        public string readMusic(String filepath)
        {
            var tfile = TagLib.File.Create(filepath);
            String title;
            title = tfile.Tag.Title;
            return title;
        }

    }
}