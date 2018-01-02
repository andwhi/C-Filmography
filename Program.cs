using System;
using System.Collections.Generic;

namespace Treehouse.PracticeSession
{
    class FilmPrompt      
    {
        Filmography filmography;

        public FilmPrompt()
        {
            filmography = new Filmography();
        }

        static void Main(string[] args) 
        {
            string choice = "";
            FilmPrompt prompt = new FilmPrompt();

            prompt.displayMenu();
            while (!choice.ToLower().Equals("quit"))
            {
                Console.WriteLine("Choice: ");
                choice = Console.ReadLine();
                prompt.performAction(choice);
            }
        }

        void displayMenu()
        {
            Console.WriteLine("Filmography Book");
            Console.WriteLine("================= ");
            Console.WriteLine("To see the list of films, enter 'list'.");
            Console.WriteLine("To add a film, enter 'add'.");
            Console.WriteLine("To remove a film, enter 'remove'.");
            Console.WriteLine("To search for a film, enter 'search'.");
            Console.WriteLine("To edit a film year, enter 'edit'.");
            Console.WriteLine("To quit, enter 'quit'.");
        }

        void performAction(string choice)
        {
            string title = "";
            string year = "";

            switch (choice.ToLower())
            {

                case "list":
                    if (filmography.IsEmpty())
                    {
                        Console.WriteLine("There are no films.");
                    }
                    else
                    {
                        Console.WriteLine("Films: ");
                        filmography.ListFilm(
                          delegate (Film a) {
                              Console.WriteLine("{0} - {1}", a.title, a.year);
                          }
                        );
                    }

                    break;

                case "add":
                    Console.WriteLine("Enter title: ");
                    title = Console.ReadLine();
                    Console.WriteLine("Enter year: ");
                    year = Console.ReadLine();
                    if (filmography.AddFilm(title, year))
                    {
                        Console.WriteLine("Film successfully added.");
                    }
                    else
                    {
                        Console.WriteLine("{0} already exists.", title);
                    }

                    break;

                case "remove":
                    Console.WriteLine("Enter title: ");
                    title = Console.ReadLine();
                    if (filmography.RemoveFilm(title))
                    {
                        Console.WriteLine("Film successfully removed.");
                    }
                    else
                    {
                        Console.WriteLine("{0} doesn't exist.", title);
                    }

                    break;

                case "edit":
                    Console.WriteLine("Enter title to edit: ");
                    title = Console.ReadLine();
                    Film entry = filmography.FindFilm(title);
                    if (entry == null) {
                        Console.WriteLine("Film could not be found.");
                    } else {
                        Console.WriteLine("Correct year: ");
                        entry.year = Console.ReadLine();
                        Console.WriteLine("Year updated for {0}", title);
                    }

                    break;
            }
        }
    }
}


