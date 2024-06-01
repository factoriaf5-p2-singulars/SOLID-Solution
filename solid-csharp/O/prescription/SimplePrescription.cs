namespace solid_csharp.O.prescription;

// Aquí se cumple el principio de segregación de interfaces ya que se implementa el método CreatePrescription de la interfaz IPrescription.
public class SimplePrescription:IPrescription
{
    // el CreatePrescription retorna una prescripción simple, cumpliendo con el principio de segregación de interfaces. 
    public string CreatePrescription(Medicament medicament)
    {
        return $"Prescription for {medicament.Name}: {medicament.Description}";
    }
}