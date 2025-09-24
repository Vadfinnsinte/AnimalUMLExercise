namespace AnimalUMLExercise.Animals
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public override void MakeSound()
        {
            if (!string.Equals(Breed, "husky", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Woof!");

            }
            else
            {
                Console.WriteLine("Awoooo!");
            }
        }
    }
}
