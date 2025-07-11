// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to casino");
Console.Write("mate 1000 kc vsadte castku");
int vstup = int.Parse(Console.ReadLine());
Random rnd = new Random();
int a = rnd.Next (1,6);
int b = rnd.Next (1,6);
int c = rnd.Next (1,6);
Console.WriteLine($"cisla jsou : {a},{b},{c}");
int penezenka= 1000; 

string key
if (a == b && b == c)
key = "a"
else if (a == b)
key = "b"
else if (a == c)
key = "c"
else if (b == c)
key = "d"
else
key = "e"
 switch (key)
{
    case "a":
    vstup = vstup*0.5;
    case "b":
    vstup = vstup + 
    case "c":
    case "d":
    case "e":
}
        switch (key)
        {















            case "allEqual":
                Console.WriteLine("Všechna tři čísla jsou stejná.");
                break;
            case "aEqualsb":
                Console.WriteLine("Čísla a a b jsou stejná.");
                break;
            case "bEqualsc":
                Console.WriteLine("Čísla b a c jsou stejná.");
                break;
            case "aEqualsc":
                Console.WriteLine("Čísla a a c jsou stejná.");
                break;
            case "noneEqual":
                Console.WriteLine("Žádná čísla nejsou stejná.");
                break;