using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBeamDataLayer.PhoneNumber
{
  public  class CountryCmd:DatabaseBase
    {
        public delegate void OnChange(object sender, string process, string msg);
        public event OnChange OnChangeValue;
        public bool AddCounty(Country count)
        {
            db.Countries.InsertOnSubmit(count);
            db.SubmitChanges();
            OnChangeValue(this, "Add", "country Has Been Added");
            return true;
        }
        public bool EditNumber(Country count)
        {
            var q = db.Countries.Where(p => p.ID == count.ID).SingleOrDefault();
            q.CountryName = count.CountryName;
            db.SubmitChanges();
            OnChangeValue(this, "edit", "country Has Been Edit");

            return true;
        }
        public bool DeleteNumber(Country count)
        {
            var q = db.Countries.Where(p => p.ID == count.ID).SingleOrDefault();
            db.Countries.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnChangeValue(this, "Delete", "country Has Been Deleted");

            return true;
        }
        public List<Country> GetAll()
        {
            return db.Countries.ToList();
        }
    }
}
