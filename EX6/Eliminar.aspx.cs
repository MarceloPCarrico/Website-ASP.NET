using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX6
{
    public partial class Eliminar : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            while (dataReader.Read())
            {
                x = dataReader.GetValue(0) + "";
                dd_genero.Items.Add(new ListItem((string)dataReader.GetValue(1), x));
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

            sql = "Select * from T_alunos where numero=" + Request.QueryString["id"];
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

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\10792\EX6\App_Data\DB1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Delete T_alunos where numero=" + txt_numero.Text;

            command = new SqlCommand(sql, con);
            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            con.Close();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Dados eliminados com sucesso.');windows.location='Listagem.aspx';", true);
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Voltar.');window.location='Listagem.aspx';", true);
        }
    }
    
}