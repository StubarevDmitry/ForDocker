

int a = 1;
int b = 1;

while (true)
{
    Console.WriteLine(a + b);
    Thread.Sleep(200);
}

namespace SimpleApp
{
    public class ForTest()
    {
        int a = 1;
        public static int plusOne(int a)
        {
            return a + 1;
        }
    }
}