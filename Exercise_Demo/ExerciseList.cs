using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Demo
{
    public class ExerciseList
    {
        private List<String> exercises = new List<String>();

        public void add(String s)
        {
            if (exercises.Contains(s) == false)
            {
                exercises.Add(s);
            }
  
        }

        public String getItem(int index)
        {
            if (index < exercises.Count)
            {
                return exercises[index];
            } else
            {
                return null;
            }
        }

        public List<String> getAllExercises()
        {
            return exercises;
        }

        public bool isEmpty()
        {
            return (exercises.Count == 0);
        }

        public void clear()
        {
            exercises.Clear();
        }

        public bool contains(String s)
        {
            return exercises.Contains(s);
        }

        public void remove (String s)
        {
            exercises.Remove(s);
        }

        public ExerciseIterator createIterator()
        {
            return new ExerciseIterator(exercises);
        }
    }
}
