using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDirectory
{
    public partial class _default : System.Web.UI.Page
    {
        #region Declarations
        EmployeeDirectory ed = new EmployeeDirectory();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object s, EventArgs e)
        {
            //check if search has valid criteria
            if (IsValid)
            { 
                List<EmployeeDirectory> employees = ed.GetEmployeesView(txtName.Text);
                TogglePHVisibility();
                rpEmployeeSearchView.DataSource = employees;
                rpEmployeeSearchView.DataBind();
            }

        }

        protected void TogglePHVisibility()
        {
            phEmployeeSearch.Visible = true;
            phNoEmployeeFound.Visible = false;
        }

    }
}