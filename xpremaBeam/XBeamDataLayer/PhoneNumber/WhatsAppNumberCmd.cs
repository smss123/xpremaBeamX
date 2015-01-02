using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBeamDataLayer.PhoneNumber
{
    public class WhatsAppNumberCmd:DatabaseBase
    {
        public delegate void OnChange(object sender, string process, string msg);
        public event OnChange OnChangeValue;
        public WhatsAppNumberCmd()
        {

        }
        public bool AddNumber(WhatsAppNumber phone)
        {
            phone.SerialNumber = Guid.NewGuid();
            db.WhatsAppNumbers.InsertOnSubmit(phone);
            db.SubmitChanges();
            OnChangeValue(this,"Add","PhoneNumber Has Been Added");
            return true;
        }
        public bool EditNumber(WhatsAppNumber phone)
        {
            var q = db.WhatsAppNumbers.Where(p => p.ID == phone.ID).SingleOrDefault();
            q.ContactName = phone.ContactName;
            q.CountryID = phone.CountryID;
            q.CurrentStatus = phone.CurrentStatus;
            q.PhoneNumber = phone.PhoneNumber;
            db.SubmitChanges();
            OnChangeValue(this, "edit", "PhoneNumber Has Been Edit");
           
            return true;
        }
        public bool DeleteNumber(WhatsAppNumber phone)
        {
            var q = db.WhatsAppNumbers.Where(p => p.ID == phone.ID).SingleOrDefault();
            db.WhatsAppNumbers.DeleteOnSubmit(q);
            db.SubmitChanges();
            OnChangeValue(this, "Delete", "PhoneNumber Has Been Deleted");
           
            return true;
        }
        public List<WhatsAppNumber> GetAll()
        {
            return db.WhatsAppNumbers.ToList();
        }
    }
}
