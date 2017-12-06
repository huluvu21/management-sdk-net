﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace KenticoCloud.ContentManagement.Models.Items
{
    /// <summary>
    /// Represents content item upsert model.
    /// </summary>
    public sealed class ContentItemUpsertModel
    {
        /// <summary>
        /// Gets or sets name of the content item.
        /// </summary>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type of the content item.
        /// </summary>
        [JsonProperty("type")]
        public ContentTypeIdentifier Type { get; set; }

        /// <summary>
        /// Gets or sets sitemap locations of the content item.
        /// </summary>
        [JsonProperty("sitemap_locations")]
        public IEnumerable<SitemapNodeIdentifier> SitemapLocations { get; set; }
    }
}
