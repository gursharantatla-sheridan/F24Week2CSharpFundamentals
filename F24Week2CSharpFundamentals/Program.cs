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
        }
    }
}
