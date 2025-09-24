namespace AnimalUMLExercise.Animals
{
    internal class Cat : Animal
    {
        public bool IsIndoor { get; set; }
        public void CreateCat(string name, string species, int age, bool isIndoor)
        {
            Name = name;
            Species = species;
            Age = age;
            IsIndoor = isIndoor;


        }
        public override void MakeSound()
        {
            if (!IsIndoor)
            {
                Console.WriteLine($"{Name} says: Let meee out! MEOOW!");

            }
            else
            {
                Console.WriteLine($"{Name} says:Meow! "); 
            }
        }
    }
}
