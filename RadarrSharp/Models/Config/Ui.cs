using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models.Config
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Ui
    {
        /// <summary>
        /// Gets or sets the first day of week.
        /// </summary>
        /// <value>
        /// The first day of week.
        /// </value>
        [J("firstDayOfWeek")] public long FirstDayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the calendar week column header.
        /// </summary>
        /// <value>
        /// The calendar week column header.
        /// </value>
        [J("calendarWeekColumnHeader")] public string CalendarWeekColumnHeader { get; set; }

        /// <summary>
        /// Gets or sets the short date format.
        /// </summary>
        /// <value>
        /// The short date format.
        /// </value>
        [J("shortDateFormat")] public string ShortDateFormat { get; set; }

        /// <summary>
        /// Gets or sets the long date format.
        /// </summary>
        /// <value>
        /// The long date format.
        /// </value>
        [J("longDateFormat")] public string LongDateFormat { get; set; }

        /// <summary>
        /// Gets or sets the time format.
        /// </summary>
        /// <value>
        /// The time format.
        /// </value>
        [J("timeFormat")] public string TimeFormat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show relative dates].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show relative dates]; otherwise, <c>false</c>.
        /// </value>
        [J("showRelativeDates")] public bool ShowRelativeDates { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable color impaired mode].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable color impaired mode]; otherwise, <c>false</c>.
        /// </value>
        [J("enableColorImpairedMode")] public bool EnableColorImpairedMode { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}
