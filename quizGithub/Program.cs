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
                switch (tecla.Key) //This switch will choose the action with the topic we want
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
                        Geography();
                        break;
                    case ConsoleKey.D5:
                        Technology();
                        break;
                    case ConsoleKey.D6:
                        Famous_Personalities();
                        break;
                    case ConsoleKey.D7:
                        Formula1();
                        break;
                    case ConsoleKey.D8:
                        Cartoon();
                        break;
                    case ConsoleKey.D9:
                        Music();
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        MsgNextScreen("ERROR. Press a key to go to the main meu");
                        break;

                }

            } while (tecla.Key != ConsoleKey.D0); //When the user press 0 the program will stop
            
        }
        /// <summary>
        /// This action show on screen all the topics
        /// </summary>
        public static void ShowOptions()
        {


            Console.WriteLine("1 --  World History");
            Console.WriteLine("2 -- Science");
            Console.WriteLine("3 -- Literature");
            Console.WriteLine("4 -- Geography");
            Console.WriteLine("5 -- Technology");
            Console.WriteLine("6 -- Famous_Personalities");
            Console.WriteLine("7 -- Formula1");
            Console.WriteLine("8 -- Cartoon");
            Console.WriteLine("9 -- Music");
            Console.WriteLine("0 -- Exit");
        }
        

        
        public static void World_History()
        {
            ConsoleKeyInfo resposta = default(ConsoleKeyInfo);
            ConsoleKey[] correctes = { ConsoleKey.A, ConsoleKey.A, ConsoleKey.B,ConsoleKey.B,ConsoleKey.C}; //This variable saves the correct answers
            string[] preguntes = { //This array saves the questions
                "What year did World War I begin?",
                "Who was the first female Prime Minister of the United Kingdom?",
                "Which civilization built the famous Machu Picchu?",
                "Who was the first President of the United States?",
                "Which city was the capital of the Byzantine Empire?"
            };
            string[,] respostes = { //This matrix saves all the answers
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
                        Console.WriteLine($"Question {i + 1} --> {preguntes[i]}"); //Here it prints the questions
                        for (int y = 0; y<respostes.GetLength(1); y++)
                        { 
                            Console.WriteLine(respostes[i,y]); //Here it prints the 4 possible answers
                        }
                        resposta = Console.ReadKey(); //
                        Console.Clear();
                        if (resposta.Key != ConsoleKey.A && resposta.Key != ConsoleKey.B && resposta.Key != ConsoleKey.C && resposta.Key != ConsoleKey.D)
                            throw new Exception("Invalid Option"); //While we not press A/B/C/D the program will ask again

                        validAnswer = true;

                        if (resposta.Key == correctes[i])
                            {
                                encerts++; //If we have a correct answer, it will sum 1 
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

        public static void Formula1()
        {
            ConsoleKeyInfo response = default(ConsoleKeyInfo);
            ConsoleKey[] correctAnswers = { ConsoleKey.C, ConsoleKey.D, ConsoleKey.B, ConsoleKey.A, ConsoleKey.C };
            string[] questions = {
        "Who holds the record for the most Formula 1 World Championships?",
        "Which driver has the nickname 'The Flying Finn'?",
        "Who is the youngest Formula 1 World Champion?",
        "Who is the current CEO of Formula 1?",
        "Which circuit hosts the Monaco Grand Prix?",
    };
            string[,] answers = {
        { "A) Ayrton Senna", "B) Lewis Hamilton", "C) Michael Schumacher", "D) Juan Manuel Fangio" },
        { "A) Kimi Räikkönen", "B) Niki Lauda", "C) Fernando Alonso", "D) Mika Häkkinen" },
        { "A) Lewis Hamilton", "B) Sebastian Vettel", "C) Max Verstappen", "D) Emerson Fittipaldi" },
        { "A) Bernie Ecclestone", "B) Toto Wolff", "C) Stefano Domenicali", "D) Chase Carey" },
        { "A) Silverstone", "B) Spa-Francorchamps", "C) Monte Carlo", "D) Suzuka" },
    };
            bool validAnswer = false;
            int correctCount = 0; // Counts correct answers only

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                while (!validAnswer)
                {
                    try
                    {
                        Console.WriteLine($"Question {i + 1}: {questions[i]}");
                        for (int j = 0; j < answers.GetLength(1); j++)
                        {
                            Console.WriteLine(answers[i, j]);
                        }
                        response = Console.ReadKey();
                        Console.Clear();
                        if (response.Key != ConsoleKey.A && response.Key != ConsoleKey.B && response.Key != ConsoleKey.C && response.Key != ConsoleKey.D)
                            throw new Exception("Invalid Option");

                        validAnswer = true;

                        if (response.Key == correctAnswers[i])
                        {
                            correctCount++;
                            Console.WriteLine($"Correct! You have {correctCount} correct answers.");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                validAnswer = false;
            }
            Console.WriteLine($"You have finished the quiz with {correctCount} correct answers.");
            MsgNextScreen("Press any key to return to the main menu");
        }

        public static void Cartoon()
        {
            ConsoleKeyInfo response = default(ConsoleKeyInfo);
            ConsoleKey[] correctAnswers = { ConsoleKey.C, ConsoleKey.B, ConsoleKey.A, ConsoleKey.D, ConsoleKey.B };
            string[] questions = {
        "Who is the creator of 'The Simpsons'?",
        "Which series features characters named Homer, Marge, Bart, Lisa, and Maggie?",
        "Who voices the character SpongeBob SquarePants in the animated series?",
        "In 'Avatar: The Last Airbender', what element can Aang bend?",
        "Which series follows the adventures of a boy named Finn and his magical dog Jake?",
    };
            string[,] answers = {
        { "A) Matt Groening", "B) Seth MacFarlane", "C) Trey Parker", "D) Mike Judge" },
        { "A) Family Guy", "B) The Simpsons", "C) South Park", "D) Rick and Morty" },
        { "A) Tom Kenny", "B) Seth Green", "C) Dan Castellaneta", "D) Billy West" },
        { "A) Fire", "B) Earth", "C) Air", "D) Water" },
        { "A) Adventure Time", "B) Rick and Morty", "C) The Amazing World of Gumball", "D) Regular Show" },
    };
            bool validAnswer = false;
            int correctCount = 0; // Counts correct answers only

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                while (!validAnswer)
                {
                    try
                    {
                        Console.WriteLine($"Question {i + 1}: {questions[i]}");
                        for (int j = 0; j < answers.GetLength(1); j++)
                        {
                            Console.WriteLine(answers[i, j]);
                        }
                        response = Console.ReadKey();
                        Console.Clear();
                        if (response.Key != ConsoleKey.A && response.Key != ConsoleKey.B && response.Key != ConsoleKey.C && response.Key != ConsoleKey.D)
                            throw new Exception("Invalid Option");

                        validAnswer = true;

                        if (response.Key == correctAnswers[i])
                        {
                            correctCount++;
                            Console.WriteLine($"Correct! You have {correctCount} correct answers.");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                validAnswer = false;
            }
            Console.WriteLine($"You have finished the quiz with {correctCount} correct answers.");
            MsgNextScreen("Press any key to return to the main menu");
        }
        public static void Music()
        {
            ConsoleKeyInfo response = default(ConsoleKeyInfo);
            ConsoleKey[] correctAnswers = { ConsoleKey.A, ConsoleKey.C, ConsoleKey.D, ConsoleKey.B, ConsoleKey.C };
            string[] questions = {
        "Which artist released the album 'Reputation' in 2017?",
        "Who is known as the 'King of Pop'?",
        "Which band performed at the halftime show of Super Bowl LVI in 2022?",
        "Who won the 2021 MTV Video Music Award for Artist of the Year?",
        "Which song by Adele won the Grammy Award for Record of the Year in 2021?",
    };
            string[,] answers = {
        { "A) Taylor Swift", "B) Katy Perry", "C) Ariana Grande", "D) Beyoncé" },
        { "A) Prince", "B) Michael Jackson", "C) Elvis Presley", "D) David Bowie" },
        { "A) Coldplay", "B) Maroon 5", "C) Dr. Dre and Snoop Dogg", "D) The Weeknd" },
        { "A) Justin Bieber", "B) BTS", "C) Olivia Rodrigo", "D) Lil Nas X" },
        { "A) Hello", "B) Someone Like You", "C) Rolling in the Deep", "D) Skyfall" },
    };
            bool validAnswer = false;
            int correctCount = 0; // Counts correct answers only

            for (int i = 0; i < correctAnswers.Length; i++)
            {
                while (!validAnswer)
                {
                    try
                    {
                        Console.WriteLine($"Question {i + 1}: {questions[i]}");
                        for (int j = 0; j < answers.GetLength(1); j++)
                        {
                            Console.WriteLine(answers[i, j]);
                        }
                        response = Console.ReadKey();
                        Console.Clear();
                        if (response.Key != ConsoleKey.A && response.Key != ConsoleKey.B && response.Key != ConsoleKey.C && response.Key != ConsoleKey.D)
                            throw new Exception("Invalid Option");

                        validAnswer = true;

                        if (response.Key == correctAnswers[i])
                        {
                            correctCount++;
                            Console.WriteLine($"Correct! You have {correctCount} correct answers.");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                validAnswer = false;
            }
            Console.WriteLine($"You have finished the quiz with {correctCount} correct answers.");
            MsgNextScreen("Press any key to return to the main menu");
        }



        /// <summary>
        /// It shows a message and ask for pressing a key
        /// </summary>
        /// <param name="msg">The message it print</param>

        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
