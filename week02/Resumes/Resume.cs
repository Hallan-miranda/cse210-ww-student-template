

using System.Reflection.Metadata.Ecma335;

class Resume 
{
    private string _name;
    private List<Job> _jobs;


    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public string Name
    {
        get{return _name; }
        set{ _name = value; }
    }

    public List<Job> jobs
    {
        get{ return _jobs;}
    }

    public void Display() 
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach(var job in _jobs)
        {
            job.Display();
        }
    }

}   