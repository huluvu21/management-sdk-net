using Kontent.Ai.Management.Models.Shared;
using Newtonsoft.Json;

namespace Kontent.Ai.Management.Models.VariantFilter;

/// <summary>
/// Represents a variant filter result containing item and language references.
/// </summary>
public class VariantFilterResultModel
{
    /// <summary>
    /// Gets or sets the content item reference.
    /// </summary>
    [JsonProperty("item")]
    public Reference Item { get; set; }

    /// <summary>
    /// Gets or sets the language reference.
    /// </summary>
    [JsonProperty("language")]
    public Reference Language { get; set; }
}
