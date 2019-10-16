using System;
class Song
{
    string artistName;
    string songName;
    int minutes;
    int seconds;
    public string ArtistName
    {
        get
        {
            return artistName;
        }
        set
        {
            if (value.Length >= 3 && value.Length <= 20)
                artistName = value;
            else
                throw new InvalidArtistNameException();
        }
    }
    public string SongName
    {
        get
        {
            return songName;
        }
        set
        {
            if (value.Length >= 3 && value.Length <= 30)
                songName = value;
            else
                throw new InvalidSongNameException();
        }
    }
    public int Minutes
    {
        get
        {
            return minutes;
        }
        set
        {
            if (value >= 0 &&value<= 14)
                minutes = value;
            else
                throw new InvalidSongMinutesException();
        }
    }
    public int Seconds
    {
        get
        {
            return seconds;
        }
        set
        {
            if (value >= 0 &&value<= 59)
                seconds = value;
            else
                throw new InvalidSongSecondsException();
        }
    }
    string Length
    {
        get
        {
            return $"{Minutes}:{Seconds}";
        }
    }
    public Song(string artistName,string songName,string length)
    {
        ArtistName = artistName;
        SongName = songName;
        string[] tokens = length.Split(':');
        Minutes = int.Parse(tokens[0]);
        Seconds = int.Parse(tokens[1]);
    }
    public Song(string artistName,string songName,int minutes,int seconds):this(artistName,songName,$"{minutes}:{seconds}")
    {
        
    }    
}
