namespace quizGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                ShowOptions();
                tecla = Console.ReadKey();
                Console.Clear();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        Topic1();
                        break;
                    case ConsoleKey.D2:
                        Topic2();
                        break;
                    case ConsoleKey.D3:
                        Topic3();
                        break;
                    case ConsoleKey.D4:
                        Topic4();
                        break;
                    case ConsoleKey.D5:
                        Topic5();
                        break;
                    case ConsoleKey.D6:
                        Topic6();
                        break;

                    default:
                        MsgNextScreen("ERROR. Press a key to go to the main meu");
                        break;

                }

            } while (tecla.Key != ConsoleKey.D0);
            
        }

        public static void ShowOptions()
        {
            Console.WriteLine("1 -- Topic1");
            Console.WriteLine("2 -- Topic2");
            Console.WriteLine("3 -- Topic3");
            Console.WriteLine("4 -- Topic4");
            Console.WriteLine("5 -- Topic5");
            Console.WriteLine("6 -- Topic6");
            Console.WriteLine("0 -- Exit");
        }

        public static void Topic1()
        {
            MsgNextScreen("Press a key to go to the main menu");
        }

        public static void Topic2()
        {
            MsgNextScreen("Press a key to go to the main menu");
        }

        public static void Topic3()
        {
            MsgNextScreen("Press a key to go to the main menu");
        }

        public static void Topic4()
        {
            MsgNextScreen("Press a key to go to the main menu");
        }

        public static void Topic5()
        {
            MsgNextScreen("Press a key to go to the main menu");
        }

        public static void Topic6()
        {
            MsgNextScreen("Press a key to go to the main menu");
        }

        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
