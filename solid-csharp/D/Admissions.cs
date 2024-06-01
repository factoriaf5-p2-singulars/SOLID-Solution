using solid_csharp.patient;

namespace solid_csharp.D;

// Forma mejorada
public class Admissions(IPatient patient)
{
    public void AdminPatient()
    {
        Console.WriteLine($"Añadiendo paciente {patient.GetDetails()}");
    }
}

// Forma en la que se hizo en clase
// public class Admissions
// {
//     private readonly IPatient _patient;
//     public Admissions(IPatient patient)
//     {
//         this._patient = patient;
//     }
//
//     public void AdminPatient()
//     {
//         Console.WriteLine($"Añadiendo paciente {_patient.GetDetails()}");
//     }
// }