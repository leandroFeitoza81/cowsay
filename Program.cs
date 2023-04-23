using System.Text;

namespace App.Cowsay;

internal static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            if (args.Length == 0)
                throw new Exception("informe ao menos uma palavra como parametro.");
            
            var stringBuilder = new StringBuilder();
            foreach (var word in args)
            {
                stringBuilder.Append(word);
                stringBuilder.Append(' ');
            }

            Console.WriteLine(new string('=', stringBuilder.ToString().Length + 3));
            Console.Write("< ");
            Console.Write(stringBuilder.ToString());
            Console.WriteLine(">");
            Console.WriteLine(new string('=', stringBuilder.ToString().Length + 3));
            Console.WriteLine(CowBuilder().ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Muuuu!!!! The Cow find error: " + ex);
        }
    }

    private static StringBuilder CowBuilder()
    {
        var cowBuilder = new StringBuilder();

        cowBuilder.AppendLine($"{"\\",4}");
        cowBuilder.AppendLine($"{"\\",5}");
        cowBuilder.AppendLine($"{"^--^",10}");
        cowBuilder.AppendLine($"{"(oo) \\__________",22}");
        cowBuilder.AppendLine($"{"(__) \\          )\\/\\",26}");
        cowBuilder.AppendLine($"{"| |-----w |",22}");
        cowBuilder.AppendLine($"{"| |     | |",22}");

        return cowBuilder;
    }
}