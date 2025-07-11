
        Random rnd = new Random();
        decimal penezenka = 1000m;

        Console.WriteLine("Vítej v kasinu!");
        Console.WriteLine($"Začínáš s {penezenka} Kč.");

        while (penezenka > 0)
        {
            Console.WriteLine($"\nZadej sázku (0 = konec hry):");
            string vstup = Console.ReadLine();

            if (!decimal.TryParse(vstup, out decimal sázka) || sázka < 0)
            {
                Console.WriteLine("Zadej platnou kladnou částku.");
                continue;
            }

            if (sázka == 0)
            {
                Console.WriteLine("Konec hry.");
                break;
            }

            if (sázka > penezenka)
            {
                Console.WriteLine("Nemáš dost peněz na tuto sázku.");
                continue;
            }

            // Generování tří náhodných čísel 1-3
            int[] cisla = new int[3];
            for (int i = 0; i < 3; i++)
            {
                cisla[i] = rnd.Next(1, 4);
            }

            Console.WriteLine($"Padlo: {cisla[0]}, {cisla[1]}, {cisla[2]}");

            // Vyhodnocení výsledku
            int vyhra = 0;
            if (cisla[0] == cisla[1] && cisla[1] == cisla[2])
            {
                vyhra = 10; // 3 stejná = 10× sázka
                Console.WriteLine("Tři stejná! Vyhráváš 10× sázku!");
            }
            else if (cisla[0] == cisla[1] || cisla[1] == cisla[2] || cisla[0] == cisla[2])
            {
                vyhra = 2; // 2 stejná = 2× sázka
                Console.WriteLine("Dvě stejná! Vyhráváš 2× sázku!");
            }
            else
            {
                vyhra = -1; // prohra
                Console.WriteLine("Žádná shoda, prohráváš sázku.");
            }

            if (vyhra > 0)
            {
                penezenka += sázka * vyhra;
            }
            else
            {
                penezenka -= sázka;
            }

            Console.WriteLine($"Aktuální zůstatek: {penezenka} Kč");

            if (penezenka <= 0)
            {
                Console.WriteLine("Došly ti peníze, hra končí.");
                break;
            }
        }

        Console.WriteLine("\nDíky za hraní, měj hezký den!");