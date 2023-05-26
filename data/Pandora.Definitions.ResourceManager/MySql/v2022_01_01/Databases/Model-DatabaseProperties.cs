using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MySql.v2022_01_01.Databases;


internal class DatabasePropertiesModel
{
    [JsonPropertyName("charset")]
    public string? Charset { get; set; }

    [JsonPropertyName("collation")]
    public string? Collation { get; set; }
}
