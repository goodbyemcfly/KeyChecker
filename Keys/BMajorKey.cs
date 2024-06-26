﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyChecker.Keys
{
    public class BMajorKey : IKeyChecker
    {
        public string KeyName { get; set; } = "B Major";
        public int KeySignatureSharps { get; set; } = 5;
        public int KeySignatureFlats { get; set; } = 0;
        public string Scale { get; set; } = "B, C#, D#, E, F#, G#, A#, B";
        public string OneChord { get; set; } = "I = B Major (B-D#-F#)";
        public string TwoChord { get; set; } = "ii = C# minor (C#-E-G#)";
        public string ThreeChord { get; set; } = "iii = D# minor (D#-F#-A#)";
        public string FourChord { get; set; } = "IV = E Major (E-G#-B)";
        public string FiveChord { get; set; } = "V = F# Major (F#-A#-C#)";
        public string SixChord { get; set; } = "vi = G# minor (G#-B-D#)";
        public string SevenChord { get; set; } = "vii* = A# diminished (A#-C#-E)";
        public string RelativeKey { get; set; } = "G# Minor";
        public string ParallelKey { get; set; } = "B Minor";
    }
}
