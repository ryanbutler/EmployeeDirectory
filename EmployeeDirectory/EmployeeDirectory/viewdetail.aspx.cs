using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDirectory
{
    public partial class viewdetail : System.Web.UI.Page
    {
        #region Declarations
        EmployeeDirectory ed = new EmployeeDirectory();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Guid myguid;
            if (Guid.TryParse(Request.QueryString["guid"].ToString(), out myguid))
            {
                GetData(myguid);
            }
            else
            {
                phNoViewDetail.Visible = true;
                phViewDetail.Visible = false;
            }

        }

        protected void GetData(Guid myguid)
        {
            phViewDetail.Visible = true;
            ed.GetEmployeesViewGuid(myguid);
            lblFName.Text = ed.fname.ToString();
            lblLName.Text = ed.lname.ToString();
            lblEmail.Text = ed.email.ToString();
        }

    }
}