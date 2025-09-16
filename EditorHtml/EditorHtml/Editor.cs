using System;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("===========");
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new Models.FileModel();

            var exit = false;

            while (!exit)
            {
                var line = Console.ReadLine();

                if (line.ToUpper() == "ESC")
                {
                    exit = true;
                    Menu.Show();
                }
                else
                {
                    file.Content += line;
                    file.Content += Environment.NewLine;
                }
            }
        }
    }
}
