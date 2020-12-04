using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace TheChemicalTouchPortal
{
    public partial class ViewElements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvElements_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowNum = int.Parse(e.CommandArgument.ToString());

            GridViewRow grRow = gvElements.Rows[rowNum];
            string protonNum = grRow.Cells[0].Text;

            if(e.CommandName == "Select")
            {
                Response.Redirect(String.Format("ElementDetails.aspx?id={0}", protonNum));
            }
            else if(e.CommandName == "Delete")
            {
                ElementBLL deleteValue = new ElementBLL();
                int results = deleteValue.DeleteElement(int.Parse(protonNum));
                Response.Redirect("VoewElements.aspx");
            }
        }
    }
}