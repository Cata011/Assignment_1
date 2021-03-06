using System.Text.Json;

namespace Models {
public class Adult : Person {
    public string JobTitle { get; set; }

    public override string ToString() {
        // return JsonSerializer.Serialize(this);

        return base.ToString() + "Job: " + JobTitle;   
    }
    public void Update(Adult toUpdate) {
        JobTitle = toUpdate.JobTitle;
        base.Update(toUpdate);
    }
}
}