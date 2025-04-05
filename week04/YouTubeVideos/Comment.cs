using System;

class Comment
{
    private string _name;
    private string _commentary;

    public Comment( string name, string commentary)
    {
        _name = name;
        _commentary = commentary;
    }


    public string GetCommentary()
    {
        return _name + "\n" + _commentary + "\n";
    }
}