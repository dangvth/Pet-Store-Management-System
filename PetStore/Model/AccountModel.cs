using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStore;

namespace PetStore.Model
{
    class AccountModel
    {
        //declare variables
        PetStoreEntities db;
        List<PetStore.Account> acList;
        public AccountModel()
        {
            db = new PetStoreEntities();
        }

        public List<PetStore.Account> getAccount()
        {
            acList = new List<PetStore.Account>();
            acList = (from ac in db.Accounts select ac).ToList();
            return acList;
        }

        public void ChangePassword(string userName, string newPWD)
        {
            Account ac = db.Accounts.Where(p => p.ac_userName == userName).SingleOrDefault();
            ac.ac_pwd = MyUtil.Encrypt.SHA256_Encrypt(newPWD);
        }
    }
}
