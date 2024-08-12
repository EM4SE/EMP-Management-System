using exam_test;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Core;

namespace EMP_Management_System.Designations
{
    public class DesignationManager
    {

        public void AddDesignation(DesignationData DesData)
        {
            ValidateFormData(DesData);

            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string query = @"INSERT INTO designations 
                    (name,description) 
                    VALUES (@Name,@Description)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", DesData.Name);
                cmd.Parameters.AddWithValue("@Description", DesData.Description);
               

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data entered success fully");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 547 || ex.Number == 2601) 
                { 
                    MessageBox.Show("Error: Designation Name Already in Used");
                }
                else
                {                 
                    MessageBox.Show("An error occurred while adding to the database." + ex.Message);
                }
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }

        public void EditDesignation(DesignationData DesData)
        {
            ValidateFormData(DesData);
            try
            {
                MySqlConnection con = DBConfig.connectDB();
                string query = @"UPDATE designations 
                     SET name = @Name,description = @Description WHERE id = @DesID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@DesID", DesData.DesignationID);
                cmd.Parameters.AddWithValue("@Name", DesData.Name);
                cmd.Parameters.AddWithValue("@Description", DesData.Description);


                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Edited success fully");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 547 || ex.Number == 2601)
                {
                    MessageBox.Show("Error: Designation Name Already in Used");
                }
                else
                {
                    MessageBox.Show("An error occurred while Editing the the database." + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
            }
        }

        public void DeleteDesignation(DesignationData DesData)
        {
            ValidateFormData(DesData);
            if (MessageBox.Show("Are you sure you want to delete this Designation?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection con = DBConfig.connectDB();
                    string query = @"DELETE FROM designations WHERE id = @DesID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@DesID", DesData.DesignationID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Deleted success fully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while Deleting the designation to the database." + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred while processing your request." + ex.Message);
                }
            }
        }
        public void ValidateFormData(DesignationData DesData)
        {
            if (string.IsNullOrWhiteSpace(DesData.Name))
            {
                throw new ArgumentException("Name is required.");
            }


            if (string.IsNullOrWhiteSpace(DesData.Description))
            {
                throw new ArgumentException("Description is required..");
            }

        }


    }



}

public class DesignationData
{
    public int DesignationID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
   
}
