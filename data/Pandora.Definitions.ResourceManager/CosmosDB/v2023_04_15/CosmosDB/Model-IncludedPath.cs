using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2023_04_15.CosmosDB;


internal class IncludedPathModel
{
    [JsonPropertyName("indexes")]
    public List<IndexesModel>? Indexes { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
