using task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Factories
{
  internal class MiphrilFactory : ItemFactory
  {
    public override IGameItem CreateItem()
    {
      return new Miphril();
    }
  }
}
