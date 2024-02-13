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
                        World_History();
                        break;
                    case ConsoleKey.D2:
                        Science();
                        break;
                    case ConsoleKey.D3:
                        Literature();
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
                    case ConsoleKey.D0:
                        break;
                    default:
                        MsgNextScreen("ERROR. Press a key to go to the main meu");
                        break;

                }

            } while (tecla.Key != ConsoleKey.D0);
            
        }

        public static void ShowOptions()
        {
            Console.WriteLine("1 --  World History");
            Console.WriteLine("2 -- Science");
            Console.WriteLine("3 -- Literature");
            Console.WriteLine("4 -- Topic4");
            Console.WriteLine("5 -- Topic5");
            Console.WriteLine("6 -- Topic6");
            Console.WriteLine("0 -- Exit");
        }

        public static void World_History()
        {
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.A, ConsoleKey.A, ConsoleKey.B,ConsoleKey.B,ConsoleKey.C};
            string[] preguntes = {
                "What year did World War I begin?",
                "Who was the first female Prime Minister of the United Kingdom?",
                "Which civilization built the famous Machu Picchu?",
                "Who was the first President of the United States?",
                "Which city was the capital of the Byzantine Empire?"
            };
            string[,] respostes = {
                { "A) 1914", "B) 1916", "C) 1918", "D) 1920" },
                { "A) Margaret Thatcher", "B) Angela Merkel", "C) Theresa May", "D) Indira Gandhi" },
                { "A) Aztecs", "B) Incas", "C) Mayans", "D) Egyptians" },
                { "A) Thomas Jefferson", "B) George Washington", "C) John Adams", "D) Abraham Lincoln" },
                { "A) Rome", "B) Athens", "C) Constantinople", "D) Alexandria"},
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
                        for (int y = 0; y<respostes.GetLength(1); y++)
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
            MsgNextScreen("Press any key to go to the main menu");
        }

        public static void Science()
        {
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.A, ConsoleKey.B, ConsoleKey.B, ConsoleKey.B, ConsoleKey.A };
            string[] preguntes = {
                "What is the chemical symbol for water?",
                "Who proposed the theory of relativity?",
                "What is the smallest bone in the human body?",
                "Which planet is known as the \"Red Planet\"?",
                "What is the process by which plants make their own food called?"
            };
            string[,] respostes = {
                { "A) H2O", "B) CO2", "C) O2", "D) NaCl" },
                { "A) Isaac Newton", "B) Albert Einstein", "C) Galileo Galilei", "D) Nikola Tesla" },
                { "A) Femur", "B) Stapes", "C) Tibia", "D) Ulna" },
                { "A) Venus", "B) Mars", "C) Jupiter", "D) Saturn" },
                { "A) Photosynthesis", "B) Respiration", "C) Fermentation", "D) Decomposition"},
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

        public static void Literature()
        {
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.B, ConsoleKey.D, ConsoleKey.B, ConsoleKey.A, ConsoleKey.C };
            string[] preguntes = {
                "Who wrote \"To Kill a Mockingbird\"?",
                "Which Shakespeare play features the characters Romeo and Juliet?",
                "What is the famous opening line of Charles Dickens' \"A Tale of Two Cities\"?",
                "Who wrote the novel \"1984\"?",
                "Which ancient epic poem tells the story of the Trojan War?"
            };
            string[,] respostes = {
                { "A) Mark Twain", "B) Harper Lee", "C) F. Scott Fitzgerald", "D) J.D. Salinger" },
                { "A) Macbeth", "B) Hamlet", "C) Othello", "D) Romeo and Juliet" },
                { "A) \"Call me Ishmael.\"", "B) \"It was the best of times, it was the worst of times.\"", "C) \"All happy families are alike; each unhappy family is unhappy in its own way.\"", "D) \"Happy families are all alike; every unhappy family is unhappy in its own way.\"" },
                { "A) George Orwell", "B) Aldous Huxley", "C) Ray Bradbury", "D) Ernest Hemingway" },
                { "A) The Aeneid", "B) The Odyssey", "C) The Iliad", "D) The Epic of Gilgamesh"},
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
