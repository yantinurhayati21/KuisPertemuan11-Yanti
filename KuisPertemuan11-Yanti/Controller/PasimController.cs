using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_Yanti.Controller
{
    internal class PasimController:Model.Conection
    {
        public DataTable tampil()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "select * from mahasiswa";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahMhs(string nim, string nm, string alm, string pr, string hb)
        {
            string add = "insert into mahasiswa values(" + "@NIM,@Alamat,@Prodi,@Hobi)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@NIM", MySqlConnector.MySqlDbType.VarChar).Value = nim;
                cmd.Parameters.Add("@Nama", MySqlConnector.MySqlDbType.VarChar).Value = nm;
                cmd.Parameters.Add("@Alamat", MySqlConnector.MySqlDbType.VarChar).Value = alm;
                cmd.Parameters.Add("@Prodi", MySqlConnector.MySqlDbType.VarChar).Value = pr;
                cmd.Parameters.Add("@Hobi", MySqlConnector.MySqlDbType.VarChar).Value = hb;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void updateMhs(string nim, string nm, string alm, string pr, string hb)
        {
            string upt = "update mahasiswa set " + "NIM=@NIM ";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@NIM", MySqlConnector.MySqlDbType.VarChar).Value = nim;
                cmd.Parameters.Add("@Nama", MySqlConnector.MySqlDbType.VarChar).Value = nm;
                cmd.Parameters.Add("@Alamat", MySqlConnector.MySqlDbType.VarChar).Value = alm;
                cmd.Parameters.Add("@Prodi", MySqlConnector.MySqlDbType.VarChar).Value = pr;
                cmd.Parameters.Add("@Hobi", MySqlConnector.MySqlDbType.VarChar).Value = hb;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }

    
}
