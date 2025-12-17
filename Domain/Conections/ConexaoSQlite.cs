using System;
using System.IO;
using System.Data.SQLite;


namespace Domain.Conections
{
    public  class ConexaoSQlite
    {
        public String GetConnections()
        {
            string caminhoBanco = Path.Combine("C:\\GRC", "rf_db.db");

            return $"Data Source={caminhoBanco};Version=3";
        }
    }
}
