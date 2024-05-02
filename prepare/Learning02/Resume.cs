public class Resume
{
    public string _name;

    // you have to launch your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //this is a loop for the job
        foreach (Job job in _jobs)
        {
            // This is the display method for each job
            job.Display();
        }
    }
}