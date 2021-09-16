using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
    class REGIRY
    {
        public string FROM;
        public string TILL;
        public string CARMODEL;
        public int REGISTARATIONNUMBER;
        public string NAME;
        public int CUSTOMERCNIC;
        public int LICENSENUMBER;
        public int RENTALREGISTRYNUBER;

        public string from
        {
            get
            {
                return FROM;
            }

            set
            {
                FROM = value;
            }
        }
        public string till
        {
            get
            {
                return TILL;
            }

            set
            {
                TILL = value;
            }
        }
        public string model
        {
            get
            {
                return CARMODEL;
            }

            set
            {

                CARMODEL = value;
            }
        }
        public string name
        {
            get
            {
                return NAME;
            }

            set
            {

                NAME = value;
            }
        }



        public int cnic
        {
            get
            {

                return CUSTOMERCNIC;

            }

            set
            {

                CUSTOMERCNIC = value;

            }

        }


        public int registerno
        {
            get
            {

                return REGISTARATIONNUMBER;

            }

            set
            {

                REGISTARATIONNUMBER = value;

            }

        }
        public int lino
        {
            get
            {

                return LICENSENUMBER;

            }

            set
            {

                LICENSENUMBER = value;

            }

        }
        public int rrno
        {
            get
            {

                return RENTALREGISTRYNUBER;

            }

            set
            {

                RENTALREGISTRYNUBER = value;

            }

        }

        public static SqlConnection con = null;

        public void AddRegistry()
        {

            con = new SqlConnection("Data Source=DESKTOP-FNAGGFI\\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO REGISTRYDATA (from,till,carmodel,registrationno,customername,cnic,licenseno,rentalregistrationno) VALUES ('" + (FROM) + "','" + (TILL) + "','" + (CARMODEL) + "','" + (REGISTARATIONNUMBER) + "','" + (NAME) + "','" + (CUSTOMERCNIC) + "','" + (LICENSENUMBER) + "','" + (RENTALREGISTRYNUBER) + "')", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA INSERTED SCCESSFULLY");
            con.Close();

        }

        public void RemoveRegistry()
        {

            con = new SqlConnection("Data Source=DESKTOP-FNAGGFI\\SHAISTASHARIF;Initial Catalog=employee;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete REGISTRYDATA Where name='" + (NAME) + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DATA DELETED SCCESSFULLY");
            con.Close();
        }
    }
}
