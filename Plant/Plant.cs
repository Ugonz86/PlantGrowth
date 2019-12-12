using System;

namespace GrowPlant.Plant
{
  class Plant
  {
    private int _Hunger; 
    private int _Thirst; 
    private int _SunLight;

    public Plant(int hunger, int thirst, int sunLight)
        {
            _Hunger = hunger;
            _Thirst = thirst;
            _SunLight = sunLight;
        }
       
        public int GetHunger()
        {
            return _Hunger;
        }
        public int GetThirst()
        {
            return _Thirst;
        }
        public int GetSunLight()
        {
            return _SunLight;
        }

    public void Round()
    {
        Console.WriteLine("What would you like to do with your plant");
        Console.WriteLine("Give food: 'F' Give Water: 'W' Give sun light: 'S'");
        string input = Console.ReadLine().ToLower();
        switch(input)
        {
            case "f":
                _Hunger += 10;
                _Thirst -= 7;
                _SunLight -=4;
                Console.WriteLine("\n\n\nHunger: " + _Hunger + " Thirst: " + _Thirst + " Sunlight: " + _SunLight + "\n");
                break;
            case "w":
                _Hunger -= 2;
                _Thirst += 10;
                _SunLight -=7;
                Console.WriteLine("\n\n\nHunger: " + _Hunger + " Thirst: " + _Thirst + " Sunlight: " + _SunLight + "\n");
                break;
            case "s":
                _Hunger -= 6;
                _Thirst -= 9;
                _SunLight +=10;
                Console.WriteLine("\n\n\nHunger: " + _Hunger + " Thirst: " + _Thirst + " Sunlight: " + _SunLight + "\n");
                break;
            default:
                Console.WriteLine("Invalid Input");
                Round();
                break;
        }
    }

  }
}