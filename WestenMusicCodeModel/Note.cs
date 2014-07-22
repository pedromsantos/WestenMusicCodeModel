using System;

namespace WestenMusicCodeModel
{
	public class Note
	{
		private NotePitch notePitch;

		private Octave octave;

		private const double A4Frequency = 440.0;

		private const int OctaveRange = 12;

		public Note(NotePitch notePitch, Octave octave = Octave.OneLine)
		{
			this.notePitch = notePitch;
			this.octave = octave;
		}

		public int Pitch
		{
			get
			{
				return (int)this.notePitch + (OctaveRange * (int)octave);
			}
		}

		public double Frequency
		{
			get
			{
				var a4Pitch = new Note(NotePitch.A).Pitch;

				var relativePitchToA4 = Pitch - a4Pitch;

				var power = (double)relativePitchToA4 / (double)OctaveRange;

				return Math.Pow(2.0, power) * A4Frequency;
			}
		}
	}
}

