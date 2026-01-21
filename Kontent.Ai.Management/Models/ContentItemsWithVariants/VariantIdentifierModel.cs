using Kontent.Ai.Management.Models.Shared;
using Newtonsoft.Json;

namespace Kontent.Ai.Management.Models.ContentItemsWithVariants;

/// <summary>
/// Represents a variant identifier consisting of an item and language reference.
/// </summary>
public class VariantIdentifierModel
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
