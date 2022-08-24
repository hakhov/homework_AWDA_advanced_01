namespace Library
{
    public class Human
    {
        internal protected string Name { get; private set; }
        internal protected int Age { get; private set; }

        internal protected int Id { get; private set; }

        public Human(string name, int age, int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public Human()
        {

        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Id:{Id} ");
        }

    }
}