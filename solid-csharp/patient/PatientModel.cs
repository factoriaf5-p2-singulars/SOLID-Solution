namespace solid_csharp.patient;


// Forma mejorada
public class PatientModel(string name, int age, string disease) : IPatient
{
    public string Name => name;
    public int Age => age;
    public string Disease => disease;
    public string GetDetails()
    {
        return $"{name}, tiene {age} y tiene {disease} ";
    }
}

// Forma en la que hizo en clase
// public class PatientModel:IPatient
// {
//     private readonly string _name;
//     private readonly int _age;
//
//     public string Name => _name;
//     public int Age => _age;
//
//     public PatientModel(string name, int age)
//     {
//         this._name = name;
//         this._age = age;
//     }
//
//     public string GetDetails()
//     {
//         return $"{_name}, tiene {_age} y se enfermp ";
//     }
// }