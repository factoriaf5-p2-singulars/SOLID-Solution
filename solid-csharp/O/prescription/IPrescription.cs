namespace solid_csharp.O.prescription;

// creamos una interfaz para la prescripción para que el CreatePrescription sea implementado por las clases que la implementen, esto es para que se cumpla el principio de sustitución de Liskov. Ya que si se implementa en una clase que no lo necesita, se estaría violando el principio de segregación de interfaces.
public interface IPrescription
{
    string CreatePrescription(Medicament medicament);
}