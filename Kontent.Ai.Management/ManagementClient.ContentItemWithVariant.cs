using Kontent.Ai.Management.Models.ContentItemsWithVariants;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kontent.Ai.Management;

public partial class ManagementClient
{
    /// <inheritdoc />
    public async Task<ContentItemsWithVariantsResponseModel> GetContentItemsWithVariantsAsync(ContentItemsWithVariantsBulkGetRequestModel request)
    {
        ArgumentNullException.ThrowIfNull(request);

        var endpointUrl = _urlBuilder.BuildContentItemsWithVariantsBulkGetUrl();
        var response = await _actionInvoker.InvokeMethodAsync<ContentItemsWithVariantsBulkGetRequestModel, ContentItemsWithVariantsResponseModel>(endpointUrl, HttpMethod.Post, request);

        return response;
    }
}
