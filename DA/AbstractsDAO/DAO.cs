using DC;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DA
{
    public abstract class DAO<T>
    {
        protected static SqlConnection SqlConnexion;
        protected static OleDbConnection accessConnexion;
    }
}
