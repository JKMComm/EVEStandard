﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    using Newtonsoft.Json;

    public class MarketGroup : ModelBase<MarketGroup>
    {
        /// <summary>
        /// market_group_id integer
        /// </summary>
        /// <value>market_group_id integer</value>
        [JsonProperty("market_group_id")]
        public int? MarketGroupId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// types array
        /// </summary>
        /// <value>types array</value>
        [JsonProperty("types")]
        public List<int?> Types { get; set; }

        /// <summary>
        /// parent_group_id integer
        /// </summary>
        /// <value>parent_group_id integer</value>
        [JsonProperty("parent_group_id")]
        public int? ParentGroupId { get; set; }
    }
}