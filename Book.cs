using System;

namespace BiblioInheritance
{
 class Book : Resource
 {
  
  public string Author
  {get; set; }

  public int PageCount
  {get; set; }
 

 public Book(string title, string author, string category, int pageCount) : base(title, category)
 {
  Author = author;
  PageCount = pageCount;
  }
  
 }
}