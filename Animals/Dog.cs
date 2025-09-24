namespace AnimalUMLExercise.Animals
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public void CreateDog(string name, string species, int age, string breed)
        {
            Name = name;
            Species = species;
            Age = age;
            Breed = breed;


        }
        public override void MakeSound()
        {
            if (!string.Equals(Breed, "husky", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{Name} says: Woof!");

            }
            else
            {
                Console.WriteLine($"{Name} says: Awoooo!");
            }
        }
    }
}
