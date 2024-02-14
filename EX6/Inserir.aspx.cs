using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX6
{
    public partial class Inserir : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Init(object sender, EventArgs e)
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
            String sql, Output = "";
            sql = "Select * from T_genero";
            string x;
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                x = dataReader.GetValue(0) + "";
                dd_genero.Items.Add(new ListItem((string)dataReader.GetValue(1), x));
            }
            Response.Write(Output);
            dataReader.Close();

            sql = "Select * from T_turma";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                x = dataReader.GetValue(0) + "";
                dd_turma.Items.Add(new ListItem((string)dataReader.GetValue(1), x));
            }
            Response.Write(Output);
            dataReader.Close();
            con.Close();
        }

        protected void btn_inserir_Click(object sender, EventArgs e)
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
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into T_alunos(nome, email, data_nasc, morada, genero_id, turma_id) values ('" +
            txt_nome.Text + "', '" + txt_email.Text + "', '" + txt_data_nasc.Text + "', '" + txt_morada.Text + "', " + dd_genero.SelectedValue + "," + dd_turma.SelectedValue + ")";

            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Dados inseridos com sucesso');window.location = 'Listagem.aspx';", true);

        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Operação cancelada.');window.location = 'Default.aspx';", true);
        }
    }
}