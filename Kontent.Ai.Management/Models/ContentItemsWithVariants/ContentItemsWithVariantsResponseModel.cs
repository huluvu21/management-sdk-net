using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kontent.Ai.Management.Models.ContentItemsWithVariants;

/// <summary>
/// Represents the response model for bulk getting content items with their variants.
/// </summary>
public class ContentItemsWithVariantsResponseModel
{
    /// <summary>
    /// Gets or sets the list of content items with their variants.
    /// </summary>
    [JsonProperty("data")]
    public IEnumerable<ContentItemWithVariantModel> Data { get; set; }
}
