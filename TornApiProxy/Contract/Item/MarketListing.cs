/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2019  TornCityPro
  
  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.
  
  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.
  
  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
************************************************************************/

﻿namespace TornApiProxy.Contract.Item
{
    using Newtonsoft.Json;

    public class MarketListing
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class PointsListing : MarketListing
    {
        /// <summary>
        /// Only applies to PointsMarket
        /// </summary>
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }
    }
}
