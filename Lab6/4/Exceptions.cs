using System;
class InvalidSongException : Exception
{
    public InvalidSongException() : base("Invalid song.")
    {

    }
    public InvalidSongException(string message):base(message)
    {

    }
}

class InvalidArtistNameException : InvalidSongException
{
    public InvalidArtistNameException():base("Artist name should be between 3 and 20 symbols.")
    {
        
    }
    public InvalidArtistNameException(string message) : base(message)
    {

    }
}
class InvalidSongNameException : InvalidSongException
{
    public InvalidSongNameException() : base("Song name should be between 3 and 30 symbols.")
    {

    }
    public InvalidSongNameException(string message) : base(message)
    {

    }
}
class InvalidSongLengthException : InvalidSongException
{
    public InvalidSongLengthException() : base("Invalid song length.")
    {

    }
    public InvalidSongLengthException(string message) : base(message)
    {

    }
}

class InvalidSongMinutesException:InvalidSongLengthException
{
    public InvalidSongMinutesException() : base("Song minutes should be between 0 and 14.")
    {

    }
    public InvalidSongMinutesException(string message):base(message)
    {

    }
}
class InvalidSongSecondsException : InvalidSongLengthException
{
    public InvalidSongSecondsException() : base("Song seconds should be between 0 and 59.")
    {

    }
    public InvalidSongSecondsException(string message) : base(message)
    {

    }
}
