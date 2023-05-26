using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2023_04_15.ManagedCassandras;

internal class CassandraDataCentersCreateUpdateOperation : Pandora.Definitions.Operations.PutOperation
{
    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(DataCenterResourceModel);

    public override ResourceID? ResourceId() => new DataCenterId();

    public override Type? ResponseObject() => typeof(DataCenterResourceModel);


}
