using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class Element
    {
        private readonly String CONNECTION_STRING = ConfigurationManager.ConnectionStrings["TheChemicalTouchPortal.Properties.Settings.dbString"].ConnectionString;

        public Element(int protonNumber, string name, string chemicalSymbol, int atomicRadius, double relativeAtomicMass, double density, bool isMetal, double boilingPoint, double meltingPoint, string description, string imageURL)
        {
            ProtonNumber = protonNumber;
            Name = name;
            ChemicalSymbol = chemicalSymbol;
            AtomicRadius = atomicRadius;
            RelativeAtomicMass = relativeAtomicMass;
            Density = density;
            IsMetal = isMetal;
            BoilingPoint = boilingPoint;
            MeltingPoint = meltingPoint;
            Description = description;
            ImageURL = imageURL;
        }
        
        public Element()
        {
        }

        public int ProtonNumber { get; set; }
        public String Name { get; set; }
        public String ChemicalSymbol { get; set; }
        public int AtomicRadius { get; set; }
        public Double RelativeAtomicMass { get; set; }
        public Double Density { get; set; }
        public Boolean IsMetal { get; set; }
        public Double BoilingPoint { get; set; }
        public Double MeltingPoint { get; set; }
        public String Description { get; set; }
        public String ImageURL { get; set; }

        public int Insert(out String error)
        {
            int result = 0;
            error = String.Empty;
            String query = "INSERT INTO Element(ProtonNumber, Name, Symbol, Radius, Mass, Density, Metal, BoilingPoint, MeltingPoint, Description, ImageURL) values (@ProtonNumber, @Name, @Symbol, @Radius, @Mass, @Density, @Metal, @BoilingPoint, @MeltingPoint, @Description, @ImageURL)";

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProtonNumber", this.ProtonNumber);
                    command.Parameters.AddWithValue("@Name", this.Name);
                    command.Parameters.AddWithValue("@Symbol", this.ChemicalSymbol);
                    command.Parameters.AddWithValue("@Radius", this.AtomicRadius);
                    command.Parameters.AddWithValue("@Mass", this.RelativeAtomicMass);
                    command.Parameters.AddWithValue("@Density", this.Density);
                    command.Parameters.AddWithValue("@Metal", this.IsMetal);
                    command.Parameters.AddWithValue("@BoilingPoint", this.BoilingPoint);
                    command.Parameters.AddWithValue("@MeltingPoint", this.MeltingPoint);
                    command.Parameters.AddWithValue("@Description", this.Description);
                    command.Parameters.AddWithValue("@ImageURL", this.ImageURL);

                    try
                    {
                        connection.Open();
                        result += command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (System.Exception exception)
                    {
                        error = exception.Message;
                    }
                }
            }

            return result;
        }
        public int Delete(int protonNumber)
        {
            int results = 0;
            string query = "DELETE * FROM Element WHERE ProtonNumber = @ID";
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", protonNumber);
                    conn.Open();
                    results += cmd.ExecuteNonQuery();

                    conn.Close();

                }
            }
            return results;
        }

        public Element GetElement(int protonNumber)
        {
            Element element = new Element();
            String query = "SELECT * FROM Element WHERE ProtonNumber = @ProtonNumber";

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProtonNumber", protonNumber);
                    connection.Open();

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            element.ProtonNumber = protonNumber;
                            element.Name = dataReader["Name"].ToString();
                            element.ChemicalSymbol = dataReader["Symbol"].ToString();
                            element.AtomicRadius = Int32.Parse(dataReader["Radius"].ToString());
                            element.RelativeAtomicMass = Double.Parse(dataReader["Mass"].ToString());
                            element.Density = Double.Parse(dataReader["Density"].ToString());
                            element.IsMetal = Boolean.Parse(dataReader["Metal"].ToString());
                            element.BoilingPoint = Double.Parse(dataReader["BoilingPoint"].ToString());
                            element.MeltingPoint = Double.Parse(dataReader["MeltingPoint"].ToString());
                            element.Description = dataReader["Description"].ToString();
                            element.ImageURL = dataReader["ImageURL"].ToString();
                        }

                        dataReader.Close();
                        dataReader.Dispose();
                    }

                    connection.Close();
                }
            }

            return element;
        }

        public List<Element> GetAllElements()
        {
            List<Element> ElementAll = new List<Element>();

            int protonNumber, radius;
            string name, symbol, description, imageURL;
            double mass, density, boiling, melting;
            int metal;

            string query = "SELECT * FROM Element Order by ProtonNumber";

            SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                protonNumber = int.Parse(dr["ProtonNumber"].ToString());
                name = dr["Name"].ToString();
                symbol = dr["Symbol"].ToString();
                radius = int.Parse(dr["Radius"].ToString());
                mass = double.Parse(dr["Mass"].ToString());
                density = double.Parse(dr["Density"].ToString());
                metal = int.Parse(dr["Metal"].ToString());
                boiling = double.Parse(dr["BoilingPoint"].ToString());
                melting = double.Parse(dr["MeltingPoint"].ToString());
                description = dr["Description"].ToString();
                imageURL = dr["ImageURL"].ToString();

                ElementAll.Add(new Element(protonNumber, name, symbol, radius, mass, density, bool.Parse(metal.ToString()), boiling, melting, description, imageURL));
            }
            conn.Close();
            dr.Close();
            dr.Dispose();

            return ElementAll;

        }
    }
} 