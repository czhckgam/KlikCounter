using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace KlikCounter
{
    public class Player
    {
        //PUBLIC METHODS
        /// <summary>
        /// Plays Soviet anthem by Console.Beep() in a new thread
        /// </summary>
        public void PlaySovietAnthem()
        {
            Thread thread = new Thread(SovietAnthem);
            thread.Start();
        }

        public void Yaa()
        {
            SoundPlayer player = new SoundPlayer("../../YARP/yaa1.wav");
            player.Play();
        }

        public void YaaYaa()
        {
            SoundPlayer player = new SoundPlayer("../../YARP/yaa2.wav");
            player.Play();
        }

        public void Nice()
        {
            SoundPlayer player = new SoundPlayer("../../YARP/nice.wav");
            player.Play();
        }

        // PRIVATE METHODS

        private void SovietAnthem()
        {
            //Console.Beep(385, 250);
            Console.Beep(392, 250);
            Console.Beep(523, 375);
            Console.Beep(392, 375);
            Console.Beep(440, 250);
            Console.Beep(493, 375);
            Console.Beep(329, 250);
        }
    }
}
