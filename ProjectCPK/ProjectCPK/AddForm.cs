using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCPK
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void add_customerAccount_btn_Click(object sender, EventArgs e)
        {
            string fname = add_fname_txtbx.Text.ToUpper();
            string lname = add_lname_txtbx.Text.ToUpper();
            string bday = add_bday_txtbx.Text.ToUpper();
            string ssn = add_ssn_txtbx.Text.ToUpper();
            string street_addr = add_addr_txtbx.Text.ToUpper();
            string city = add_city_txtbx.Text.ToUpper();
            string state = add_state_txtbx.Text.ToUpper();
            string zip = add_zip_txtbx.Text.ToUpper();

            string insert_cmd = String.Format(@"INSERT INTO `person` (`PERSON_Fname`, `PERSON_Lname`, `PERSON_Bdate`, `PERSON_SSN`, `PERSON_ADDR_St_Name`, `PERSON_ADDR_City`, `PERSON_ADDR_Zip`, `PERSON_ADDR_State`) VALUES
                ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', {6}, '{7}');", fname, lname, bday, ssn, street_addr, city, zip, state);
            if (RxCPK.connection.Insert(insert_cmd))
            {
                MessageBox.Show("Able to create new customer account!");
            }
            else
                MessageBox.Show("Unable to create new customer account. :(");
            
        }


    }
}
