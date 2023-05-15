using fruta;

namespace banana
{
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
}

