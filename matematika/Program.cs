string key ="pepa";
Console.WriteLine("Hello, World!");
Console.WriteLine("napiste heslo");
string a = Console.ReadLine();

if( a == key )
{
    Console.WriteLine("pro");
    Console.WriteLine("");
    Console.WriteLine("zvolte operaci");
    Console.WriteLine("porovnani (min) 1");
    Console.WriteLine("porovnani (max) 2");
    Console.WriteLine("zaokrouhleni 3");
    Console.WriteLine("umocneni 4");
    Console.WriteLine("odmocneni 5");
    Console.WriteLine("scitani");
    Console.WriteLine("scitani");
    Console.WriteLine("nasobeni");
    Console.WriteLine("deleni");

    int operace = int.Parse(Console.ReadLine());

      switch (operace)
      {
        case 1:
        Console.WriteLine("napiste cisla, ktera chcete porovnat");
        int g = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        Console.WriteLine("=" + Math.Min(g, h));
            break;
        case 2:
        Console.WriteLine("napiste cislo, ktera chcete porovnat");
        int v = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("=" + Math.Max(x, v));
        
            break;

        case 3:
        Console.WriteLine("napiste desetine cislo ktere chcete zaokrouhlit");
        decimal c1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("na kolik desetinnych mist");
        int c2 = int.Parse(Console.ReadLine());
        Console.WriteLine("=" + Math.Round(c1,c2)); 
   
            break;
        case 4:
        Console.WriteLine("napiste cislo ktere chcete umocnit.");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("na kolikatou to chcete umocnit");
        double e = double.Parse(Console.ReadLine());
        Console.WriteLine("=" + Math.Pow(d,e));
            break;
        case 5:
        Console.WriteLine("napiste cislo, ktere chcete odmocnit");
        double cb1 = double.Parse(Console.ReadLine());
        Console.WriteLine("na kolikatou to chcete odmocnit");
        double cb2 = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(cb1, cb2));
            break;
        default:
            Console.WriteLine("to nebylo na vyber");
            break;
      }
     
}
else
{
    Console.WriteLine("spatne heslo");
}