using Kontent.Ai.Management.Models.Shared;
using Kontent.Ai.Management.Models.VariantFilter;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kontent.Ai.Management;

public partial class ManagementClient
{
    /// <inheritdoc />
    public async Task<IListingResponseModel<VariantFilterResultModel>> FilterVariantsAsync(VariantFilterRequestModel request)
    {
        ArgumentNullException.ThrowIfNull(request);

        var endpointUrl = _urlBuilder.BuildVariantFilterUrl();
        var response = await _actionInvoker.InvokeMethodAsync<VariantFilterRequestModel, VariantFilterListingResponseServerModel>(endpointUrl, HttpMethod.Post, request);

        return new ListingResponseModel<VariantFilterResultModel>(
            GetNextListingPageAsync<VariantFilterListingResponseServerModel, VariantFilterResultModel>,
            response.Pagination?.Token,
            endpointUrl,
            HttpMethod.Post,
            response.Variants);
    }
}
