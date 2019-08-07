using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise_Demo
{
    public class CompositePattern
    {

    }


        public abstract class BodyComponents
        {
        //add components
        public void add(BodyComponents newBodyComponent) {
        }
        //remove components
        public void remove(BodyComponents newBodycomponent)
            {
                throw new NotSupportedException("Copy function is not supported in this version");
            }
            //get components
            public BodyComponents getComponent(int componentIndex)
            {
                throw new NotSupportedException("Copy function is not supported in this version");
            }
            //get Exercise name
            public String getExerciseName()
            {
                throw new NotSupportedException("Copy function is not supported in this version");
            }
            //get Type of exercise name
            public String getTypeExerciseName()
            {
                throw new NotSupportedException("Copy function is not supported in this version");
            }
            public void getBodyList()
            {
                throw new NotSupportedException("Copy function is not supported in this version");
            }

        }

     

        public class BodyPart : BodyComponents
        {
            String bodyPart;
            // ArrayList of all the bodyparts and exercise
            ArrayList bodyComponents = new ArrayList();



            public BodyPart(String Bp)
            {
                bodyPart = Bp;
           
            ListOf_Exercises.exList2.add(getBodyPart());
          
        }
            public String getBodyPart()
            {
                return bodyPart;
            }

            public void add(BodyComponents newBodyComponent)
            {
                bodyComponents.Add(newBodyComponent);
            }
            public void remove(BodyComponents newBodyComponent)
            {
                bodyComponents.Remove(newBodyComponent);
            }

        }

        public class Exercise : BodyComponents
        {
            String ExerciseName;
            String ExerciseTypeName;

            public Exercise(String en, String etn)
            {
                
                ExerciseName = en;
                ExerciseTypeName = etn;

            ListOf_Exercises.exList2.add("      "+getExerciseName()+", "+getExerciseTypeName());
     
            }

            public String getExerciseName()
            {
                return ExerciseName;
            }
            public String getExerciseTypeName()
            {
                return ExerciseTypeName;
            }
        }

        public class WholeBody
        {
            BodyComponents bodyList;

            public WholeBody(BodyComponents bl)
            {
                bodyList = bl;
            }

          
        }

        public class testCompositePattern
        {

       
        }




    

}
