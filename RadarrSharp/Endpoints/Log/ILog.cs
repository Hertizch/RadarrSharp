using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Log
{
    /// <summary>
    /// Log endpoint client
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Gets the log files.
        /// </summary>
        /// <returns></returns>
        Task<IList<Models.LogFile>> GetLogFiles();

        /// <summary>
        /// Gets the log file.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        Task<string> GetLogFile(string filename);

        /// <summary>
        /// Gets the log.
        /// </summary>
        /// <param name="page">Page - Default 1</param>
        /// <param name="pageSize">Page size - Default 50</param>
        /// <returns></returns>
        Task<Models.Log> GetLog(int page = 1, int pageSize = 50);
    }
}
