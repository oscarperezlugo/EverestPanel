using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace ReachSystem
{
    public partial class Rendimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (Apellido.Value.ToString() != null)
            {
                //string body = "<body>" +
                //    "<h1>RENDIMIENTO ACTUALIZADO A WEB Y APP</h1>" +
                //    "</body>";
                //SmtpClient smtp = new SmtpClient();
                //smtp.EnableSsl = true;
                //smtp.UseDefaultCredentials = false;
                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                //smtp.Credentials = new NetworkCredential("vdevalenciano@gmail.com", "vdv123vdv");
                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;



                //MailMessage mail = new MailMessage();
                //mail.From = new MailAddress("proyectoojcpl@gmail.com", "PINTURAS EVEREST");
                //mail.To.Add(new MailAddress("vdevalenciano@gmail.com"));
                //mail.Subject = "RENDIMIENTO ACTUALIZADO";
                //mail.IsBodyHtml = true;
                //mail.Body = body;

                //smtp.Send(mail);

                using (SqlConnection openCon = new SqlConnection("workstation id=PinturasEverest.mssql.somee.com;packet size=4096;user id=Servi_SQLLogin_1;pwd=3qbtgyqtr2;data source=PinturasEverest.mssql.somee.com;persist security info=False;initial catalog=PinturasEverest"))
                {
                    string saveStaff = "UPDATE Colores SET Rendimiento=@Rendimiento WHERE Categoria=@Categoria";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        //querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = ""+Nombre.Value.ToString()+" "+Text2.Value.ToString()+"";
                        //querySaveStaff.Parameters.Add("@Linea", SqlDbType.VarChar).Value = DropDownList2.SelectedValue.ToString();
                        querySaveStaff.Parameters.Add("@Rendimiento", SqlDbType.Float).Value = Double.Parse(Apellido.Value.ToString());
                        querySaveStaff.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = DropDownList4.SelectedValue.ToString();
                        //querySaveStaff.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Correo.Value.ToString();/* Telefono.Value.ToString();*/
                        //querySaveStaff.Parameters.Add("@Presentacion", SqlDbType.Int).Value = 1;/*Dirección.Value.ToString();*/
                        //querySaveStaff.Parameters.Add("@Color", SqlDbType.VarChar).Value = Text2.Value.ToString();                        
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            Response.Write("<script>alert('COLOR CREADO')</script>");
                        }
                        catch (SqlException ex)
                        {
                            Response.Write("Error" + ex);
                        }
                    }
                }

            }
            else
            {
                Response.Write("<script>alert('LAS CONTRASEÑAS NO COINCIDEN')</script>");
            }

        }
    }
}
