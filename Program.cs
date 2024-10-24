using System;

namespace BiblioInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Resource test = new Resource("Moby Dick", "Literature");

      test.GetInfo();

      test.UpdateStatus();

      Console.WriteLine(test.Status);

      Book code = new Book("Code: The Hidden Language of Computer Hardware and Software", "Charles Petzold", "Non-Fiction", 396);
      

      code.GetInfo();

      Periodical p = new Periodical("Wired", "Technology", "Monthly");

      p.UpdateStatus();

      Console.WriteLine(p.Status);

      Video v = new Video("Ex Machina", "Alex Garland", "Sci-Fi", 108, "On-Demand");

      v.GetInfo();
          
    }
  }
}