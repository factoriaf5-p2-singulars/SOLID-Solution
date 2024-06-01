namespace solid_csharp.O;

// la clase Medicament no tiene dependencias y tiene dos propiedades de solo lectura, por lo que cumple con el principio de inversión de dependencias. Esto es porque no depende de otras clases y no tiene dependencias. De esta forma cumple con el principio de inversión de dependencias, 
public class Medicament
{
    public string Name { get; }

    public string Description { get; }

    public Medicament(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }
}