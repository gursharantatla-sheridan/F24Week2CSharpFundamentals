namespace F24Week2CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int @float;

            double d = 5.5;
            float f = 5.5F;
            decimal m = 232.324M;

            int i = 44;
            long l = 456543L;

            var x = 34.4;

            Console.WriteLine(@"Hello\nWorld");


            int cars = 3, bikes = 5, trucks = 6;

            // string concatenation
            Console.WriteLine("I have " + cars + " cars, " + bikes + " bikes and " + trucks + " trucks");

            // string interpolation
            Console.WriteLine($"I have {cars} cars, {bikes} bikes and {trucks} trucks");


            string[] colors = { "Red", "Blue", "Yellow", "Green", "Pink" };

            foreach(var c in colors)
                Console.WriteLine($"{c,-10}" + "Hello");


            int p = 5;
            int q = p;
            p++;
            Console.WriteLine(p);
            Console.WriteLine(q);

            Console.WriteLine("\n\n");

            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);

            Circle c2 = c1;
            //Circle c2 = new Circle();
            Console.WriteLine(c2.radius);
            c2.radius = 30;
            Console.WriteLine(c1.radius);
        }
    }

    class Circle
    {
        public double radius;
    }
}
