class Persona
{
    private int edad;
    private string nombre;
    private string telefono;

    public int Edad { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    public Persona(int old, string name, string phone)
    {
        edad = old;
        nombre = name;
        phone = telefono;
    }

}

internal class Program
{
    private static void Main(string[] args)
    {
        PersonaUno  = new Persona(16, "Dinael", "000-123-4561");
        Console.WriteLine(Persona);
    }

}