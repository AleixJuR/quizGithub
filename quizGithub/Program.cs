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
            Console.WriteLine("4 -- Geography");
            Console.WriteLine("5 -- Technology");
            Console.WriteLine("6 -- Famous_Personalities");
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

        public static void Geography()
        {
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.B, ConsoleKey.B, ConsoleKey.A, ConsoleKey.C, ConsoleKey.D }; // These ones are the correct.
            string[] preguntes = {
                "What is the capital city of Japan",
                "Which river is the longest in the world?",
                "What is the largest desert in the world?",
                "Which mountain range stretches across the northern border of India?",
                "What is the largest ocean in the world?"
            };
            string[,] respostes = {
                { "A) Beijing", "B) Tokyo", "C) Seoul", "D) Bangkok" },
                { "A) Amazon river", "B) Nile river", "C) Mississippi river", "D) Yangtze river" },
                { "A) Sahara desert", "B) Gobi desert", "C) Arabian desert", "D) Kalahati desert" },
                { "A) Alps", "B) Andes", "C) Himalaya", "D) Rocky mountains" },
                { "A) Indian Ocean", "B) Atlantic ocean", "C) Southern Ocean", "D) Pacific Ocean"},
            };
            bool validAnswer = false;
            int encerts = 0;

            for (int i = 0; i < correctes.Length; i++)
            {
                while (!validAnswer)
                {
                    try
                    {
                        Console.WriteLine($"Question {i + 1} --> {preguntes[i]}");
                        for (int y = 0; y < respostes.GetLength(1); y++)
                        {
                            Console.WriteLine(respostes[i, y]);
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
            MsgNextScreen("Press any key to go to the main menu");
        }

        public static void Technology()
        {
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.A, ConsoleKey.A, ConsoleKey.B, ConsoleKey.B, ConsoleKey.C };
            string[] preguntes = {
                "Who is the CEO of Tesla, Inc.?",
                "What does CPU stand for in computing?",
                "Which company developed the Windows operating system?",
                "What is the programming language used to develop Android apps?",
                "Which social media platform was founded by Mark Zuckerberg?"
            };
            string[,] respostes = {
                { "A) Beijing", "B) Tokyo", "C) Seoul", "D) Bangkok" },
                { "A) Beijing", "B) Tokyo", "C) Seoul", "D) Bangkok" },
                { "A) Beijing", "B) Tokyo", "C) Seoul", "D) Bangkok" },
                { "A) Beijing", "B) Tokyo", "C) Seoul", "D) Bangkok" },
                { "A) Beijing", "B) Tokyo", "C) Seoul", "D) Bangkok" },
            };
            bool validAnswer = false;
            int encerts = 0;

            for (int i = 0; i < correctes.Length; i++)
            {
                while (!validAnswer)
                {
                    try
                    {
                        Console.WriteLine($"Question {i + 1} --> {preguntes[i]}");
                        for (int y = 0; y < respostes.GetLength(1); y++)
                        {
                            Console.WriteLine(respostes[i, y]);
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
            MsgNextScreen("Press any key to go to the main menu");

        }

        public static void Famous_Personalities()
        {
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.A, ConsoleKey.D, ConsoleKey.E, ConsoleKey.B, ConsoleKey.A };
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
                        Console.WriteLine($"Question {i + 1} --> {preguntes[i]}");
                        for (int y = 0; y < respostes.GetLength(1); y++)
                        {
                            Console.WriteLine(respostes[i, y]);
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
            MsgNextScreen("Press any key to go to the main menu");

        }
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
