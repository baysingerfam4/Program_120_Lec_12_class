using System.Xml.Linq;
using System.Xml.Resolvers;

namespace Program_120_Lec_12_class
{
    internal class Program
    {
        // Carla Baysinger
        // Programming120 Lecture 12 Classes
        // May 25th 2024

        // Created an array
        static Exercise[] exercises = new Exercise[5];
        static void Main(string[] args)
        {
            // called methods
            PreLoad();
            DisplayAllExercises();
            
             
        }//Main
        public static void PreLoad()
        {
            //Name of Exercise | Reps  | Weight |
            //Bench Press      |  10   |  135   |
            //Squats           |  12   |  185   |
            //Deadlift         |  8    |  225   |
            //Overhead Press   |  10   |   95   |
            //Bent Over Row    |  12   |  115   |

            //Populate the array with Exercise instance and have them hold the information from the table above
            exercises[0] = new Exercise("Bench Press", 10, 135);
            exercises[1] = new Exercise("Squats", 12, 185);
            exercises[2] = new Exercise("Deadlift", 8, 225);
            exercises[3] = new Exercise("Overhead Press", 10, 95);
            exercises[4] = new Exercise("Bent Over Row", 12, 115);
        }
        public static void DisplayExercise(Exercise exercise)
        { //This method should take a single exercise object and display the information for the exercise in the following format
          //Format: Name | Reps | Weight
            string formattedString = $"{exercise.Name} | {exercise.Reps} | {exercise.Weight}";
            Console.WriteLine(formattedString);
            

        }

        public static void DisplayAllExercises()
        { //Create a method that will loop through your Exercise array, call your DisplayExercise(Exercise) method, and then will print out all the information.
            Console.WriteLine("Name of Exercises - Reps - Weight");
            for (int i = 0; i < exercises.Length; i++)
            {
                Exercise currentExercise = exercises[i];
                DisplayExercise(currentExercise);
            }
        }
    }// Class
    // Create a class
    public class Exercise
    {
        // Fields
        public string Name;
        public int Reps;
        public double Weight;

        //Constructor
        // public ClassName (parameters) { code }
        
        public Exercise(string name, int rep, double weight) // Constructor with 3 parameters
        {
            // Field = parameter
            Name = name;
            Reps = rep;
            Weight = weight;
        }

        public Exercise()// Default constructor
        {
            Name = "No Exercise";
            Reps = -1;
            Weight = -1;
        }

        // Methods

    }// class Exercise

}// namespace
