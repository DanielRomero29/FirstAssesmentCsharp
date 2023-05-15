namespace fruta{
    
    public abstract class Fruta
{
    public string Nombre { get; set; }

    public Fruta(string nombre)
    {
        Nombre = nombre;
    }

    public abstract string Descripcion();
}
}
