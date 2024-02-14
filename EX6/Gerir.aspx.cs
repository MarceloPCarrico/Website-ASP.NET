using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX6
{
    public partial class Gerir : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Obter_dados()
        {
            string connetionString;
            SqlConnection con;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\10792\EX6\App_Data\DB1.mdf;Integrated Security=True";

            con = new SqlConnection(connetionString);
            con.Open();
            // Response.Write("Ligado com sucesso!");
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso


            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select * from T_alunos, T_genero, T_turma where genero_id= T_genero.id AND turma_id = T_turma.id";
            Output = "<div class='container mt-5'>";
            Output += "<table class='table table-striped' style='background-color: #f0f0f0;'>";
            Output += "<thead class='thead-dark'><tr><th>ID</th><th>Nome</th><th>Email</th><th>Data Nascimento</th><th>Morada</th><th>Género</th><th>Turma</th></tr></thead>";
            Output += "<tbody>";


            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output += "<tr>";
                Output += "<td>" + dataReader.GetValue(0) + "</td>";
                Output += "<td>" + dataReader.GetValue(1) + "</td>";
                Output += "<td>" + dataReader.GetValue(2) + "</td>";
                Output += "<td>" + dataReader.GetValue(3) + "</td>";
                Output += "<td>" + dataReader.GetValue(4) + "</td>";
                Output += "<td>" + dataReader.GetValue(10) + "</td>";
                Output += "<td>" + dataReader.GetValue(8) + "</td>";
                Output += "<td>";
                Output += "<input type='button' class='btn btn-primary' value='Editar' onclick=window.open('Editar.aspx?id=" + dataReader.GetValue(0) + "') />";
                Output += "&nbsp;<input type='button' class='btn btn-danger' value='Eliminar' onclick=window.open('Eliminar.aspx?id=" + dataReader.GetValue(0) + "') />";
                Output += "</td>";
                Output += "</tr>";
            }

            Output += "</tbody></table>";
            Output += "</div>";

            Response.Write(Output);

            dataReader.Close();
            con.Close();

        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Voltar.');window.location = 'Default.aspx';", true);
        }
    }
}