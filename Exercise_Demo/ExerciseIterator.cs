using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Demo
{
    public class ExerciseIterator: ICustomIterator
    {
        private List<String> _exercises = new List<String>();
        int position = 0;

        public ExerciseIterator(List<String> exercises)
        {
            _exercises = exercises;
        }

        public bool hasNext()
        {
            if (position < _exercises.Count)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Object next()
        {
            String s = _exercises[position];
            position++;
            return s;
        }

    }

    interface ICustomIterator
    {
        bool hasNext();
        object next();
    }

}

