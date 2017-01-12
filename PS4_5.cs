using System;
using System.Threading;
using System.Threading.Tasks;

namespace Platform
{
    class Objects
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Name { get; set; }
        public int High { get; set; }
    }
    class Player
    {
        public string Name { get; set; }
    }
    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int HP {get; set;}
        public char Name { get; set; }
    }

    class Program
    {
        const ConsoleColor HERO_COLOR = ConsoleColor.DarkMagenta;
        const ConsoleColor SHOOT_COLOR = ConsoleColor.Red;
        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.DarkCyan;
        const ConsoleColor LAND = ConsoleColor.DarkGreen;
        const ConsoleColor ZEMLYA = ConsoleColor.DarkYellow;
        const ConsoleColor CLOUD = ConsoleColor.White;
        const ConsoleColor KAMNI = ConsoleColor.DarkGray;
        const ConsoleColor ENEMY_COLOR = ConsoleColor.DarkRed;
        public static Coordinate Hero { get; set; }
        public static Coordinate HeroH { get; set; }
        public static Coordinate Shoot { get; set; }
        public static Enemy Maga { get; set; }
        public static Enemy Diafragma { get; set; }

        public static void music1()
        {
            Note[] Sax =
           {
        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.REST, Duration.QUARTERDOT),
        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.A5, Duration.SIXTEENTH),
        new Note(Tone.A5, Duration.SIXTEENTH),
        new Note(Tone.G5, Duration.SIXTEENTH),
        new Note(Tone.A5, Duration.EIGHTHDOT),

        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.REST, Duration.QUARTERDOT),
        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.A5, Duration.SIXTEENTH),
        new Note(Tone.A5, Duration.SIXTEENTH),
        new Note(Tone.G5, Duration.SIXTEENTH),
        new Note(Tone.A5, Duration.EIGHTHDOT),

        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.REST, Duration.QUARTER),
        new Note(Tone.C6, Duration.QUARTER),
        new Note(Tone.A5, Duration.EIGHTH),
        new Note(Tone.REST, Duration.EIGHTH),

        new Note(Tone.G5, Duration.QUARTER),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.REST, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        new Note(Tone.E5, Duration.EIGHTH),
        new Note(Tone.F5, Duration.EIGHTH),
        new Note(Tone.D5, Duration.EIGHTH),
        };

            Task.Run(() => Play(Sax));
        }

        public static void beg()
        {
            int h = 0;
            begin();
            music1();
            InitGame();
            Task tasks = Task.Factory.StartNew(dvish);
            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        h = 1;
                        Hero.Y++;
                        Thread.Sleep(200);
                        Hero.Y++;
                        Thread.Sleep(200);
                        Hero.Y++;
                        Thread.Sleep(200);
                        Hero.Y++;
                        Thread.Sleep(200);
                        Hero.Y--;
                        Thread.Sleep(200);
                        Hero.Y--;
                        Thread.Sleep(200);
                        Hero.Y--;
                        Thread.Sleep(200);
                        Hero.Y--;
                        h = 0;
                        break;
                }
            }
        }
    

        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 30);
            Console.CursorVisible = false;
            beg();

        }

        static void MoveHero(int x, int y)
        {
            Coordinate newHero = new Coordinate()
            {
                X = Hero.X + x,
                Y = Hero.Y + y
            };
            char chars = 'J';

            if (CanMove(newHero))
            {
                RemoveHero();

                Console.BackgroundColor = HERO_COLOR;
                Console.SetCursorPosition(newHero.X, newHero.Y);
                Console.Write(chars);

                Hero = newHero;
            }
        }

        static void RemoveHero()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.SetCursorPosition(Hero.X, Hero.Y);
            Console.Write(" ");
        }

        static void cur()
        {
            Console.SetCursorPosition(0, 0);
        }

        static void SHOOT(int x, int y)
        {
            int sh = (Console.WindowWidth / 8) + 1;
            Coordinate NewShoot = new Coordinate()
            {
                X = Hero.X+1,
                Y = Hero.Y
            };
            Shoot = NewShoot;
            char chars = '\u00A4';

            for (int s = sh; s < Console.WindowWidth-1; s++)
            {
                Shoot = NewShoot;
                NewShoot = new Coordinate()
                {
                    X = Shoot.X + x,
                    Y = Shoot.Y + y
                };
                Console.BackgroundColor = SHOOT_COLOR;
                Console.SetCursorPosition(NewShoot.X, NewShoot.Y);
                Console.Write(chars);
                Thread.Sleep(10);
                RemoveSHOOT();
            }
            RemoveSHOOT();
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.SetCursorPosition(Console.WindowWidth-1, Console.WindowHeight/2-1);
            Console.Write(" ");
            MoveHero(0, 0);
        }

        static void RemoveSHOOT()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.SetCursorPosition(Shoot.X, Shoot.Y);
            Console.Write(" ");
        }

        static bool CanMove(Coordinate c)
        {
            if (c.X < 0 || c.X >= Console.WindowWidth)
                return false;

            if (c.Y < 0 || c.Y >= Console.WindowHeight - 15)
                return false;
            return true;
        }

        static void SetBackgroundColor()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear();
        }

        static void InitGame()
        {
            SetBackgroundColor();
            LANDD();
            Hero = new Coordinate()
            {
                X = Console.WindowWidth / 8,
                Y = Console.WindowHeight - (Console.WindowHeight / 2 + 1)
            };
            Maga = new Enemy()
            {
                X = Console.WindowWidth -1,
                Y = 0
            };
            Shoot = new Coordinate()
            {
                X = 1,
                Y = 14
            };
            MoveHero(0, 0);
            {
                Coordinate arrT = new Coordinate
                {
                    X = (Console.WindowWidth / 2 + Console.WindowWidth / 3),
                    Y = (Console.WindowHeight / 2 + Console.WindowHeight / 3)
                };
                Console.BackgroundColor = KAMNI;
                Console.SetCursorPosition(arrT.X, arrT.Y);
                Console.WriteLine('\u00A0');
                arrT = new Coordinate
                {
                    X = (Console.WindowWidth / 4),
                    Y = (Console.WindowHeight * 2 / 3)
                };
                Console.BackgroundColor = KAMNI;
                Console.SetCursorPosition(arrT.X, arrT.Y);
                Console.WriteLine('\u00A0');
                arrT = new Coordinate
                {
                    X = (Console.WindowWidth / 2),
                    Y = (Console.WindowHeight * 7 / 8)
                };
                Console.BackgroundColor = KAMNI;
                Console.SetCursorPosition(arrT.X, arrT.Y);
                Console.WriteLine('\u00A0');
            }
        }

        protected static void Play(Note[] tune)
        {
            while (true)
            {
                foreach (Note n in tune)
                {
                    if (n.NoteTone == Tone.REST)
                        Thread.Sleep((int)n.NoteDuration);
                    else
                        Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
                }
            }

        }

        static void LANDD()
        {
            char char2 = '\u00A0';
            int[,] result = new int[Console.WindowWidth, Console.WindowHeight - (Console.WindowHeight / 2)];
            for (int i = 0; i < result.GetLength(1); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    Coordinate res = new Coordinate()
                    {
                        X = j,
                        Y = i + (Console.WindowHeight / 2)
                    };
                    if (i > 1)
                    {
                        Console.BackgroundColor = ZEMLYA;
                        Console.SetCursorPosition(res.X, res.Y);
                        Console.Write(char2);
                    }
                    if (i <= 1)
                    {
                        Console.BackgroundColor = LAND;
                        Console.SetCursorPosition(res.X, res.Y);
                        Console.Write(char2);
                    }
                }
            }
        }

        protected enum Tone
        {
            REST = 0,

            C3 = C4 / 2,
            C3sharp = C4sharp / 2,
            D3 = D4sharp / 2,
            D3sharp = D4sharp / 2,
            E3 = E4 / 2,
            F3 = F4 / 2,
            F3sharp = F4sharp / 2,
            G3 = G4 / 2,
            G3sharp = G4sharp / 2,
            A3 = A4 / 2,
            A3sharp = A4sharp / 2,
            B3 = B4 / 2,

            C4 = 262,
            C4sharp = 277,
            D4 = 294,
            D4sharp = 311,
            E4 = 330,
            F4 = 349,
            F4sharp = 370,
            G4 = 392,
            G4sharp = 415,
            A4 = 440,
            A4sharp = 466,
            B4 = 494,

            C5 = 262 * 2,
            C5sharp = 277 * 2,
            D5 = 294 * 2,
            D5sharp = 311 * 2,
            E5 = 330 * 2,
            F5 = 349 * 2,
            F5sharp = 370 * 2,
            G5 = 392 * 2,
            G5sharp = 415 * 2,
            A5 = 440 * 2,
            A5sharp = 466 * 2,
            B5 = 494 * 2,

            C6 = C5 * 2,
            C6sharp = C5sharp * 2,
            D6 = D5 * 2,
            D6sharp = D5sharp * 2,
            E6 = E5 * 2,
            F6 = F5 * 2,
            F6sharp = F5sharp * 2,
            G6 = G5 * 2,
            G6sharp = G5sharp * 2,
            A6 = A5 * 2,
            A6sharp = A5sharp * 2,
            B6 = B5 * 2,
        }

        protected enum Duration
        {
            WHOLE = 2100,
            HALF = WHOLE / 2,
            HALFDOT = HALF + QUARTER,
            HALF3 = WHOLE / 3,
            QUARTER = HALF / 2,
            QUARTERDOT = QUARTER + EIGHTH,
            QUARTER3 = HALF / 3,
            EIGHTH = QUARTER / 2,
            EIGHTHDOT = EIGHTH + SIXTEENTH,
            EIGHTH3 = QUARTER / 3,
            SIXTEENTH = EIGHTH / 2,
            SIXTEENTHDOT = SIXTEENTH + SIXTEENTH / 2,
            SIXTEENTH3 = EIGHTH / 3,
            THIRTYSECOND = SIXTEENTH / 2,
            THIRTYSECONDDOT = SIXTEENTH / 2 + THIRTYSECOND / 2,
        }

        protected struct Note
        {
            Tone toneVal;
            Duration durVal;

            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }


        public static void end()
        {
            Task.WaitAll();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < Console.WindowHeight * 2 / 4; i++)
                for (int j = 0; j < Console.WindowWidth * 2 / 4; j++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 4 + j, Console.WindowHeight / 4 + i);
                    Console.Write(" ");
                }
            Console.SetCursorPosition(Console.WindowWidth / 4 + 11, Console.WindowHeight / 4 + 2);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("You lose.");
            Console.SetCursorPosition(Console.WindowWidth / 4 + 4, Console.WindowHeight / 4 + 5);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Желаете начать заново?");
            Console.SetCursorPosition(Console.WindowWidth / 4 + 3, Console.WindowHeight / 4 + 9);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Enter чтобы начать заного");
            Console.SetCursorPosition(Console.WindowWidth / 4 + 6, Console.WindowHeight / 4 + 11);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Escape чтобы выйти");
            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        beg();
                        break;
                }
            }
        }


        public static void begin()
        {
            Console.Write("Loading");
            Thread.Sleep(500);
            Console.Write("..");
            Thread.Sleep(380);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine(" Инструкция:");
            Thread.Sleep(200);
            Console.WriteLine(" Прыжок - Клавиша ВВЕРХ или W");
            Thread.Sleep(200);
            Console.WriteLine(" Выстрел - Клавиша Q или NumPad 1");
            Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine(" Задача:");
            Thread.Sleep(200);
            Console.WriteLine(" Набрать как можно больше очков перепрыгивая препятствия,..");
            Console.WriteLine(" а также уничтожая врагов.");
            Console.WriteLine();
            Console.Write(" Нажмите клавишу для начала игры...");
        }
        
        public static void shootClear()
        {
            Shoot.X = 1;
            Shoot.Y = 1;
        }

        public static void dvish()
        {
            char chars = '\u00A4'; 
            char ch1 = '\u0040'; 
            char ch2 = 'J'; 
            int I = 0;
            cur();
            char[,] arr = new char[Console.WindowHeight / 2, Console.WindowWidth];
            for (int x = 0; x < Console.WindowWidth - 1; x++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        arr[i, j] = ' ';
                        if (i == Console.WindowHeight / 2 - 1 && j == Console.WindowWidth - x - 1)
                        {
                            if (i == Shoot.Y && j == Shoot.X)
                            {
                                x = Console.WindowWidth - 2;
                                break;
                            }
                            arr[i, Console.WindowWidth - x - 1] = ch1;
                            Console.BackgroundColor = ConsoleColor.White;
                            if (i == Hero.Y && j == Hero.X)
                            {
                                Console.Write(arr[i, j]);
                                x = Console.WindowWidth - 2;
                                j = arr.GetLength(1) - 1;
                                i = arr.GetLength(0) - 1;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                end();
                                break;
                            }
                        }
                        if (i == Hero.Y && j == Hero.X)
                        {
                            Console.BackgroundColor = HERO_COLOR;
                            arr[j, i] = 'j'; 
                        }
                        Console.Write(arr[i, j]);
                    }
                    Console.WriteLine();
                }
                cur();
            }
        }
    }
}