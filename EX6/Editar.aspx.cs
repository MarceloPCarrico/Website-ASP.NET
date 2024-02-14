using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX6
{
    public partial class Editar : Page
    {
        protected void btn_alterar_Click(object sender, EventArgs e)
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
            String sql = " ";
            sql = "update T_alunos set nome='" + txt_nome.Text + "', email='" + txt_email.Text + "', data_nasc='" + txt_data_nasc.Text + "', morada='" + txt_morada.Text + "', genero_id=" + dd_genero.SelectedValue + " , turma_id=" + dd_turma.SelectedValue + "  where numero=" + txt_numero.Text;

            // Response.Write(sql);
            // a linha acima serve para verem o que esta a ser executado no vosso sql
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados",
           "alert('Dados alterados com sucesso');window.location='Listagem.aspx';", true);
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            txt_numero.Text = Request.QueryString["id"];
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\10792\EX6\App_Data\DB1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "Select * from T_genero";
            string x;
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                x = dataReader.GetValue(0) + "";
                dd_genero.Items.Add(new ListItem((string)dataReader.GetValue(1),x));
            }
            dataReader.Close();

            sql = "Select * from T_turma";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                x = dataReader.GetValue(0) + "";
                dd_turma.Items.Add(new ListItem((string)dataReader.GetValue(1), x));
            }
            dataReader.Close();

            sql = "Select * from T_alunos where numero= " + Request.QueryString["id"];
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            txt_nome.Text = dataReader.GetValue(1).ToString();
            txt_email.Text = dataReader.GetValue(2).ToString();
            txt_data_nasc.Text = dataReader.GetValue(3).ToString();
            txt_morada.Text = dataReader.GetValue(4).ToString();
            dd_genero.SelectedValue = dataReader.GetValue(5).ToString();
            dd_turma.SelectedValue = dataReader.GetValue(6).ToString();
            dataReader.Close();

            con.Close();
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Voltar.');window.location = 'Gerir.aspx';", true);
        }
    }
}