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

            secondDog.CreateDog("Ghost", "Canine", 3, "Husky");
    
            secondDog.MakeSound();

            Cat firstCat = new Cat();
            firstCat.Name = "Jerry";
            firstCat.Species = "Feline";
            firstCat.Age = 2;
            firstCat.IsIndoor = true;

            firstCat.MakeSound();

            Cat secondCat = new Cat();
            secondCat.CreateCat(secondCat.Name = "Tom", secondCat.Species = "Feline", secondCat.Age = 5, secondCat.IsIndoor = false);
      
            secondCat.MakeSound();
        }
    }
}
