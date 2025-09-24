namespace AnimalUMLExercise.Animals
{
    internal class Cat : Animal
    {
        public bool IsIndoor { get; set; }
        public override void MakeSound()
        {
            if (!IsIndoor)
            {
                Console.WriteLine("Let meee out right MEOOW!");

            }
            else
            {
                Console.WriteLine("Meow! "); 
            }
        }
    }
}
