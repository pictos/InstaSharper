using System;
using System.Collections.Generic;
using System.Text;

namespace InstaSharper.Classes.Models
{
    public class InstaStoryMediaBase
    {
        public double X        { get; set; }

        public double Y        { get; set; }

        public double Z        { get; set; }

        public double Width    { get; set; }

        public double Height   { get; set; }

        public double Rotation { get; set; }

        public long IsPinned   { get; set; }

        public long IsHidden   { get; set; }
    }
}
