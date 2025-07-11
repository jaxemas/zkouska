// See https://aka.ms/new-console-template for more information
Console.WriteLine("dobrý den dámy a pánové!");
Console.WriteLine("napište číslo");
int číslo = int.Parse(Console.ReadLine());
if (číslo % 2 == 0) {
    Console.WriteLine ("sudé");
}
else 
{
    Console.WriteLine ("liché");
}