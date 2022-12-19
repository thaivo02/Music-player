﻿namespace Muzic.Database.Entity
{
    public class Music
    {
        public int MusicId { get; set; }
        public string MusicName { get; set; }
        public long TimeEnd { get; set; }
        public string URL { get; set; }
        public string Thumbnail { get; set; }
        public string Artist { get; set; }
        public string Lyric { get; set; }
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Frequency { get; set; }
        public long Timestamp { get; set; }
        public bool IsFavorite { get; set; }
        public string Comment { get; set; }
        public double Rate { get; set; }
    }
}