using System.Text.Json;
using System.Text.Json.Serialization;

namespace Models
{
    public class ChildInterest
    {
        //What is in comment, we don't need yet
        public int ChildId { get; set; }
        // [JsonIgnore] public Child Child { get; set; }

        public string InterestId { get; set; }
        // [JsonIgnore] public Interest Interest { get; set; }

        // public override bool Equals(object? obj)
        // {
        //     ChildInterest ci = ((ChildInterest) obj);
        //     if (ci.Child.Equals(Child) && ci.Interest.Equals(Interest)) return true;
        //     return base.Equals(obj);
        // }

        // public override string ToString()
        // {
        //     return JsonSerializer.Serialize(this);
        // }

        public override string ToString()
        {
            return "Interests: " + InterestId + " | " + "Child ID: " + ChildId;
        }
        
        public void Update(ChildInterest toUpdate)
        {
            InterestId = toUpdate.InterestId;
        }
    }
}