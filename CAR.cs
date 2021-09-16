using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
    public class CAR
    {
        public int Register;
        public string Model;
        public string Company;
        public int capcity;

        public int reg
        {
            get
            {
                return Register;
            }

            set
            {
                Register = value;
            }
        }

        public string model
        {
            get
            {

                return Model;

            }

            set
            {

                Model = value;

            }

        }

        public string comp
        {
            get
            {
                return Company;
            }
            set
            {
                Company = value;
            }
        }

        public int capci
        {
            get
            {
                return capcity;
            }
            set
            {
                capcity = value;
            }
        }

        public static SqlConnection con = null;

        public void AddCar()
        {

            con = new SqlConnection("Data Source=DESKTOP-FNAGGFI\\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CARDATA (regno,model,company,capacity) VALUES ('" + (Register) + "','" + (Model) + "','" + (Company) + "','" + (capcity) + "')", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA INSERTED SCCESSFULLY");
            con.Close();

        }

        public void RemoveCar()
        {

            con = new SqlConnection("Data Source=DESKTOP-FNAGGFI\\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete CARDATA Where regno='" + (Register) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA DELETED SCCESSFULLY");
            con.Close();
        }

        public void BookCar()
        {
            MessageBox.Show("List of Car Booked .................!!!!!!!!!!");

        }
    }
}   


