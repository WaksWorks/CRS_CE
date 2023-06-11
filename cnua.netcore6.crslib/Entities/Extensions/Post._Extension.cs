using Microsoft.Extensions.Hosting;
using System;

namespace CSR.Entities.Extensions
{
    public static class Post_Extension
    {
        public static string ToRow(this Post post)
        {
            var str = post.PostGuid.ToString() + @", " +
                post.TimePosted.ToString() + @" - " +
                post.MemberHandle + @": " +
                post.Message + @", ";

            return str;
        }
        public static void WriteWave(this Post? post)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                var di = Directory.CreateDirectory(post.ChatRoom.ChatRoomName);
                    // Configure the audio output
                string outputFileName = di.FullName + @"\" + post.PostGuid.ToString() + @".wav";
                synth.SetOutputToWaveFile(outputFileName,
                    new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
                // Build a prompt.  
                PromptBuilder builder = new PromptBuilder();
                var vg = VoiceGender.Female;
                synth.SelectVoiceByHints(vg, 0, 2);
                builder.AppendText(post.Message);
                builder.AppendBreak(PromptBreak.Medium);
                // Speak the prompt.  
                synth.Speak(builder);
            }
        }
        public static void ToWaveFiles(this Post[] posts, FileInfo outputPath)
        {
            foreach(Post post in posts)
            {
                post.WriteWave();
            }
        }
    }

}

