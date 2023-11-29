using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
         {

        }

        private void GetData()
        {
            Company_DBDataContext c1 = new Company_DBDataContext();
            GridView1.DataSource = c1.Employees;
            GridView1.DataBind();
        }

        protected void btngetdata_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            using (Company_DBDataContext c1 = new Company_DBDataContext())
            {
                Employee emp1 = new Employee
                {

                    name = "Hellooooooooooooooo",
                    salary = 20000,
                    job = "Developer",
                    dname = "Developing"
                };
                 c1.Employees.InsertOnSubmit(emp1);
                c1.SubmitChanges();

            }
            GetData();
        }
          
        
        
    }
}