using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Resources.v2021_06_01.PolicyDefinitions;

internal class PolicyDefinitionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftAuthorization", "Microsoft.Authorization"),
        ResourceIDSegment.Static("staticPolicyDefinitions", "policyDefinitions"),
        ResourceIDSegment.UserSpecified("policyDefinitionName"),
    };
}
