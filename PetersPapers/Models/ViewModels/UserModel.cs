using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetersPapers.Models.ViewModels
{
    public class UserModel
    {
        public User user { get; set; }
        public UserModel(int Id)
        {
            using (PetersPapers_TestEntities db = new PetersPapers_TestEntities())
            {
                this.user = db.Users.Where(x => x.Id == Id).FirstOrDefault();
            }
        }
        public UserModel(string UserName)
        {
            using (PetersPapers_TestEntities db = new PetersPapers_TestEntities())
            {
                this.user = db.Users.Where(x => x.UserName == UserName).FirstOrDefault();
            }
        }

    }
}