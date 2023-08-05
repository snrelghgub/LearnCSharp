namespace LearnCSharp.Models
{
    internal class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public Animal(string? name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public virtual string AnimalSound()
        {
            return "makes (unknown) sounds!";
        }
    }

    internal class Dog : Animal
    {
        public Dog(string? name, int age, int weight) : base(name, age, weight) { }
        public override string AnimalSound()
        {
            return "barks!";
        }
    }

    internal class Cat : Animal
    {
        public Cat(string? name, int age, int weight) : base(name, age, weight) { }
        public override string AnimalSound()
        {
            return "meows!";
        }
    }
}
