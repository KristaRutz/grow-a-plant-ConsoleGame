using System;
using System.Collections.Generic;
using GreenHouse.Models;

public class Program
{

  public static Plant myPlant;

  public static void Main()
  {
    myPlant = new Plant();

    myPlant.DisplayLevels();
    // myPlant.DecreaseLevels();
    // myPlant.Water(3);
    // myPlant.Feed(1);
    // myPlant.GiveSunlight(-2);
    PrintMenu();
  }

  public static void PrintMenu()
  {
    Console.WriteLine("Press 1 to water, Press 2 to feed, Press 3 to give sunlight");
    int userInput = int.Parse(Console.ReadLine());
    if(userInput == 1) 
    {
      Console.WriteLine("How much Water?");
      int water = int.Parse(Console.ReadLine());
      myPlant.Water(water);
      if (myPlant.CheckLevels()){
        PrintMenu();
      }
      else
      {
        Main();
      }
    }
    else if(userInput == 2)
    {
      Console.WriteLine("How much Food?");
      int food = int.Parse(Console.ReadLine());
      myPlant.Feed(food);
      if (myPlant.CheckLevels()){
        PrintMenu();
      }
      else
      {
        Main();
      }
    }
    else if(userInput == 3)
    {
      Console.WriteLine("How much Sunlight?");
      int sunlight = int.Parse(Console.ReadLine());
      myPlant.GiveSunlight(sunlight);
      if (myPlant.CheckLevels()){
        PrintMenu();
      }
      else
      {
        Main();
      }
    }
    else {
      Console.WriteLine("Enter valid option.");
      PrintMenu();
    }
  }
}