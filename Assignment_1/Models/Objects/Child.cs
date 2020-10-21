using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Models {
public class Child : Person {

    public List<ChildInterest> ChildInterests { get; set; }
    public List<Pet> Pets { get; set; }

    public void Update(Child toUpdate) {
        base.Update(toUpdate);
        ChildInterests = toUpdate.ChildInterests;
        Pets = toUpdate.Pets;
    }

    // public override string ToString()
    // {
    //     return JsonSerializer.Serialize(this);
    // }

    public override string ToString()
    {
        return base.ToString() + String.Join(", ", ChildInterests) + " | "
               + "Pets: " + String.Join(", ", Pets);
    }
}
}