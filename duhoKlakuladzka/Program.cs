using System.Net.Security;

Console.WriteLine("Vítej v RGB kalkulačce");
Thread.Sleep(750);
Console.Clear();

Console.WriteLine("Výběr barev: \nGreen \nBlue \nDark Blue \nMagenta \nYellow \nDark Yellow \nCyan \nRed");
string barva = Console.ReadLine();
barva = barva.ToUpper();
int frekvence = 0;

#region Barvy
switch (barva)
{
    case "GREEN":
        frekvence = 69;
        Console.ForegroundColor = ConsoleColor.Green;
        goto Kalkulacka;
    case "BLUE":
        frekvence = 420;
        Console.ForegroundColor = ConsoleColor.Blue;
        goto Kalkulacka;
    case "DARK BLUE":
        frekvence = 360;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        goto Kalkulacka;
    case "MAGENTA":
        frekvence = 750;
        Console.ForegroundColor = ConsoleColor.Magenta;
        goto Kalkulacka;
    case "YELLOW":
        frekvence = 500;
        Console.ForegroundColor = ConsoleColor.Yellow;
        goto Kalkulacka;
    case "DARK YELLOW":
        frekvence = 225;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        goto Kalkulacka;
    case "CYAN":
        frekvence = 900;
        Console.ForegroundColor = ConsoleColor.Cyan;
        goto Kalkulacka;
    case "RED":
        frekvence = 189;
        Console.ForegroundColor = ConsoleColor.Red;
        goto Kalkulacka;
    default:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        goto Kalkulacka;
}
#endregion

Kalkulacka:
Console.Clear();

Console.WriteLine("Jaké bude první číslo?");
string cislo1txt = Console.ReadLine();
double cislo1n = Convert.ToInt32(cislo1txt);

Console.WriteLine("Jaké bude druhé číslo?");
string cislo2txt = Console.ReadLine();
double cislo2n = Convert.ToInt32(cislo2txt);

Console.WriteLine("Jakou chceš operaci?: + - * /");
string znaminko = Console.ReadLine();
double vysledek = 0;

#region Kalkulacka
switch (znaminko)
{
    case "+":
        vysledek = cislo1n + cislo2n;
        Console.WriteLine(vysledek);
        goto Beep;

    case "-":
        vysledek = cislo1n - cislo2n;
        Console.WriteLine(vysledek);
        goto Beep;

    case "*":
        vysledek = cislo1n * cislo2n;
        Console.WriteLine(vysledek);
        goto Beep;

    case "/":
        vysledek = cislo1n / cislo2n;
        Console.WriteLine(vysledek);
        goto Beep;
}
#endregion

Beep:
if (vysledek<0)
{
    Console.Beep(frekvence,200);
}
else if (vysledek>0)
{
    Console.Beep(frekvence, 200);
    Console.Beep(frekvence, 200);
    Console.Beep(frekvence, 200);
}