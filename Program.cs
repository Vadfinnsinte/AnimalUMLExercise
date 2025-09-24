using AnimalUMLExercise.Animals;

namespace AnimalUMLExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            firstDog.Name = "Akira";
            firstDog.Age = 6;
            firstDog.Species = "Canine";
            firstDog.Breed = "Labrador";

            firstDog.MakeSound();

            Dog secondDog = new Dog(); 

            secondDog.Name = "Ghost";
            secondDog.Age = 3;
            secondDog.Species = "Canine";
            secondDog.Breed = "Husky";

            secondDog.MakeSound();

            Cat firstCat = new Cat();
            firstCat.Name = "Jerry";
            firstCat.Age = 2;
            firstCat.Species = "Feline";
            firstCat.IsIndoor = true;

            firstCat.MakeSound();

            Cat secondCat = new Cat();
            secondCat.Name = "Tom";
            secondDog.Age = 5;
            secondCat.Species = "Feline";
            secondCat.IsIndoor = false;

            secondCat.MakeSound();
        }
    }
}
