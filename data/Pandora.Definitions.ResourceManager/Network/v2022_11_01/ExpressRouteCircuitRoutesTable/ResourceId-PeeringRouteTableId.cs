using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.ExpressRouteCircuitRoutesTable;

internal class PeeringRouteTableId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCircuits/{expressRouteCircuitName}/peerings/{peeringName}/routeTables/{routeTableName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftNetwork", "Microsoft.Network"),
        ResourceIDSegment.Static("staticExpressRouteCircuits", "expressRouteCircuits"),
        ResourceIDSegment.UserSpecified("expressRouteCircuitName"),
        ResourceIDSegment.Static("staticPeerings", "peerings"),
        ResourceIDSegment.UserSpecified("peeringName"),
        ResourceIDSegment.Static("staticRouteTables", "routeTables"),
        ResourceIDSegment.UserSpecified("routeTableName"),
    };
}
