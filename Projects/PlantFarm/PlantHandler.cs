using System;
using System.Collections.Generic;
namespace PlantFarm
{
    public class PlantHandler
    {
        private readonly List<Plant> plants = new List<Plant>();

        public string this[int i]
        {
            get => plants[i].Name;
        }

        public void AddPlant(Plant plant)
        {
            plants.Add(plant);
        }

        public int PlantCount()
        {
            return plants.Count;
        }

        public void Water(int index)
        {
            plants[index].UpdatePlant(plants[index].WaterPlant());
        }

        public void Ignore(int index)
        {
            plants[index].UpdatePlant(plants[index].IgnorePlant());
        }

        public void PlayMozart(int index)
        {
            plants[index].UpdatePlant(plants[index].PlayMozartPlant());
        }

        public void Move(int index)
        {
            plants[index].UpdatePlant(plants[index].MovePlant());
        }

        public void ShowData(int index)
        {
            plants[index].DisplayPlantInformation();
        }
    }
}
