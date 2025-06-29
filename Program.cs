Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine("--- Esperto Contra Sabido ---\n");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkRed;

Console.Write("Quantos alimentos serão distribuídos? ");
    int total = int.Parse(Console.ReadLine()!);

Console.ResetColor();

int picaPau = 0;
    int raposinha = 0;
    int contador = 1;

for (int i = 1; contador <= total; i++)
{
    Console.Write($"{i} para você. ");
    picaPau++;
    contador++;

    Console.Write("1");
    raposinha++;
    contador++;

    for (int j = 2; j <= i && contador <= total; j++)
    {
        Console.Write($", {j}");
        raposinha++;
        contador++;
    }

    Console.WriteLine(" para mim.");
}

Console.BackgroundColor = ConsoleColor.DarkGreen;

Console.WriteLine($"\nPica-pau recebeu {picaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");

Console.ResetColor();
