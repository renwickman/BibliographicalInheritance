using System;

namespace BiblioInheritance
{
  class Video : Resource
  {
    public string Director
    {get; set; }

    public int RunTime
    {get; set; }

    public string MediaType
    {get; set; }

    public Video(string title, string director, string category, int runtime, string mediaType) : base(title, category){
      Director = director;
      RunTime = runtime;
      MediaType = mediaType;
    }

    public override void GetInfo(){
      Console.WriteLine($"Title: {Title} - Director: {Director} - Category: {Category} - RunTime: {RunTime} - MediaType: {MediaType}");
    }

    public override void UpdateStatus()
    {
    if (Status == "In-use")
        {
          Status = "Available";
        }
    }
  }
}