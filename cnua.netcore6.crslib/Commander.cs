using CSR.Collections;
using CSR.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR
{
    /// <summary>
    /// CommandLione static routines 
    /// </summary>
    static internal class Commander
    {
        public static void WriteAudioTranscription(string path)
        {          
            var pl = new PostList(path);
            pl.LoadOriginalText();
            pl.WriteAudioPosts();
            pl.WriteAudioTranscription();
        }
        public static void SaveCsv(string path)
        {
            var pl = new PostList(path);
            pl.LoadOriginalText();
            pl.SaveCSV();
        }

    }
}
