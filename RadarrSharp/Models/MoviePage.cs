using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MoviePage
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        /// <value>
        /// The page.
        /// </value>
        [J("page")] public int Page { get; set; }

        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        [J("pageSize")] public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the sort key.
        /// </summary>
        /// <value>
        /// The sort key.
        /// </value>
        [J("sortKey")] public string SortKey { get; set; }

        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        /// <value>
        /// The sort direction.
        /// </value>
        [J("sortDirection")] public string SortDirection { get; set; }

        /// <summary>
        /// Gets or sets the total movies.
        /// </summary>
        /// <value>
        /// The total movies.
        /// </value>
        [J("totalRecords")] public int TotalMovies { get; set; }

        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        /// <value>
        /// The movies.
        /// </value>
        [J("records")] public List<Movie> Movies { get; set; }
    }
}
