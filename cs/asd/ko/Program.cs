// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("zadejte věk");
int vek= int.TryParse(Console.ReadLine());
bool ano = int.TryParse(vek, out int x);
if(vek>0) {
    Console.WriteLine($"je ti {vek}" );
    }else {
        Console.WriteLine("neplatný vstup");
    }