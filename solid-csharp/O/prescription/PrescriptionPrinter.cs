namespace solid_csharp.O.prescription;

// aqui se puede ver que la clase PrescriptionPrinter no depende de la clase Medicament, sino de la interfaz IPrescription, por lo que cumple con el principio de inversión de dependencias y con el principio de sustitución de Liskov.
public class PrescriptionPrinter
{
    public void PrintPrescription(IPrescription prescription, Medicament medicament)
    {
        Console.WriteLine(prescription.CreatePrescription(medicament));
    }
}