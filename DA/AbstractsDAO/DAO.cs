using DC;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DA
{
    public abstract class DAO<T>
    {
        protected static SqlConnection connexion = ConnectionToSql.GetWavesoftInstance();
    }
}
