using NsfwSpyNS;

namespace ConsoleNSFW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            var uri = new Uri("https://raw.githubusercontent.com/d00ML0rDz/NsfwSpy/main/NsfwSpy.Test/Assets/flower.jpg");
            var nsfwSpy = new NsfwSpy();
            var result = nsfwSpy.ClassifyImage(uri);
            Console.WriteLine(result.Pornography);
            Console.WriteLine("Completed. Press any key to exit");
            Console.ReadKey();
        }
    }
}