using task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Products
{
  public abstract class RewardItem : IGameItem
  {
    public void Open()
    {
      Console.WriteLine($"You found the following reward item -> {GetType().Name.ToUpper()} !");
    }
  }
}
