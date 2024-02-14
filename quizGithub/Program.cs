namespace quizGithub
{
    internal class Program
    {
        static void Main(string[] args) //Here is were all is shown
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
                        Geography();
                        break;
                    case ConsoleKey.D5:
                        Technology();
                        break;
                    case ConsoleKey.D6:
                        Famous_Personalities();
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
            string[] preguntes = { // These are the questions which are gonna be seen by the user
                "Who is the CEO of Tesla, Inc.?",
                "What does CPU stand for in computing?",
                "Which company developed the Windows operating system?",
                "What is the programming language used to develop Android apps?",
                "Which social media platform was founded by Mark Zuckerberg?"
            };
            string[,] respostes = { //These are the possible answers
                { "A) Elon Musk", "B) Jeff Bezos", "C) Tim Cook", "D) Sundar Pichai" },
                { "A) Central processing unit", "B) Computer processing unit", "C) Central power unit", "D) Computer power unit" },
                { "A) Apple Inc.", "B) Microsoft corporation", "C) Google LLC", "D) IBM" },
                { "A) Swift", "B) Java", "C) C#", "D) Python" },
                { "A) Twitter", "B) Instagram", "C) Facebook", "D) Snapchat" },
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
            ConsoleKey[] correctes = { ConsoleKey.A, ConsoleKey.A, ConsoleKey.A, ConsoleKey.A, ConsoleKey.A };
            string[] preguntes = {
                "Who was the first woman to win a Nobel Prize?",
                "Who painted the famous artwork \"The Starry Night\"?",
                "Which scientist is credited with the theory of evolution by natural selection?",
                "Who was the first man to walk on the moon?",
                "Which famous physicist developed the theory of relativity?"
            };
            string[,] respostes = {
                { "A) Marie Curie", "B) Mother Teresa", "C) Amelia Earhart", "D) Florance Nightingale" },
                { "A) Vincent Van Gogh", "B) Pablo Picasso", "C) Leonardo da Vinci", "D) Claude Monet" },
                { "A) Charles Darwin", "B) Isaac Newton", "C) Galileo Galilei", "D) Albert Einstein" },
                { "A) Neil Armstrong", "B) Buzz Aldrin", "C) Yuri Gagarin", "D) Alan Shepard" },
                { "A) Albert Einstein", "B) Isaac Newton", "C) Nikola Tesla", "D)Stephen Hawking"},
            };
            bool validAnswer = false;
            int encerts = 0; // Conta tot els encerts, els que t'has equivocat no!

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
