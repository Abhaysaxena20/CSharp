using System.Diagnostics;

namespace WebApplication3
{
    public static class Bhang
    {
        public static void WhereAmI()
        {
            var stack = new StackTrace(true);
            Console.WriteLine("current location: ");
            Console.WriteLine(stack.ToString());
        }
    }
}
