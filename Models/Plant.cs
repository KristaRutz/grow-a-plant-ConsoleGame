using System;


namespace GreenHouse.Models
{
  public class Plant 
  {
    public int Growth { get; set; }
    public int WaterLevel { get; set; }
    public int FoodLevel { get; set; }
    public int SunlightLevel { get; set; }
    public int TurnCounter { get; set; }

    public Plant ()
    {
      Growth = 0;
      WaterLevel = 5;
      FoodLevel = 5;
      SunlightLevel = 5;
      TurnCounter = 0;
    }

    public void DisplayLevels()
    {
      Console.WriteLine("Growth");
      Console.WriteLine(Growth);
      Console.WriteLine("WaterLevel");
      Console.WriteLine(WaterLevel);
      Console.WriteLine("FoodLevel");
      Console.WriteLine(FoodLevel);
      Console.WriteLine("SunlightLevel");
      Console.WriteLine(SunlightLevel);
    }

    public void DecreaseLevels()
    {
      TurnCounter++;
      if (TurnCounter % 2 == 0)
      {
        Storm();
      }
      if(TurnCounter % 3 == 0)
      {
        WaterLevel--;
        FoodLevel--;
        SunlightLevel--;
        Console.WriteLine("You lose resources as time goes by.");
        Console.WriteLine("You lost 1 sunlight, 1 food, and 1 water level.");
        DisplayLevels();
      }
      if (TurnCounter % 5 == 0)
      {
        AphidAttack();
      }
    }

    public void Water(int amount)
    {
      WaterLevel += amount;
      DisplayLevels();
      DecreaseLevels();
    }

    public void Feed(int food)
    {
      FoodLevel += food;
      DisplayLevels();
      DecreaseLevels();
    }

    public void GiveSunlight(int sunlight)
    {
      SunlightLevel += sunlight;
      DisplayLevels();
      DecreaseLevels();
    }

    public void Grow()
    {
      Growth++;
      Console.WriteLine("You grew!");
      if(Growth == 5)
      {
        Console.WriteLine("You're grown!");
      }
    }

    public bool CheckLevels()
    {
      if (WaterLevel < 3 || WaterLevel > 10 || FoodLevel < 3 || FoodLevel > 10 || SunlightLevel < 3 || SunlightLevel > 10) 
      {
        Console.WriteLine("You're dead!");
        return false;
      }
      else if (WaterLevel >= 5 && FoodLevel >= 5 && SunlightLevel >= 5)
      {
        Grow();
      } 
      return true;
    }

    public void AphidAttack()
    {
      Growth --;
      FoodLevel -= 2;
      Console.WriteLine("You got hit by an *Aphid Assault!*");
      Console.WriteLine("You shrunk and lost 2 food levels.");
    }

    public void Storm()
    {
      SunlightLevel -= 2;
      WaterLevel += 2;
      Console.WriteLine("You got hit by a *STORM*");
      Console.WriteLine("You lost 2 sunlight levels, but gained 2 water levels.");
    }
  }
}
