using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BusinessLogicLayer
{
    public class ElementBLL
    {
        public Element GetElement(int protonNumber)
        {
            Element element = new Element();
            return element.GetElement(protonNumber);
        }
        public List<Element> GetAllElements()
        {
            Element element = new Element();
            return element.GetAllElements();
        }
        public string InsertElement(String protonNumber, String name, String chemicalSymbol, String atomicRadius, String relativeAtomicMass, String density, String metal, String boilingPoint, String meltingPoint, String description, String imageURL)
        {
            string[] concatName;
            string upperValue;
            string newChemicalSymobl;
            string result;

            //Start of Validaton HELL
            concatName = chemicalSymbol.Split();
            upperValue = concatName[0].ToUpper();

            if (concatName[0] != upperValue)
            {
                newChemicalSymobl = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(chemicalSymbol);
            }
            else
            {
                newChemicalSymobl = chemicalSymbol;
            }

            if (String.IsNullOrEmpty(atomicRadius))
            {
                atomicRadius = "0";
            }
            else {
                if ((float.TryParse(atomicRadius, out float iAtomicRadius) == false) || iAtomicRadius <= 0)
                {
                    result = "Atomic Value must be a number and more than 0";
                }
            }

            if (String.IsNullOrEmpty(relativeAtomicMass))
            {
                atomicRadius = "0";
            }
            else
            {
                if ((double.TryParse(relativeAtomicMass, out double drelativeAtomicMass) == false) || drelativeAtomicMass <= 0)
                {
                    result = "Relative Atomic Mass must be a number and more than 0";
                }
            }

            if (String.IsNullOrEmpty(density))
            {
                atomicRadius = "0";
            }
            else
            {
                if ((double.TryParse(density, out double dDensity) == false) || dDensity <= 0)
                {
                    result = "Density must be a number and more than 0";
                }
            }

            if (String.IsNullOrEmpty(boilingPoint))
            {
                boilingPoint = "0";
            }
            if (String.IsNullOrEmpty(meltingPoint))
            {
                meltingPoint = "0";
            }

            if(Double.TryParse(boilingPoint, out double dBoilingPoint))
            {
                if(Double.TryParse(meltingPoint, out double dMeltingPoint))
                {
                    if (dMeltingPoint > dBoilingPoint)
                    {
                        result = "Melting point is higher than boiling point";
                    }
                }
                else
                {
                    result = "Melting point is not a number";
                }
            }
            else
            {
                result = "Boiling point is not a number";
            }

            string validationValue = ValidateInput(protonNumber, name, chemicalSymbol, atomicRadius, relativeAtomicMass, density, metal, boilingPoint, meltingPoint, description, imageURL);

            if (String.IsNullOrEmpty(validationValue))
            {
                result = validationValue;
            }
            else
            {
                string insertError;
                Element element = new Element();

                element.ProtonNumber = int.Parse(protonNumber);
                element.Name = name;
                element.ChemicalSymbol = chemicalSymbol;
                element.AtomicRadius = int.Parse(atomicRadius);
                element.RelativeAtomicMass = double.Parse(relativeAtomicMass);
                element.Density = double.Parse(density);
                element.IsMetal = bool.Parse(metal);
                element.BoilingPoint = double.Parse(boilingPoint);
                element.MeltingPoint = double.Parse(meltingPoint);
                element.Description = description;
                element.ImageURL = imageURL;

                int endValue = element.Insert(out insertError);

                if (String.IsNullOrEmpty(insertError))
                {
                    result = insertError;
                }
                else
                {
                    result = "Insert Sucess";
                }
            }

            return result;
        }
        public int DeleteElement(int protonNumber)
        {
            Element element = new Element();

            int result = element.Delete(protonNumber);
            return result;
        }

        private string ValidateInput(String protonNumber, String name, String chemicalSymbol, String atomicRadius, String relativeAtomicMass, String density, String metal, String boilingPoint, String meltingPoint, String description, String imageURL)
        {
            string msg = "";
            int iProtonNumber, iAtomicRadius;
            if(String.IsNullOrEmpty(protonNumber)|| int.TryParse(protonNumber, out iProtonNumber) == false)
            {
                msg = "Proton Number is empty or invalid";
            }
            else if (iProtonNumber < 1)
            {
                msg = "Proton Number cannot be less than 1";
            }
            else if (String.IsNullOrEmpty(name))
            {
                msg = "Name cannot be empty";
            }
            else if (String.IsNullOrEmpty(chemicalSymbol))
            {
                msg = "Chemical Symbol cannot be empty";
            }

            return msg;
        }
    }
}
