using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Endpoints.History.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// 
        /// </summary>
        [J("coverType")] public string CoverType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [J("url")] public string Url { get; set; }
    }
}
