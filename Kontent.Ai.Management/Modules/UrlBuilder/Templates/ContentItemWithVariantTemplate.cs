using System;

namespace Kontent.Ai.Management.Modules.UrlBuilder.Templates;

internal class ContentItemWithVariantTemplate : UrlTemplate
{
    public override string Url => "/items-with-variant";
    public string BulkGetUrl => "/items-with-variant/bulk-get";
    public override string UrlId => throw new InvalidOperationException("Content Item With Variant does not have Id Url.");
    public override string UrlCodename => throw new InvalidOperationException("Content Item With Variant does not have Codename Url.");
    public override string UrlExternalId => throw new InvalidOperationException("Content Item With Variant does not have External Id Url.");
}
