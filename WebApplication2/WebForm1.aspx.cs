using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void GetData()
        {
            studentDataContext s1 = new studentDataContext();
            GridView1.DataSource = s1.stds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (studentDataContext newcontext = new studentDataContext())
            {
                std s = new std
                {
                    name = "praveen",
                    mobile = 2154656552,
                    email = "bhdc@gmail.com"

                };
                newcontext.stds.InsertOnSubmit(s);
                newcontext.SubmitChanges();
            }
            GetData();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (studentDataContext newcontext = new studentDataContext())
            {
                std std1 = newcontext.stds.SingleOrDefault(a => a.id ==90);
                std1.mobile = 8374653789;
                newcontext.SubmitChanges();
            }
            GetData();


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (studentDataContext newcontext = new studentDataContext())
            {
                std std1 = newcontext.stds.SingleOrDefault(a => a.id == 90);
                newcontext.stds.DeleteOnSubmit(std1);
                newcontext.SubmitChanges();
            }
            GetData();

        }
    }
}