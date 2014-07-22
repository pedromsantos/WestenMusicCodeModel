using NUnit.Framework;
using System;
using WestenMusicCodeModel;
using NUnit.Framework.SyntaxHelpers;

namespace WestenMusicCodeModelTests
{
	[TestFixture()]
	public class NoteTests
	{
		[TestCase(NotePitch.C, Octave.SubContra, 0)]
		[TestCase(NotePitch.C, Octave.Contra, 12)]
		[TestCase(NotePitch.C, Octave.Great, 24)]
		[TestCase(NotePitch.C, Octave.Small, 36)]
		[TestCase(NotePitch.C, Octave.OneLine, 48)]
		[TestCase(NotePitch.C, Octave.TwoLine, 60)]
		[TestCase(NotePitch.C, Octave.ThreeLine, 72)]
		[TestCase(NotePitch.C, Octave.FourLine, 84)]
		[TestCase(NotePitch.C, Octave.FiveLine, 96)]
		[TestCase(NotePitch.C, Octave.SixLine, 108)]
		[TestCase(NotePitch.A, Octave.OneLine, 57)]
		public void ShouldReturnExpectedPitchForNoteAtOctave(NotePitch notePitch, Octave octave, int expectedResult)
		{
			var note = new Note (notePitch, octave);

			Assert.That(note.Pitch, Is.EqualTo(expectedResult));
		}

		[TestCase(NotePitch.A, Octave.SubContra, 27.5000)]
		[TestCase(NotePitch.ASharp, Octave.Contra, 58.2705)]
		[TestCase(NotePitch.B, Octave.Contra, 123.471)]
		[TestCase(NotePitch.C, Octave.Small, 130.813)]
		[TestCase(NotePitch.CSharp, Octave.OneLine, 277.183)]
		[TestCase(NotePitch.D, Octave.TwoLine, 587.330)]
		[TestCase(NotePitch.DSharp, Octave.ThreeLine, 1244.51)]
		[TestCase(NotePitch.E, Octave.FourLine, 2637.02)]
		[TestCase(NotePitch.C, Octave.FiveLine, 4186.01)]
		public void ShouldReturnExpectedFrequencyForNoteAtOctave(NotePitch notePitch, Octave octave, float expectedResult)
		{
			var note = new Note (notePitch, octave);

			Assert.That(note.Frequency, Is.EqualTo(expectedResult).Within(0.001));
		}
	}
}
