using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConquerItemPriceEditor.Utilities
{
    public class Sounds
    {
        SoundPlayer player = new SoundPlayer();

        public void Play(string file)
        {
            player.Stop();
            player.SoundLocation = file;
            player.Play();
        }

        public void PlayStream(Stream stream)
        {
            player.Stop();
            player.Stream = stream;
            player.Play();
        }
    }
}
