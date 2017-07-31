using System;

namespace factoryDesignPattern
{
    internal class Program
    {
        private abstract class Position
        {
            public abstract string Title { get; }
        }

        class Manager : Position
        {
            public override string Title => "Manager";
        }

        class Clerk : Position
        {
            public override string Title => "Clerk";
        }

        class Programmer : Position
        {
            public override string Title => "Programmer";
        }


        static class Factory
        {
            public static Position Get(int id)
            {
                switch (id)
                {
                    case 0:
                        return new Manager();
                    case 1:
                    case 2:
                        return new Clerk();
                    case 3:
                    default:
                        return new Programmer();
                }
            }
        }


        public static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                var position = Factory.Get(i);
                    Console.WriteLine("Where id = {0}, position = {1} ", i, position.Title);
            }
        }
    }
}