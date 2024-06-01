using solid_csharp.i.Interface;

namespace solid_csharp.i;

// Implementamos la clase Aspirina que hereda de Oral e implementa la interfaz IOral para comunicar que se administra de forma oral.
public class Aspirina : Oral
{
    public void AdministerOral()
    {
        Console.WriteLine("La aspirina se administra de forma oral");
    }
}