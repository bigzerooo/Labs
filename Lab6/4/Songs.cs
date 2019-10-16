using System;
using System.Collections.Generic;
class Songs
{
    List<Song> Playlist = new List<Song>();
    public string Length
    {
        get
        {
            int minutes=0, seconds=0,hours=0;
            for(int i=0;i<Playlist.Count;i++)
            {
                minutes += Playlist[i].Minutes;
                seconds += Playlist[i].Seconds;
            }
            while(seconds>=60)
            {
                seconds -= 60;
                minutes += 1;
            }
            while(minutes>=60)
            {
                minutes -= 60;
                hours += 1;
            }
            return $"{hours}h {minutes}m {seconds}s";
        }
    }
    public int Count
    {
        get
        {
            return Playlist.Count;
        }
    }
    public void Add(Song song)
    {
        Playlist.Add(song);
    }
    public void Remove(Song song)
    {
        Playlist.Remove(song);
    }
}