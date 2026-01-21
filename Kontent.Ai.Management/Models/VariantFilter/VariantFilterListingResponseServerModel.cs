using Kontent.Ai.Management.Models.Shared;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Kontent.Ai.Management.Models.VariantFilter;

/// <summary>
/// Represents the variant filter response model.
/// Returns variant references (item + language).
/// </summary>
[JsonObject]
internal class VariantFilterListingResponseServerModel : IListingResponse<VariantFilterResultModel>
{
    /// <summary>
    /// Gets or sets the variant filter results.
    /// </summary>
    [JsonProperty("variants")]
    public IEnumerable<VariantFilterResultModel> Variants { get; set; }

    /// <summary>
    /// Gets or sets the pagination response.
    /// </summary>
    [JsonProperty("pagination")]
    public PaginationResponseModel Pagination { get; set; }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<VariantFilterResultModel> GetEnumerator() => Variants.GetEnumerator();
}
