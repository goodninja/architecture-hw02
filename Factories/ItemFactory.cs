using task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Factories
{
  internal abstract class ItemFactory
  {
    public abstract IGameItem CreateItem();

    public void OpenReward()
    {
      CreateItem().Open();
    }

  }
}
