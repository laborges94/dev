using System;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("===============");
            Replace(text);
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var newText = text.Replace("<br>", Environment.NewLine);
            newText = newText.Replace("<strong>", "");
            newText = newText.Replace("</strong>", "");
            newText = newText.Replace("<em>", "");
            newText = newText.Replace("</em>", "");
            newText = newText.Replace("<p>", "");
            newText = newText.Replace("</p>", "");

            Show(newText);
        }
    }
}