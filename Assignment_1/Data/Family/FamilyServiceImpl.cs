using System.Collections.Generic;
using FileData;
using Models;

namespace Assignment_1.Data
{
    public class FamilyServiceImpl : IFamilyService
    {
        private FileContext _fileContext = new FileContext();
        private Family _cachedFamily = new Family();
        public IList<Family> GetAllFamilies()
        {
            return _fileContext.Families;
        }
        
        public void RemoveFamily(Family family)
        {
            _fileContext.Families.Remove(family);
            _fileContext.SaveChanges();
        }
        public Family GetCachedFamily()
        {
            return _cachedFamily;
        }
    }
}