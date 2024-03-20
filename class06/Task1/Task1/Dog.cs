namespace Task1
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public string Color { get; set; }



        public string Eat()
        {
            return $"The dog with the name {Name} is now eating.";
        }

        public string Play()
        {
            return $"The dog with the name {Name} is now playing.";
        }

        public string ChaseTail()
        {
            return $"The dog with the name {Name} now chasing it's tail.";
        }
    }
}