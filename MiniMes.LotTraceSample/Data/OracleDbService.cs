using System;
using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace MiniMes.LotTraceSample.Data
{
    public class OracleDbService
    {
        private readonly string _connectionString;

        public OracleDbService(string connectionStringName = "MesDb")
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[connectionStringName];

            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                throw new InvalidOperationException(
                    $"App.config에서 ConnectionString '{connectionStringName}' 을(를) 찾을 수 없습니다.");
            }

            _connectionString = settings.ConnectionString;
        }

        public DataTable ExecuteRefCursorProcedure(
            string procedureName,
            Action<OracleParameterCollection> addParameters)
        {
            if (string.IsNullOrWhiteSpace(procedureName))
            {
                throw new ArgumentException("프로시저명은 비어 있을 수 없습니다.", nameof(procedureName));
            }

            DataTable resultTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = connection.CreateCommand())
            using (OracleDataAdapter adapter = new OracleDataAdapter(command))
            {
                command.CommandText = procedureName;
                command.CommandType = CommandType.StoredProcedure;
                command.BindByName = true;

                addParameters?.Invoke(command.Parameters);

                connection.Open();
                adapter.Fill(resultTable);
            }

            return resultTable;
        }
    }
}
