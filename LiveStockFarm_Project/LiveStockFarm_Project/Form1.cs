using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LiveStockFarm_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillHashTables();
            adjustRates();

        }
        public void fillHashTables()
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\ASUS\\source\\repos\\LiveStockFarm_Project\\FarmInfomation.accdb; Persist Security Info = False");//Connection string
                con.Open();//open the connection for access database

                // As we are reading 4 tables cow, goat,sheep and dogs so we will create 4 sql commands for 4 tables
                OleDbCommand cmd1 = con.CreateCommand();
                OleDbCommand cmd2 = con.CreateCommand();
                OleDbCommand cmd3 = con.CreateCommand();
                OleDbCommand cmd4 = con.CreateCommand();
                cmd1.CommandType = cmd2.CommandType = cmd3.CommandType = cmd4.CommandType = CommandType.Text;//set command type to text
                cmd1.CommandText = "SELECT * FROM Cows"; 
                cmd2.CommandText = "SELECT * FROM Goats";
                cmd3.CommandText = "SELECT * FROM Sheep";
                cmd4.CommandText = "SELECT * FROM Dogs";

                cmd1.ExecuteNonQuery(); cmd2.ExecuteNonQuery(); cmd3.ExecuteNonQuery(); cmd4.ExecuteNonQuery();//execute all commands
                DataTable dt1 = new DataTable(); DataTable dt2 = new DataTable(); //create 4 data tables the four access database tables
                DataTable dt3 = new DataTable(); DataTable dt4 = new DataTable();

                //create 4 data adapters and adapt data from each of the 4 commands
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1); 
                OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                OleDbDataAdapter da3 = new OleDbDataAdapter(cmd3); 
                OleDbDataAdapter da4 = new OleDbDataAdapter(cmd4);
                da1.Fill(dt1); da2.Fill(dt2); da3.Fill(dt3); da4.Fill(dt4);//fill the data tables with the data adapter data

                OleDbDataReader drr1 = cmd1.ExecuteReader();//read data from all commands
                OleDbDataReader drr2 = cmd2.ExecuteReader();
                OleDbDataReader drr3 = cmd3.ExecuteReader();
                OleDbDataReader drr4 = cmd4.ExecuteReader();
                while (drr1.Read())//as drr1 was for  cmd1 which adapted data from cows tables
                {
                    if (drr1[7].ToString() != "True")//if is jersy property is not true then fill that data in cow hash table
                    {
                        Database.cows.Add(int.Parse(drr1[0].ToString()), new Cow(int.Parse(drr1[0].ToString()), double.Parse(drr1[1].ToString()), double.Parse(drr1[2].ToString()),
                           double.Parse(drr1[3].ToString()), int.Parse(drr1[4].ToString()), drr1[5].ToString(), double.Parse(drr1[6].ToString())));
                    }
                    else//else fill that data in jersy cow hash table
                        Database.jersycows.Add(int.Parse(drr1[0].ToString()), new JersyCow(int.Parse(drr1[0].ToString()), double.Parse(drr1[1].ToString()), double.Parse(drr1[2].ToString()),
                           double.Parse(drr1[3].ToString()), int.Parse(drr1[4].ToString()), drr1[5].ToString(), double.Parse(drr1[6].ToString()),bool.Parse(drr1[7].ToString())));
                }
                
                while (drr2.Read())
                {
                    Database.goats.Add(int.Parse(drr2[0].ToString()), new Goat(int.Parse(drr2[0].ToString()), double.Parse(drr2[1].ToString()), double.Parse(drr2[2].ToString()),
                        double.Parse(drr2[3].ToString()), int.Parse(drr2[4].ToString()), drr2[5].ToString(), double.Parse(drr2[6].ToString())));
                }
                while (drr3.Read())
                {
                    Database.sheeps.Add(int.Parse(drr3[0].ToString()), new Sheep(int.Parse(drr3[0].ToString()), double.Parse(drr3[1].ToString()), double.Parse(drr3[2].ToString()),
                        double.Parse(drr3[3].ToString()), int.Parse(drr3[4].ToString()), drr3[5].ToString(), double.Parse(drr3[6].ToString())));
                }
                while (drr4.Read())
                {
                    Database.dogs.Add(int.Parse(drr4[0].ToString()), new Dog(int.Parse(drr4[0].ToString()), double.Parse(drr4[1].ToString()), double.Parse(drr4[2].ToString()),
                        int.Parse(drr4[3].ToString()), drr4[4].ToString(), double.Parse(drr4[5].ToString())));
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void adjustRates()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\ASUS\\source\\repos\\LiveStockFarm_Project\\FarmInfomation.accdb; Persist Security Info = False");
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Prices", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["Commodity"].ToString())
                {
                    case "Goat milk price":
                        {
                            Rates.goatMilkPrice = double.Parse(dr["Price"].ToString());
                            break;
                        }
                    case "Sheep wool price":
                        {
                            Rates.sheepWoolPrice = double.Parse(dr["Price"].ToString());
                            break;
                        }
                    case "Water price":
                        {
                            Rates.waterPice = double.Parse(dr["Price"].ToString());
                            break;
                        }
                    case "Government tax per kg":
                        {
                            Rates.govtTax = double.Parse(dr["Price"].ToString());
                            break;
                        }
                    case "Jersy cow tax":
                        {
                            Rates.jersyCowTax = double.Parse(dr["Price"].ToString());
                            break;
                        }
                    case "Cow milk price":
                        {
                            Rates.cowMilkPrice = double.Parse(dr["Price"].ToString());
                            break;
                        }
                }
            }
            conn.Close();
        }

        private void jersy_prft_form_Click(object sender, EventArgs e)
        {
            Report12 r12 = new Report12();
            r12.Show();
        }

        private void goat_cows_milk_form_Click(object sender, EventArgs e)
        {
            Report4 r4 = new Report4();
            r4.Show();
        }

        private void total_pl_form_Click(object sender, EventArgs e)
        {
            Report2 r2 = new Report2();
            r2.Show();
        }

        private void avg_age_form_Click(object sender, EventArgs e)
        {
            Report5 r5 = new Report5();
            r5.Show();
        }

        private void prft_gcs_form_Click(object sender, EventArgs e)
        {
            Report6 r6 = new Report6();
            r6.Show();
        }

        private void dog_cost_form_Click(object sender, EventArgs e)
        {
            Report7 r7 = new Report7();
            r7.Show();
        }

        private void jersy_tax_form_Click(object sender, EventArgs e)
        {
            Report10 r10 = new Report10();
            r10.Show();
        }

        private void red_animal_form_Click(object sender, EventArgs e)
        {
            Report9 r9 = new Report9();
            r9.Show();
        }

        private void threshold_form_Click(object sender, EventArgs e)
        {
            Report11 r11 = new Report11();
            r11.Show();
        }

        private void total_tax_form_Click(object sender, EventArgs e)
        {
            Report3 r3 = new Report3();
            r3.Show();
        }

        private void search_form_Click(object sender, EventArgs e)
        {
            Report1 r1 = new Report1();
            r1.Show();
        }

        private void sort_prft_form_Click(object sender, EventArgs e)
        {
            Report8 r8 = new Report8();
            r8.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
