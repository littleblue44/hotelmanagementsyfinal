using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms_netframework_Hotelmngmentsys.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
         }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            if(txtRoomno.Text != "" && txtRoomtype.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomNo    = txtRoomno.Text;
                String roomType  = txtRoomtype.Text;
                String Bed       = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo,roomType,bed,price,) values ('"+roomNo+"','"+roomType+"','"+Bed+"',"+price+") ";
                fn.setData(query, "Room Added.", cmd);

                UC_AddRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Please fill all the fields before proceeding", "warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
