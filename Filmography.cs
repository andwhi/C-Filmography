using System;
using System.Collections.Generic;

namespace Treehouse.PracticeSession
{

    class Filmography
    {
        List<Film> films;

        public Filmography() => films = new List<Film>();

        public bool AddFilm(string title, string year)
        {
            Film entry = new Film(title, year);
            Film result = FindFilm(title);

            if (result == null)
            {
                films.Add(entry);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveFilm(string title)
        {
            Film entry = FindFilm(title);

            if (entry != null)
            {
                films.Remove(entry);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListFilm(Action<Film> action)
        {
            films.ForEach(action); //what is this?
        }

        public bool IsEmpty()
        {
            return (films.Count == 0);
        }

        public Film FindFilm(string title)
        {
            Film entry = films.Find(
              delegate (Film a) {
                  return a.title == title;  // what is this?
        }
            );
            return entry;
        }
    }
}
