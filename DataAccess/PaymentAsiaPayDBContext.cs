
using MicroOrm.Dapper.Repositories.DbContext;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOrm.Dapper.Repositories.SqlGenerator;
using MicroOrm.Dapper.Repositories;

namespace DataAccess
{
    public class PaymentAsiaPayDBContext: DapperDbContext
    {
        private IDapperRepository<Breed> _breed;
        private IDapperRepository<Cat> _cat;

        private readonly SqlGeneratorConfig _config = new SqlGeneratorConfig
        {
            SqlConnector = ESqlConnector.MSSQL,
            UseQuotationMarks = true
        };

        public PaymentAsiaPayDBContext(string connectionString)
            : base(new SqlConnection(connectionString))
        {
        }

        public IDapperRepository<Breed> Breed => _breed ?? (_breed = new DapperRepository<Breed>(Connection, _config));
        public IDapperRepository<Cat> Cat => _cat ?? (_cat = new DapperRepository<Cat>(Connection, _config));
    }
}
