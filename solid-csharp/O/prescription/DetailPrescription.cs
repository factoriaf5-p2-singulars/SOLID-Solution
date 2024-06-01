namespace solid_csharp.O.prescription;

// el detail prescription es una clase que implementa la interfaz IPrescription y que tiene un método que retorna una prescripción detallada. Aquí se cumple el principio de segregación de interfaces ya que se implementa el método CreatePrescription de la interfaz IPrescription. 

public class DetailPrescription: IPrescription
{
    public string CreatePrescription(Medicament medicament)
    {
        return $"Detailed prescription for {medicament.Name}: {medicament.Description}";
    }
}