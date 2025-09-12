namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            HandleMenuOption();
            Console.ResetColor();
        }

        public static void DrawScreen()
        {
            DrawLine();
            for (int lines = 0; lines <= 10; lines++)
                Console.WriteLine($"|{"",38}|");
            DrawLine();
        }

        public static void DrawLine()
        {
            Console.WriteLine($"+{"".PadLeft(38, '-')}+");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption()
        {
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                //case 1: Editor.Show(); break;
                //case 2: Viewer.Show(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}