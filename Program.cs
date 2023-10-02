using task2;
using task2.Factories;
using task2.Products;


RewardItem adamanthine = new Adamanthine(); 
RewardItem bronze = new Bronze(); 
RewardItem dragonstone = new Dragonstone(); 
RewardItem gem = new Gem(); 
RewardItem gold = new Gold(); 
RewardItem miphril = new Miphril(); 
RewardItem silver = new Silver(); 

adamanthine.Open();
bronze.Open();
dragonstone.Open();
gem.Open();
gold.Open();
miphril.Open();
silver.Open();

Console.WriteLine($"\n\n{string.Join("", Enumerable.Repeat("*=*", 42))}\n");

List<ItemFactory> factories = new List<ItemFactory>()
{
  new AdamanthineFactory(),
  new AdamanthineFactory(),
  new AdamanthineFactory(),
  new BronzeFactory(),
  new BronzeFactory(),
  new BronzeFactory(),
  new BronzeFactory(),
  new BronzeFactory(),
  new BronzeFactory(),
  new BronzeFactory(),
  new DragonstoneFactory(),
  new GemFactory(),
  new GemFactory(),
  new GemFactory(),
  new GemFactory(),
  new GoldFactory(),
  new GoldFactory(),
  new GoldFactory(),
  new GoldFactory(),
  new MiphrilFactory(),
  new MiphrilFactory(),
  new SilverFactory(),
  new SilverFactory(),
  new SilverFactory(),
  new SilverFactory(),
  new SilverFactory(),
};

Random random = new Random();

foreach (var factory in factories)
{
  int index = random.Next(0, factories.Count());
  factories[index].OpenReward();
}