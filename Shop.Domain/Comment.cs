using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
  public class Comment : Entity
  {
    public string Value { get; set; }
    public User User { get; set; }
    public Item Item { get; set; } 
  }
}
