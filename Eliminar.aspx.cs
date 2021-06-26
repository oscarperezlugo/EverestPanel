using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReachSystem
{
    public partial class Eliminar : Page
    {
        int M;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( GridView1.Rows.Count > 0)
            {
                GridView2.Attributes.Add("style", "display:none");
            }
            else
            {
                GridView1.Attributes.Add("style", "display:none");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row = GridView1.SelectedIndex;
            using (SqlConnection openCon = new SqlConnection("workstation id=PinturasEverest.mssql.somee.com;packet size=4096;user id=Servi_SQLLogin_1;pwd=3qbtgyqtr2;data source=PinturasEverest.mssql.somee.com;persist security info=False;initial catalog=PinturasEverest"))
            {
                string saveStaff = "DELETE FROM Colores WHERE Nombre = @Nombre";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = GridView1.Rows[row].Cells[0].Text.ToString();                    
                    try
                    {
                        openCon.Open();
                        querySaveStaff.ExecuteNonQuery();
                        openCon.Close();
                        Response.Write("<script>alert('COLOR ELIMINADO')</script>");
                    }
                    catch (SqlException ex)
                    {
                        Response.Write("Error" + ex);
                    }
                }
            }
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string buscar = Correo.Value;
            HttpCookie buscarS = new HttpCookie("paramcuatroC");
            buscarS.Value = buscar;
            buscarS.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(buscarS);
            Response.Redirect("ListaUsuarios.aspx");
        }
        
    }
}