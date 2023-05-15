## Escenario de Frutas: Código 10

Usted ha sido contratado para trabajar como `CSharp developer` en una empresa local de su ciudad.

El negocio central es la comercialización de frutas:

Usted iniciará un proyecto que incluirá la elaboración de `site` en Internet para la gestión de las frutas.

Las frutas que se comercializan son Manzanas, Bananas y Naranjas, pero próximamente se añadirán mas variedades a la comercialización según como vayan siendo cerrados acuerdos con los cultivadores más próximos.

Debe crear el proyecto de iniciación para comenzar a desarrollar en las siguientes jornadas toda la aplicación.

Hoy deberá entregar la validación de funcionalidad, con la jerarquía de clases, y con el funcionamiento de una aplicación de consola; incluyendo toda la información proporcionada en este documento. Y completarlas según las instrucciones recibidas.

- Jerarquía de clases

```
Frutas: manzana, banana, naranja.
```

``` CSharp
public abstract class Fruta
{
    public string Nombre { get; set; }

    public Fruta(string nombre)
    {
        Nombre = nombre;
    }

    public abstract string Descripcion();
}

public class Manzana : Fruta
{
    public string Variedad {get; set;}
    public Manzana(string nombre, string variedad) : base(nombre) {
        Variedad = variedad;
    }

    public override string Descripcion()
    {
        return  $"La fruta {Nombre} es de variedad {Variedad} Tiene un sabor dulce y es ideal para comer fresca o para hacer zumo.";
    }
}

public class Banana : Fruta
{
    public string Madurez {get; set;}
    public Banana(string nombre, string madurez) : base(nombre) {
        Madurez = madurez;
    }

    public override string Descripcion()
    {
        return $"Esta es una {Nombre} de madurez {Madurez}";
    }
}

public class Naranja : Fruta
{
    public string Dulzor {get; set;}
    public Naranja(string nombre,string dulzor) : base(nombre){ 
        Dulzor = dulzor;
    }

    public override string Descripcion()
    {
        return $"Esta es una {Nombre} de dulzor {Dulzor}" ;
    }
}
```

####  Aplicación principal

```python
Clear();
Write("Ingrese el tipo de fruta (manzana, banana o naranja): ");
string? tipo = ReadLine();

Fruta? fruta = null;

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
```





