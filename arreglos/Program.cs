string[] edificio1 = new string[5];
for(int x=0; x<edificio1.Length; x++) {
    Console.WriteLine($"Ingrese nombre {x+1}:");
    edificio1[x] = Console.ReadLine();
}

for (int x = 0; x < edificio1.Length; x++) {
    Console.WriteLine(edificio1[x]);
}

Console.WriteLine();

string[] edificio2 = { "tu", "papas","hermano", "tio", "primo" };
foreach (string e in edificio2) {
    Console.WriteLine(e);
}

//Console.WriteLine(edificio1[5]);    //error por no existir

Console.WriteLine("A quien busca en edificio 2:");
string bus = Console.ReadLine().ToLower();
for (int x = 0; x < edificio2.Length; x++) {
    if (edificio2[x] == bus) {
        Console.WriteLine($"Está en el piso {x+1}");
        break;
    }
}

char d;
Console.WriteLine("Correcion 1002233");
Console.WriteLine("JUjalag");

