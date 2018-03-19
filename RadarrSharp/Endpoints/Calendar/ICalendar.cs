using System;
using System.Threading.Tasks;

namespace RadarrSharp.Endpoints.Calendar
{
    /// <summary>
    /// Calendar endpoint client
    /// </summary>
    public interface ICalendar
    {
        /// <summary>
        /// Gets upcoming movies, if start/end are not supplied movies airing today and tomorrow will be returned
        /// </summary>
        /// <returns>Data.Calendar[]</returns>
        Task<Data.Calendar[]> GetCalendar();

        /// <summary>
        /// Gets upcoming movies, between the given time
        /// </summary>
        /// <param name="start">From date</param>
        /// <param name="end">To date</param>
        /// <returns>Data.Calendar[]</returns>
        Task<Data.Calendar[]> GetCalendar(DateTime start, DateTime end);
    }
}
