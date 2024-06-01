using solid_csharp.patient;

namespace solid_csharp.S;

// Forma mejorada
public class RoomAssigment(PatientModel patientModel, Room room)
{
    public void AssigRoom()
    {
        Console.WriteLine($"La habitación {room.RoomNumber} es para el paciente {patientModel.Name}");
    }
    
}

// Forma que se hizo en clase
// public class RoomAssigment
// {
//     private readonly PatientModel _patientModel;
//     private readonly Room _room;
//     
//     public RoomAssigment(PatientModel patientModel, Room room)
//     {
//         this._room = room;
//         this._patientModel = patientModel;
//     }
//
//     public void AssigRoom()
//     {
//         Console.WriteLine($"La habitación {_room.RoomNumber} es para el paciente {_patientModel.Name}");
//     }
//     
//     
// }