using InstaSharper.Classes.Models;
using InstaSharper.Classes.ResponseWrappers;
using System;

namespace InstaSharper.Converters
{
    internal class InstaStoryFeedMediaConverter : IObjectConverter<InstaStoryFeedMedia, InstaStoryFeedMediaResponse>
    {
        public InstaStoryFeedMediaResponse SourceObject { get ; set ; }

        public InstaStoryFeedMedia Convert()
        {
            if (SourceObject == null) throw new ArgumentNullException($"{SourceObject}");

            return new InstaStoryFeedMedia
            {
                X        = SourceObject.X,
                Y        = SourceObject.Y,
                Z        = SourceObject.Z,
                Width    = SourceObject.Width,
                Height   = SourceObject.Height,
                IsHidden = SourceObject.IsHidden,
                IsPinned = SourceObject.IsPinned,
                MediaId  = SourceObject.MediaId,
                Rotation = SourceObject.Rotation
            };
        }
    }
}
