using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.FirewallPolicyRuleCollectionGroups;

[ValueForType("FirewallPolicyFilterRuleCollection")]
internal class FirewallPolicyFilterRuleCollectionModel : FirewallPolicyRuleCollectionModel
{
    [JsonPropertyName("action")]
    public FirewallPolicyFilterRuleCollectionActionModel? Action { get; set; }

    [JsonPropertyName("rules")]
    public List<FirewallPolicyRuleModel>? Rules { get; set; }
}
