using fruta;

namespace naranja
{
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
}