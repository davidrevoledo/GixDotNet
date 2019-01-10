using System;
using System.Threading;
using System.Threading.Tasks;

namespace GixDotnet.Infrastructure.Services
{
    /// <summary>
    ///     Base Services.
    /// </summary>
    public abstract class BaseServices
    {
        /// <summary>
        ///     Dispatch an operation with a cancellation token source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected async Task<T> Execute<T>(Func<Task<T>> action, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var task = action.Invoke();
                return await task.ConfigureAwait(false);
            }

            return default(T);
        }
    }
}