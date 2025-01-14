// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The aggregation expression to be used in the forecast. </summary>
    public partial class ForecastAggregation
    {
        /// <summary> Initializes a new instance of ForecastAggregation. </summary>
        /// <param name="name"> The name of the column to aggregate. </param>
        /// <param name="function"> The name of the aggregation function to use. </param>
        public ForecastAggregation(FunctionName name, FunctionType function)
        {
            Name = name;
            Function = function;
        }

        /// <summary> The name of the column to aggregate. </summary>
        public FunctionName Name { get; }
        /// <summary> The name of the aggregation function to use. </summary>
        public FunctionType Function { get; }
    }
}
