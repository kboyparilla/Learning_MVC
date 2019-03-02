using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;
using Evolantis.Data.SqlClient;
using Evolantis.Data;
using Evolantis.Lib.Extensions;

namespace Application.BusinessLogic
{
    public class UsersProcessor
    {
        public static  List<UsersModel> ReadAll()
        {
            Database db = new Database(new Connection());

            List<UsersModel> lst = new List<UsersModel>();
            UsersModel user = null;

            try
            {
                string sql = "SELECT * FROM dbo.Users";
                db.ExecuteReader(sql);
                while (db.Reader.Read())
                {
                    user = new UsersModel
                    {
                        ID = db.Reader.GetValue<int>("ID"),
                        FirstName = db.Reader.GetValue("FirstName"),
                        MiddleName = db.Reader.GetValue("MiddleName"),
                        LastName = db.Reader.GetValue("LastName"),
                        Email = db.Reader.GetValue("Email"),
                        Contact = db.Reader.GetValue("ContactNumber"),
                        Username = db.Reader.GetValue("UserName"),
                        Status = db.Reader.GetValue("Status").AsInt() == 0 ? "active" : "inactive" 
                    };

                    lst.Add(user);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }

            return lst;
        }
    }
}
