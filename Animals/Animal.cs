namespace AnimalUMLExercise.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public abstract void MakeSound();

    }
}
