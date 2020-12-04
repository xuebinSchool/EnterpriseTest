using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace TheChemicalTouchPortal
{
    public partial class InsertElement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string error;
            ElementBLL eleELL = new ElementBLL();
            string image = "";

            if (elementImageFileUpload.HasFile)
            {
                image = "Images\\" + elementImageFileUpload.FileName;
            }

            string msg = eleELL.InsertElement(protonNumberTextBox.Text, nameTextBox.Text, chemicalSymbolTextBox.Text,
                atomicRadiusTextBox.Text, relativeAtomicMassTextBox.Text, densityTextBox.Text, isMetalRadioButtonList.SelectedValue,
                boilingPointTextBox.Text, meltingPointTextBox.Text, descriptionTextBox.Text, elementImageFileUpload.FileName);

            if(msg == "Insert Sucess")
            {
                string saveimg = Server.MapPath(" ") + "\\" + image;
                statusLabel.Text = msg.ToString();
                elementImageFileUpload.SaveAs(saveimg);
            }

            statusLabel.Text = msg;

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            protonNumberTextBox.Text = "";
            nameTextBox.Text = "";
            chemicalSymbolTextBox.Text = "";
            atomicRadiusTextBox.Text = "";
            relativeAtomicMassTextBox.Text = "";
            densityTextBox.Text = "";
            isMetalRadioButtonList.SelectedIndex = 0;
            boilingPointTextBox.Text = "";
            meltingPointTextBox.Text = "";
            descriptionTextBox.Text = "";
        }
    }
}