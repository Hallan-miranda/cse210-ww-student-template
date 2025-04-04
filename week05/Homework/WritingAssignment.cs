using System;

public class WritingAssigment : Assignment
{
    private string _title;

    public WritingAssigment(string _studentName, string _topic, string _title) : base(_studentName, _topic)
    {
        this._title = _title;
    }
    public string GetWritingInformation()
    {
        return _title;
    }
}