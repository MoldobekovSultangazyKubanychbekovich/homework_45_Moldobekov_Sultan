using System.Text;

namespace homework_45_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string currentdir = "../../../site";
            Server_2 server = new Server_2(currentdir, 8888);
        }
    }
}