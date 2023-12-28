using System.Data.OleDb;

namespace DataAcessTier
{
    public class DBConnection
    {
        protected OleDbConnection conn;

        public DBConnection()
        {
            try
            {
                dynamic path = AppDomain.CurrentDomain.BaseDirectory;
                string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "dbSanPham.mdb";
                conn = new OleDbConnection(strConn);
            }
            catch (Exception) {
                throw;
            }
        }

    }
}