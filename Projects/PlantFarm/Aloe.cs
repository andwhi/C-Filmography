using System;
namespace PlantFarm
{
      class Aloe : Plant
    {

        public Aloe(string name, string type, PlantMood mood, ThirstLevel thirst) :
        base(name, type, mood, thirst)
        {
        }

        public override string GetPlayMozartPlantMessage()
        {
            return "You played Mozart for the Aloe Plant!";
        }

        public override string GetIgnorePlantMessage()
        {
            return "You ignored the Aloe Plant!";
        }

        public override string GetWaterPlantMessage()
        {
            return "You watered the Aloe Plant!";
        }

        public override string GetMovePlantMessage()
        {
            return "You moved the Aloe Plant!";
        }

        public override string GetWaterPlantFailedMessage() => "You failed to water the Aloe plant!";

    }
}

