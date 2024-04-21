using System.Data;
using System.Data.SqlClient;

public class datacot
{
    string constr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["db"].ConnectionString;

    public void Ins_Edt_Del(string str)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public void Ins_Edt_Del(string str, SqlParameter[] para)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.Parameters.AddRange(para);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public SqlDataReader ReadData(string str)
    {
        SqlConnection con = new SqlConnection(constr);
        con.Open();
        SqlCommand cmd = new SqlCommand(str, con);
        return cmd.ExecuteReader();

    }
    public DataSet filldata(string str)
    {

        SqlDataAdapter da = new SqlDataAdapter(str, constr);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

}


