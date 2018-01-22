using System;
namespace PlantFarm
{
    public enum PlantMood
    {
        Furious,
        Upset,
        Bored,
        Content,
        Happy
    };

    public enum ThirstLevel
    {
        Parched,
        Thirsty,
        Sated,
        Content
    };


    public abstract class Plant
    {
        
        protected Plant(string name, string type, PlantMood mood, ThirstLevel thirst)
        {
            Name = name;
            Type = type;
            Mood = mood;
            Thirst = thirst;
        }

        public string Name { get; private set; }
        public string Type { get; private set; }

        public PlantMood Mood { get; protected set; }
        public ThirstLevel Thirst { get; protected set; }

        public virtual PlantMood PlayMozartPlant()
        {
            var message = GetPlayMozartPlantMessage();
            if((int)this.Mood < 4)
            {
                Console.WriteLine(message);
                return this.Mood += 1;
            }

            Console.WriteLine(message);
            return this.Mood;
        }

        public abstract string GetPlayMozartPlantMessage();

        public virtual PlantMood IgnorePlant()
        {
            var message = GetIgnorePlantMessage();
            if ((int)this.Mood > 0)
            {
                Console.WriteLine(message);
                return this.Mood -= 1;
            }

            Console.WriteLine(message);
            return this.Mood;
        }

        public abstract string GetIgnorePlantMessage();

        public virtual PlantMood MovePlant()
        {
            var message = GetMovePlantMessage();
            if ((int)this.Mood > 0)
            {
                Console.WriteLine(message);
                return this.Mood -= 1;
            }

            Console.WriteLine(message);
            return this.Mood;
        }

        public abstract string GetMovePlantMessage();

        public virtual ThirstLevel WaterPlant()
        {
           
            if ((int)this.Thirst < 3)
            {
                Console.WriteLine(GetWaterPlantMessage());
                this.Thirst += 1;
                return this.Thirst;
            }

            Console.WriteLine(GetWaterPlantFailedMessage());
            return this.Thirst;
        }

        public abstract string GetWaterPlantMessage();
        public abstract string GetWaterPlantFailedMessage();

        public void UpdatePlant(ThirstLevel thirst) => Thirst = thirst;

        public void UpdatePlant(PlantMood mood) => Mood = mood;

        public void DisplayPlantInformation()
        {
            Console.WriteLine("\n\nName: {0}\n" +
                              "Type: {1}\n" +
                              "Mood: {2}\n" +
                              "Thirst Status: {3}\n",
                              Name, Type, Mood, Thirst);
        }


    }
}

