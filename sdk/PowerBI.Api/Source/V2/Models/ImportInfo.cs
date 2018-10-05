// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The import info
    /// </summary>
    public partial class ImportInfo
    {
        /// <summary>
        /// Initializes a new instance of the ImportInfo class.
        /// </summary>
        public ImportInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportInfo class.
        /// </summary>
        /// <param name="filePath">The file path to import</param>
        /// <param name="connectionType">The import connection type</param>
        /// <param name="fileUrl">The SAS url of the temporary blob
        /// storage</param>
        public ImportInfo(string filePath = default(string), string connectionType = default(string), string fileUrl = default(string))
        {
            FilePath = filePath;
            ConnectionType = connectionType;
            FileUrl = fileUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the file path to import
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the import connection type
        /// </summary>
        [JsonProperty(PropertyName = "connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the SAS url of the temporary blob storage
        /// </summary>
        [JsonProperty(PropertyName = "fileUrl")]
        public string FileUrl { get; set; }

    }
}
