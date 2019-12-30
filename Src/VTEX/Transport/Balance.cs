﻿// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 12-08-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 12-08-2016
// ***********************************************************************
// <copyright file="Balance.cs" company="Guilherme Branco Stracini ME">
//     © 2016 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Balance. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class Balance
    {
        /// <summary>
        /// Gets or sets the ware house identifier.
        /// </summary>
        /// <value>The ware house identifier.</value>
        [JsonProperty("warehouseid")]
        public string WareHouseId { get; set; }

        /// <summary>
        /// Gets or sets the name of the ware house.
        /// </summary>
        /// <value>The name of the ware house.</value>
        [JsonProperty("warehousename")]
        public string WareHouseName { get; set; }

        /// <summary>
        /// Gets or sets the total quantity.
        /// </summary>
        /// <value>The total quantity.</value>
        [JsonProperty("totalquantity")]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// Gets or sets the reserved quantity.
        /// </summary>
        /// <value>The reserved quantity.</value>
        [JsonProperty("reservedquantity")]
        public int ReservedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the has unlimited quantity.
        /// </summary>
        /// <value>The has unlimited quantity.</value>
        [JsonProperty("hasUnlimitedQuantity")]
        public bool HasUnlimitedQuantity { get; set; }

        /// <summary>
        /// Gets or sets the time to refill.
        /// </summary>
        /// <value>
        /// The time to refill.
        /// </value>
        [JsonProperty("timeToRefill")]
        public NotNullObserver TimeToRefill { get; set; }
    }
}