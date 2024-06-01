namespace solid_csharp.L;

// Implementamos la clase HeartSurgeon que hereda de Surgeon y sobreescribe el método PerformSurgery para comunicar que se está operando el corazón.
public class HeartSurgeon: Surgeon
{
    public override void PerformSurgery()
    {
        Console.WriteLine("Opera el corazón");
    }
}