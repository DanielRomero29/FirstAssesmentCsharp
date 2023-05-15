using static System.Console;
using manzana;
using naranja;
using banana;

Clear();
Write("Ingrese el tipo de fruta (manzana, banana o naranja): ");
string? tipo = ReadLine();

fruta.Fruta? fruta = null;

Write($"Ingrese la variedad de la {tipo}: ");
switch (tipo!.ToLower())
{
    case "manzana":
        string? variedad = ReadLine();
        fruta = new Manzana("Manzana", variedad!);
        break;

    case "banana":
        string? madurez = ReadLine();
        fruta = new Banana("Banana", madurez!);
        break;

    case "naranja":
        string? dulzor = ReadLine();
        fruta = new Naranja("Naranja", dulzor!);
        break;

    default:
        WriteLine("Tipo de fruta no válido");
        break;
}

if (fruta != null)
{
    WriteLine(fruta.Descripcion());
}
Write("Entre cualquier tecla");
ReadKey();