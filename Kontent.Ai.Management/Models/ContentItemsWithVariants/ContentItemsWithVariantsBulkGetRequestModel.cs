using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kontent.Ai.Management.Models.ContentItemsWithVariants;

/// <summary>
/// Represents the request model for bulk getting content items with their variants.
/// </summary>
public class ContentItemsWithVariantsBulkGetRequestModel
{
    /// <summary>
    /// Gets or sets the list of variant identifiers to retrieve.
    /// </summary>
    [JsonProperty("variants")]
    public IEnumerable<VariantIdentifierModel> Variants { get; set; }

    /// <summary>
    /// Gets or sets whether to include content in the response.
    /// If the content is not included, the `elements` property in the language variants response will be omitted.
    /// </summary>
    [JsonProperty("include_content")]
    public bool? IncludeContent { get; set; }
}
