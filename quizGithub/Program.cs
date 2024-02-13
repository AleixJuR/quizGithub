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
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.A, ConsoleKey.D, ConsoleKey.E,ConsoleKey.B,ConsoleKey.A};
            string[] preguntes = {
                "Pregunta1",
                "Pregunta2",
                "Pregunta3",
                "Pregunta4",
                "Pregunta5"
            };
            string[,] respostes = {
                { "resposta1", "resposta2", "resposta3", "resposta4" },
                { "resposta1", "resposta2", "resposta3", "resposta4" },
                { "resposta1", "resposta2", "resposta3", "resposta4" },
                { "resposta1", "resposta2", "resposta3", "resposta4" },
                { "resposta1", "resposta2", "resposta3", "resposta4"},
            };
            bool validAnswer = false;
            int encerts = 0;
            
            for (int i = 0; i < correctes.Length; i++)
            {
                while (!validAnswer)
                {
                    try
                    {
                        Console.WriteLine($"Pregunta {i + 1} --> {preguntes[i]}");
                        for (int y = 0; i<respostes.GetLength(1); i++)
                        { 
                            Console.WriteLine(respostes[i,y]);
                        }
                        resposta = Console.ReadKey();
                        Console.Clear();
                        if (resposta.Key != ConsoleKey.A && resposta.Key != ConsoleKey.B && resposta.Key != ConsoleKey.C && resposta.Key != ConsoleKey.D)
                            throw new Exception("Invalid Option");

                        validAnswer = true;

                        if (resposta.Key == correctes[i])
                            {
                                encerts++;
                                Console.WriteLine($"Correct, you have {encerts} correct answers");
                            }

                        else Console.WriteLine("Incorrect Answer");
                        
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                }
                validAnswer = false;
            }
            Console.WriteLine($"You have finised the test with {encerts} correct answers");
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
