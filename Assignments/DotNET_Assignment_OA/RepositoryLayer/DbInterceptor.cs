using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class DbInterceptor : DbCommandInterceptor
    {
        public override InterceptionResult<DbDataReader> ReaderExecuting(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result)
        {
            PrintCommand(command);

            return result;
        }

        public override Task<InterceptionResult<DbDataReader>> ReaderExecutingAsync(
            DbCommand command,
            CommandEventData eventData,
            InterceptionResult<DbDataReader> result,
            CancellationToken cancellationToken = default)
        {
            return Task.Run(() =>
            {
                PrintCommand(command);
                return result;
            }); ;
        }

        private void PrintCommand(DbCommand command) => Console.WriteLine("\n" + command.CommandText + "\n");

    }
}
