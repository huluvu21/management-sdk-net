using Kontent.Ai.Management.Modules.ActionInvoker;
using Kontent.Ai.Management.Modules.UrlBuilder;
using System;

namespace Kontent.Ai.Management;

/// <summary>
/// Provides access to early access Content Management API features.
/// These features are experimental and may change or be removed in future versions.
/// </summary>
public sealed class ManagementClientEarlyAccess : IManagementClientEarlyAccess
{
    private readonly ActionInvoker _actionInvoker;
    private readonly EndpointUrlBuilder _urlBuilder;

    internal ManagementClientEarlyAccess(ActionInvoker actionInvoker, EndpointUrlBuilder urlBuilder)
    {
        _actionInvoker = actionInvoker ?? throw new ArgumentNullException(nameof(actionInvoker));
        _urlBuilder = urlBuilder ?? throw new ArgumentNullException(nameof(urlBuilder));
    }
}
