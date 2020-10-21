using System.Collections.Generic;
using Models;

namespace Assignment_1.Data
{
    public interface IFamilyService
    {
        IList<Family> GetAllFamilies();

        void RemoveFamily(Family family);
        Family GetCachedFamily();
    }
}