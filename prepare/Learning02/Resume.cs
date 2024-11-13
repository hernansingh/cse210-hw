public class Resume{
    public string _name;
    public List<Job> _listOfJobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _listOfJobs)
        {
            job.DisplayJobDetails();
        }
    }
}