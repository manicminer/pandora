using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Insights.v2020_10_01.ActivityLogAlertsAPIs;

internal class ActivityLogAlertsCreateOrUpdateOperation : Operations.PutOperation
{
    public override Type? RequestObject() => typeof(ActivityLogAlertResourceModel);

    public override ResourceID? ResourceId() => new ActivityLogAlertId();

    public override Type? ResponseObject() => typeof(ActivityLogAlertResourceModel);


}
