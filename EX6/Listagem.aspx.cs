using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX6
{
    public partial class Listagem : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Lista_dados()
        {
            string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\10792\EX6\App_Data\DB1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "SELECT * FROM T_alunos, T_genero, T_turma WHERE genero_id = T_genero.id AND turma_id = T_turma.id";

            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            // Use uma variável para alternar as cores de fundo
            bool isColor1 = true;

            // Construir a tabela HTML com Bootstrap
            StringBuilder tableBuilder = new StringBuilder();

            // Adicione a estrutura inicial da tabela com classes do Bootstrap
            tableBuilder.Append("<table class='table table-striped' style='background-color: #f0f0f0;'>");
            tableBuilder.Append("<thead class='thead-dark'><tr><th>ID</th><th>Nome</th><th>Email</th><th>Data Nascimento</th><th>Morada</th><th>Género</th><th>Turma</th></tr></thead>");
            tableBuilder.Append("<tbody>");

            while (dataReader.Read())
            {
                // Alterna as cores de fundo 
                string rowColor = isColor1 ? "#ffffff" : "#e6e6e6";

                // Adicione cada linha da tabela com os dados do aluno e cor de fundo
                tableBuilder.Append("<tr style='background-color:" + rowColor + "'>");
                tableBuilder.Append("<td>" + dataReader.GetValue(0) + "</td>");
                tableBuilder.Append("<td>" + dataReader.GetValue(1) + "</td>");
                tableBuilder.Append("<td>" + dataReader.GetValue(2) + "</td>");
                tableBuilder.Append("<td>" + dataReader.GetValue(3) + "</td>");
                tableBuilder.Append("<td>" + dataReader.GetValue(4) + "</td>");
                tableBuilder.Append("<td>" + dataReader.GetValue(8) + "</td>");
                tableBuilder.Append("<td>" + dataReader.GetValue(10) + "</td>");
                tableBuilder.Append("</tr>");

                // Alterna a variável de cor para a próxima linha
                isColor1 = !isColor1;
            }

            tableBuilder.Append("</tbody></table>");

            // Exibe a tabela HTML na página
            Response.Write(tableBuilder.ToString());

            dataReader.Close();
            con.Close();
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Voltar.');window.location = 'Default.aspx';", true);
        }
    }
}
