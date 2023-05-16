using Serilog;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;

namespace RepositoryLayer
{
    public class MyCommandInterceptor : DbCommandInterceptor
    {
        public override void ReaderExecuting(DbCommand command,
        DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            Log.Information("Executing command: {CommandText}", command.CommandText);
            base.ReaderExecuting(command, interceptionContext);
        }

        public override void ScalarExecuting(DbCommand command,
            DbCommandInterceptionContext<object> interceptionContext)
        {
            Log.Information("Executing command: {CommandText}", command.CommandText);
            base.ScalarExecuting(command, interceptionContext);
        }

        public override void NonQueryExecuting(DbCommand command,
            DbCommandInterceptionContext<int> interceptionContext)
        {
            Log.Information("Executing command: {CommandText}", command.CommandText);
            base.NonQueryExecuting(command, interceptionContext);
        }
    }
}
