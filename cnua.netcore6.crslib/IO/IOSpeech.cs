using System;
using System.Speech.Synthesis;
using System.Windows;
using System.Speech;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Speech.AudioFormat;
using CSR.Entities.Extensions;

namespace CSR.IO
{
    /// <summary>
    /// read text
    /// save 
    /// </summary>
    public static class IOSpeech
    {
        public static void MakeSoundFile(Post post)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {

                // Configure the audio output.   
                synth.SetOutputToWaveFile(@"crs.wav",
                  new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));

                // Create a SoundPlayer instance to play output audio file.  
                //System.Media.SoundPlayer m_SoundPlayer =   
                //  new System.Media.SoundPlayer(@"C:\temp\test.wav");  

                // Build a prompt.  
                PromptBuilder builder = new PromptBuilder();
                builder.AppendText(post.Message);
                builder.AppendBreak(PromptBreak.Large);
                builder.AppendText(post.Message);
                builder.AppendBreak(PromptBreak.Medium);
                builder.AppendText(post.Message);
                builder.AppendBreak(PromptBreak.Small);
                builder.AppendText(post.Message);
                builder.AppendBreak(PromptBreak.ExtraSmall);
                builder.AppendText(@"this is large");
                builder.AppendBreak(PromptBreak.ExtraLarge);
                // Speak the prompt.  
                synth.Speak(builder);
                //m_SoundPlayer.Play();  
            }
        }
    }
}