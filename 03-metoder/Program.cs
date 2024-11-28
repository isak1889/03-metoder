// static void Hello32()
// {
//     for (int i = 0; i < 32; i++)
//     {
//         Console.WriteLine($"Hello World!" + i);
//     }

// }

// Hello32();

// static void kvadrat()
// {   
//     Console.WriteLine("Skriv ett tal som ska kvadratiseras");
//     string nummer = Console.ReadLine();
//     int tal;
//     int.TryParse(nummer, out tal);

//     int square = tal * tal;

//     Console.WriteLine($"Det blir {square}");
// }

// kvadrat();


// static void Multi()
// {
//     double a = 5;
//     double b = 5;
//     Console.WriteLine(a * b);
// }

// Multi();


// static void RightTriangleArea()
// {
//     double kateder1 = 5;
//     double kateder2 = 3;

//     Console.WriteLine($"Arean är {(kateder1 * kateder2)/2}");
// }

// RightTriangleArea();

// static float RightTriangleArea()
// {
//     float result = 5f*3f/2f;
//     return result;

// } 

// float f = RightTriangleArea();
// Console.WriteLine(f);

// static void CircleArea()
// {
//     double radie = 3;

//     Console.WriteLine($"Arean är {radie*radie*3.14}");
// }

// CircleArea();

// static int GetNumberInput()
// {
//     string tal;
//     int result;
//     while (true)
//     {
//         Console.WriteLine("Skriv ett nummer");
//         tal = Console.ReadLine();
        
//         if (int.TryParse(tal, out result))
//         {   
//             return result;

//         }

//         else
//         {
//             Console.WriteLine("Inte ett nummer");
//         }
        
//     }
    

// }
// GetNumberInput();


static int GetChoice (string a, string b, string c)
{   
    while(true)
    {
        Console.WriteLine("Välj mellan ett av alternativen");
        Console.WriteLine (a);
        Console.WriteLine (b);
        Console.WriteLine (c);

        string val = Console.ReadLine();

        if (val == "1" || val == "2" || val == "3")
        {
            return int.Parse(val);
        }

        else
        {
            Console.WriteLine ("välj ett alternativ");
        }

    
    }
    
}

GetChoice ("hus", "bil", "pengar");


Console.ReadLine();