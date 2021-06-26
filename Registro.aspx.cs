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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {            

            if (Contraseña.Value.ToString() == Repetir.Value.ToString())
            {
                //string body = "<body>" +
                //    "<h1>BIENVENIDO A NUESTRO SISTEMA</h1>" +
                //    "</body>";
                //SmtpClient smtp = new SmtpClient();
                //smtp.EnableSsl = true;
                //smtp.UseDefaultCredentials = false;
                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                //smtp.Credentials = new NetworkCredential("vdevalenciano@gmail.com", "vdv123vdv");                         
                //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                
                

                //MailMessage mail = new MailMessage();
                //mail.From = new MailAddress("proyectoojcpl@gmail.com", "Tarrago Brands International");
                //mail.To.Add(new MailAddress("vdevalenciano@gmail.com"));
                //mail.Subject = "Bienvenido a Pinturas Everest";
                //mail.IsBodyHtml = true;
                //mail.Body = body;

                //smtp.Send(mail);

                using (SqlConnection openCon = new SqlConnection("workstation id=PinturasEverest.mssql.somee.com;packet size=4096;user id=Servi_SQLLogin_1;pwd=3qbtgyqtr2;data source=PinturasEverest.mssql.somee.com;persist security info=False;initial catalog=PinturasEverest"))
                {
                    string saveStaff = "INSERT into Usuario (Nombre, Email, Apellido, Pass) VALUES (@Nombre, @Email, @Apellido, @Pass) ";                  
                    
                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre.Value.ToString();
                        querySaveStaff.Parameters.Add("@Email", SqlDbType.VarChar).Value = Correo.Value.ToString();
                        querySaveStaff.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Text2.Value.ToString();                        
                        querySaveStaff.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Contraseña.Value.ToString();
                        
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                            openCon.Close();
                            
                            Response.Write("<script>alert('USUARIO REGISTRADO')</script>");
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