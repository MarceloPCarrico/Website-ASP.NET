using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX6
{
    public partial class Generos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Obter_dados()
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\10792\EX6\App_Data\DB1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select * from T_genero";

            Output = Output + "<table class='table table-striped' style='background-color: #f0f0f0;'> <thead class='thead-dark'><tr><th>ID</th><th>Género</th><th>Ação</th></tr></thead><tbody>";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            bool isColor1 = true;

            while (dataReader.Read())
            {
                // Alterna as cores de fundo 
                string rowColor = isColor1 ? "#ffffff" : "#e6e6e6";

                Output = Output + "<tr style='background-color:" + rowColor + "'><td>" + dataReader.GetValue(0) + "</td><td>" + dataReader.GetValue(1) + "</td><td><a href='EliminarGen.aspx?id=" + dataReader.GetValue(0) + "'target='_self'>Eliminar</a></td></tr>";

                // Alterna a variável de cor para a próxima linha
                isColor1 = !isColor1;
            }

            Response.Write(Output + "</tbody></table>");
            dataReader.Close();
            con.Close();
        }


        protected void btn_inserir_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\10792\EX6\App_Data\DB1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql= " ";
            sql = "Insert into T_genero(genero) values ('" + txt_genero.Text + "')";

            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Genero inserido com sucesso');window.location = 'Generos.aspx';", true);
        }
    }
}