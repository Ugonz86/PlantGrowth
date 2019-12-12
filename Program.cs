using System;
using System.Collections.Generic;
using GrowPlant.Plant;

namespace PlantGrowth {

  public class Program
  {
      public static void Main()
      {
          Console.WriteLine("Do you want to play the Plant game?");
          string userPlay = Console.ReadLine();
           if ( userPlay == "y")
           {
               bool playing = true;
                    Plant newPlant = new Plant(100, 100, 100);
                    while (playing)
                    {
                        newPlant.Round();
                        if (newPlant.GetHunger() <= 0 || newPlant.GetThirst() <= 0 || newPlant.GetSunLight() <= 0)
                            {
                                playing = false;
                                Console.WriteLine("you suck at plants");
                                Main();
                            }

                    }
                            
                    }
                    else if (userPlay == "n")
                    {
                            return;                   
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid answer");
                        Main();
                    }
          
          
      }
  }
}