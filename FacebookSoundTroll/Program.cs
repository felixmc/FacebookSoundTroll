using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace FacebookSoundTroll
{
	class Program
	{
		private static readonly int MIN_INTERVAL = 10000;
		private static readonly int MAX_INTERVAL = 60000;

		static void Main(string[] args)
		{
			System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
			start.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

			Random random = new Random();
			SoundPlayer sound = new SoundPlayer( Properties.Resources.note1 );

			while (true)
			{
				int waitTime = random.Next(MIN_INTERVAL, MAX_INTERVAL + 1);
				Thread.Sleep(waitTime);
				sound.Play();
			}
		}
	}
}
