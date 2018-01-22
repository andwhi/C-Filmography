using System;
namespace PlantFarm
{
    public class Input
    {
        public string GetString(string prompt)
        {
            Console.Write("{0}> ", prompt);
            return Console.ReadLine();
        }

        public int GetInt(string prompt)
        {
            Console.Write("{0}> ", prompt);
            return int.Parse(Console.ReadLine());
        }

        public int GetChoice(string prompt)
        {
            Console.Write("{0}> ", prompt);
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
    }
}