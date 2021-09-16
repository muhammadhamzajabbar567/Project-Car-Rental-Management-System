using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
    class customer
    {
        public string Name;
        public int CNIC;
        public int phonenumber;
        public int liscensenumber;

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int cnic
        {
            get
            {

                return CNIC;

            }

            set
            {

                CNIC = value;

            }

        }

        public int phoneno
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }

        public int liscenseno
        {
            get
            {
                return liscensenumber;
            }
            set
            {
                liscensenumber = value;
            }
        }

        public static SqlConnection con = null;

        public void AddCustomer()
        {

            con = new SqlConnection("Data Source=DESKTOP-FNAGGFI\\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMERDATA (name,cnic,phoneno,liscenseno) VALUES ('" + ( Name)+ "','" + (CNIC) + "','" + (phonenumber) + "','" + (liscensenumber) + "')", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA INSERTED SCCESSFULLY");
            con.Close();

        }

        public void RemoveCustomer()
        {

            con = new SqlConnection("Data Source=DESKTOP-FNAGGFI\\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete CUSTOMERDATA Where name='" + (Name) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA DELETED SCCESSFULLY");
            con.Close();
        }

        public void AssignCar()
        {
            MessageBox.Show("Your Car has been assigned .................!!!!!!!!!!");

        }
    }
}
