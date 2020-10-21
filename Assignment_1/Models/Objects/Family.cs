using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
public class Family {
    
    //public int Id { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }
    public Family() {
        Adults = new List<Adult>();
        StreetName = "zzzzz"; //this thing here cries if it is not set to something
    }

    public override string ToString()
    {
        return Adults + " " + Children + " " + Pets + " " + HouseNumber + " " + StreetName;
    }
}
}