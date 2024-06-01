using solid_csharp.D;
using solid_csharp.i;
using solid_csharp.L;
using solid_csharp.O;
using solid_csharp.O.prescription;
using solid_csharp.patient;
using solid_csharp.S;

namespace solid_csharp;

// El static de la clase Program es para que no sea necesario instanciar la clase para poder ejecutar el método Main. Esto es porque el método Main es el punto de entrada de la aplicación.
static class Program
{
    private static void Main(string[] arg)
    {
        // Aquí realizamos la aplicación del princio S de SOLID, que nos dice que una clase no debe ser forzada a implementar interfaces que no utiliza.
        PatientModel patientModel = new PatientModel("Javier Prades", 25, "gripe");
        Room room = new Room(404);
        RoomAssigment roomAssignments = new RoomAssigment(patientModel, room);
        
        roomAssignments.AssigRoom();
        
        // Aquí realizamos la aplicación del principio O de SOLID, que nos dice que una clase no debe depender de clases concretas, sino de abstracciones. Esto lo aplicamos en la clase PrescriptionPrinter, que no depende de la clase Medicament, sino de la interfaz IPrescription.
        Medicament medicament = new Medicament("Ibuprofeno", "Anti-inflamatorio");
        SimplePrescription simplePrescription = new SimplePrescription();
        DetailPrescription detailPrescription = new DetailPrescription();
        PrescriptionPrinter printer = new PrescriptionPrinter();
        
        printer.PrintPrescription(simplePrescription,medicament);
        printer.PrintPrescription(detailPrescription,medicament);
        
        // Aquí aplicamos el principio L de SOLID, que nos dice que las clases derivadas deben poder sustituirse por sus clases base. Esto lo aplicamos en la clase HeartSurgeon, que hereda de la clase Surgeon.
        HeartSurgeon heartSurgeon = new HeartSurgeon();
        heartSurgeon.PerformSurgery();
        
        // Aquí realizamos la aplicación del principio I de SOLID, que nos dice que una clase no debe depender de interfaces que no utiliza. Esto lo aplicamos en la clase HeartSurgeon, que implementa la interfaz ISurgeon, pero no implementa el método AdministerOral.
        Aspirina aspirine = new Aspirina();
        aspirine.AdministerOral();
        
        // Aquí realizamos la aplicación del principio D de SOLID, que nos dice que las clases de alto nivel no deben depender de las clases de bajo nivel, sino de abstracciones. Esto lo aplicamos en la clase Admissions, que no depende de la clase PatientModel, sino de la interfaz IPatient.
        Admissions admissions = new Admissions(patientModel);
        admissions.AdminPatient();
         
         

    }
    
}