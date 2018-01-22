using System;
using System.Collections.Generic;
namespace PlantFarm
{
    public class Menu
    {
        readonly Input input = new Input();
        readonly PlantHandler plantList = new PlantHandler();

        public void DisplayMainMenu()
        {
            DisplayTitle();
            Console.WriteLine("1 - Inspect a plant\n" +
                              "2 - Quit\n");
            
            MenuChoice(input.GetChoice("Enter choice"));
        }

        public void DisplayPlantTypeMenu()
        {
            DisplayTitle();
            Console.WriteLine("1 - Jade Plant\n" +
                              "2 - Aloe Vera Plant\n" +
                              "3 - Exit\n");
            
            PlantTypeChoice(input.GetChoice("Enter choice"));
        }

        public void DisplayPlantActionMenu(int plantIndex)
        {
            Console.WriteLine("1 - Water plant\n" +
                              "2 - Ignore plant\n" +
                              "3 - Play Mozart for plant\n" +
                              "4 - Move plant near sunlight\n" +
                              "5 - Main Menu");
            
            PlantActionChoice(input.GetChoice("Enter choice"), plantIndex);
                                
        }

        public void DisplayPlantInspectionMenu()
        {
            DisplayTitle();
            for (int i = 0; i < plantList.PlantCount(); i++)
            {
                Console.WriteLine("[{0}]{1}", (i + 1), plantList[i]);
                int choice = input.GetChoice("Enter number for plant");

                if (choice > 0 && choice <= plantList.PlantCount())
                {
                    plantList.ShowData(choice - 1);
                }

                DisplayPlantActionMenu(choice - 1);
                Console.ReadKey(true);
                DisplayMainMenu();
            }
        }
            private void DisplayTitle()
            {
                Console.Clear();
                Console.WriteLine("Virtual Plant");
            }

            private void MenuChoice(int choice)
            {
                switch(choice)
                {
                    case 1:
                        DisplayPlantTypeMenu();
                        PlantTypeChoice(input.GetChoice("Enter choice"));
                        break;

                    case 2:
                        DisplayPlantInspectionMenu();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("\n\nNot a valid selection. Press any key.");
                        Console.ReadKey(true);
                        DisplayMainMenu();
                        break;
                }
            }

            public void PlantTypeChoice(int choice)
            {
                switch(choice)
                {
                    case 1:
                    plantList.AddPlant(new Jade(input.GetString("\n\nName"), "jade", PlantMood.Content, ThirstLevel.Content));
                                                      
                        DisplayMainMenu();
                        break;

                    case 2:
                    plantList.AddPlant(new Aloe(input.GetString("\n\nName"), "aloe", PlantMood.Content, ThirstLevel.Content));
                                                              
                        break;
                    case 3:
                        DisplayMainMenu();
                        break;

                    default:
                        Console.Write("\n\nNot a valid selection. Press a key");
                        Console.ReadKey(true);
                        DisplayPlantTypeMenu();
                        break;
                                                                                                            
                }
            }

            private void PlantActionChoice(int choice, int plantIndex)
            {
                switch(choice)
                {
                    case 1:
                        plantList.Water(plantIndex);
                        DisplayPlantInspectionMenu();
                        break;

                    case 2:
                        plantList.Ignore(plantIndex);
                        DisplayPlantInspectionMenu();
                        break;

                    case 3:
                        plantList.PlayMozart(plantIndex);
                        DisplayPlantInspectionMenu();
                        break;

                    case 4:
                        plantList.Move(plantIndex);
                        DisplayPlantInspectionMenu();
                        break;

                    case 5:
                        DisplayMainMenu();
                        break;

                    default:
                        Console.Write("\n\nNot a valid selection. Press a key");
                        Console.ReadKey(true);
                        DisplayPlantTypeMenu();
                        break;
                }
            }
        }
    }

