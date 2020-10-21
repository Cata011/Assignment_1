using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Models {
public class Pet {
    
    public int ChildId { get; set; }
    public int Id { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Age { get; set; }

    // public override string ToString()
    // {
    //     return JsonSerializer.Serialize(this);
    // }
    
    public void Update(Pet toUpdate)
    {
        Species = toUpdate.Species;
        Name = toUpdate.Name;
        Age = toUpdate.Age;
    }

    public override string ToString()
    {
        return  "Id: " + Id + " | " + "Species: " + Species + " | " +
               "Name: " + Name + " | " + "Age: " + Age;
    }
}
}