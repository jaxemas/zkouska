Random rnd = new Random ();
int nahodneCislo = rnd.Next(1, 101);

int i = 0;
while ( i < 25 )

{
    Console.WriteLine("Napiste cislo od 1  do 100");
    int cislo = int.Parse(Console.ReadLine());
    i++;
if ( cislo == nahodneCislo )
{
    Console.WriteLine($"mas to spravne, pouzil jsi {i} pokusu. ");
    break;
}
else if (cislo > nahodneCislo )
{
    Console.WriteLine("cislo, ktere jste zadal je vetsi.");
}
else if (cislo< nahodneCislo )
{
    Console.WriteLine("cislo, ktere jste zadal je mensi.");
}
else
{
    Console.WriteLine("neco se pokazilo");
}
}