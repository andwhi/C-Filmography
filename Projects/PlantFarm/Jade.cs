using System;
namespace PlantFarm
{
     class Jade : Plant
    {
        public Jade(string name, string type, PlantMood mood, ThirstLevel thirst) :
        base(name, type, mood, thirst)
        {
           
        }

        public override string GetPlayMozartPlantMessage()
        {
            return "You played Mozart for the Jade Plant!";
        }

        public override string GetIgnorePlantMessage()
        {
            return "You ignored the Jade Plant!";
        }

        public override string GetWaterPlantMessage()
        {
            return "You watered the Jade Plant!";
        }

        public override string GetMovePlantMessage()
        {
            return "You moved the Jade Plant!";
        }

        public override string GetWaterPlantFailedMessage()
        {
            return "You failed to water Jade Plant!";
        }
    }
}
