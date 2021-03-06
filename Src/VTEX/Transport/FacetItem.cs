﻿namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class FacetItem. This class cannot be inherited.
    /// </summary>
    public sealed class FacetItem
    {

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}