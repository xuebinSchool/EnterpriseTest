using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace TheChemicalTouchPortal
{
    public partial class ElementDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string protonNum = Request.QueryString["id"];

                ElementBLL eleBLL = new ElementBLL();
                Element element = eleBLL.GetElement(int.Parse(protonNum));

                if(element == null)
                {
                    stateLabel.Text = "Error in finding Element details";
                }
                else
                {
                    protonNumberLabel.Text = element.ProtonNumber.ToString();
                    nameLabel.Text = element.Name;
                    chemicalSymbolLabel.Text = element.ChemicalSymbol;
                    atomicRadiusLabel.Text = element.AtomicRadius.ToString();
                    relativeAtomicMassLabel.Text = element.RelativeAtomicMass.ToString();
                    densityLabel.Text = element.Density.ToString();
                    isMetalRadioButtonList.SelectedValue= element.IsMetal.ToString();
                    boilingPointLabel.Text = element.BoilingPoint.ToString();
                    meltingPointLabel.Text = element.MeltingPoint.ToString();

                    descriptionTextBox.Text = element.Description;

                    if (element.MeltingPoint < 30)
                    {
                        stateLabel.Text = "Solid";
                    }
                    if(element.MeltingPoint == 30)
                    {
                        stateLabel.Text = "Liquid";
                    }
                    if (element.BoilingPoint < 30 && element.MeltingPoint> 30)
                    {
                        stateLabel.Text = "Liquid";
                    }
                    if(element.BoilingPoint == 30)
                    {
                        stateLabel.Text = "Liquid + Gas";
                    }
                    if(element.BoilingPoint > 30)
                    {
                        stateLabel.Text = "Gas";
                    }
                }

            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewElements.aspx");
        }
    }
}