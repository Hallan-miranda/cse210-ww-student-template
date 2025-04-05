using System;



class Video
{
    private string _title;
    private string _author;
    private int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetVideo()
    {
        return _title + " - " + _author + " - " + _length + " seconds";
    }
}