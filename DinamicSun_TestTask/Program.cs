// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] MajorFruit = new string [] { "апельсин", "яблоко", "груша" };
string[] ColorFruit = new string[] { "жёлтый", "оранжевый", "зелёный" };
string[] AdditionalFruit = new string[] { "киви", "виноград" };
string[] ExoticFruit = new string[] { "ананас", "бананы" };
string[] Package = new string[] { "мешок ", "плетёная корзинка", "подарочная коробка" };

CalculateTask0(MajorFruit, ColorFruit, AdditionalFruit, ExoticFruit, Package);
CalculateTask1(MajorFruit, ColorFruit, AdditionalFruit, ExoticFruit, Package);


void CalculateTask0(string[] majorFruit, string[] colorFruit, string[] additionalFruit, string[] exoticFruit, string[] package) {
    int i, j, k, n, m;
    int countAll =0, countOptimal = 0;
    Console.WriteLine("Задача 0");
    for (i = 0; i < majorFruit.Length; i++)
        for (j = 0; j < colorFruit.Length; j++)
            for (k = 0; k < additionalFruit.Length; k++)
                for ( n = 0; n < exoticFruit.Length; n++)
                    for ( m = 0; m < package.Length; m++)
                    {
                        Console.WriteLine($"{++countAll}) {majorFruit[i]} {colorFruit[j]} {additionalFruit[k]} {exoticFruit[n]} {package[m]}"); ;
                    }

    Console.WriteLine($"Всего наборов:{countAll}");
    (i, j, k, n, m) = (0, 0, 0, 0, 0);
    string[] answer = new string[5];
    while (i < majorFruit.Length || j < colorFruit.Length || k < additionalFruit.Length || n < exoticFruit.Length || m < package.Length) 
    {
        answer[0] = i < majorFruit.Length ? majorFruit[i++] : "любой";
        answer[1] = j < colorFruit.Length ? colorFruit[j++] : "любой";
        answer[2] = k < additionalFruit.Length ? additionalFruit[k++] : "любой";
        answer[3] = n < exoticFruit.Length ? exoticFruit[n++] : "любой";
        answer[4] = m < package.Length ?  package[m++] : "любой";
        Console.WriteLine($"{++countOptimal}) {string.Join(' ',answer)}");

    }
    Console.WriteLine($"Оптимальные наборы:{countOptimal}");
}

void CalculateTask1(string[] majorFruit, string[] colorFruit, string[] additionalFruit, string[] exoticFruit, string[] package)
{
    int i, j, k, n, m;
    int countAll = 0, countOptimal = 0;
    Console.WriteLine("Задача 1");
    for (i = 0; i < majorFruit.Length; i++)
        for (j = 0; j < colorFruit.Length; j++)
        {
            if (!(majorFruit[i]== "апельсин" && colorFruit[j]== "жёлтый"))
                for (k = 0; k < additionalFruit.Length; k++)
                    for (n = 0; n < exoticFruit.Length; n++)
                        for (m = 0; m < package.Length; m++)
                        {
                            Console.WriteLine($"{++countAll}) {majorFruit[i]} {colorFruit[j]} {additionalFruit[k]} {exoticFruit[n]} {package[m]}"); ;
                        }
        }
            

    Console.WriteLine($"Всего наборов:{countAll}");
    (i, j, k, n, m) = (0, 0, 0, 0, 0);
    string[] answer = new string[5];
    List<string> usedColor = new List<string>(3);
        while (i < majorFruit.Length || usedColor.Count() < 3 || k < additionalFruit.Length || n < exoticFruit.Length || m < package.Length)
    {
        answer[0] = i < majorFruit.Length ? majorFruit[i++] : "любой";
       if (usedColor.Count() < 3)
        {
            if (answer[0] == "апельсин")
            {
                answer[1] = colorFruit.First(x => (x != "жёлтый") && (!usedColor.Contains(x)));
                usedColor.Add(answer[1]);
            }
            else {
                answer[1] = colorFruit.First(x => !usedColor.Contains(x));
                usedColor.Add(answer[1]);
            }
        } else
        {
            answer[1] = "any";
        }
            
        answer[2] = k < additionalFruit.Length ? additionalFruit[k++] : "любой";
        answer[3] = n < exoticFruit.Length ? exoticFruit[n++] : "любой";
        answer[4] = m < package.Length ? package[m++] : "любой";
        Console.WriteLine($"{++countOptimal}) {string.Join(' ', answer)}");

    }
    Console.WriteLine($"Оптимальные наборы:{countOptimal}");
}
Console.ReadLine();


