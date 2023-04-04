using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DevTestLab.v2018_09_15.Schedules;

internal class Definition : ResourceDefinition
{
    public string Name => "Schedules";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOrUpdateOperation(),
        new DeleteOperation(),
        new ExecuteOperation(),
        new GetOperation(),
        new ListOperation(),
        new ListApplicableOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(EnableStatusConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(DayDetailsModel),
        typeof(HourDetailsModel),
        typeof(NotificationSettingsModel),
        typeof(ScheduleModel),
        typeof(SchedulePropertiesModel),
        typeof(UpdateResourceModel),
        typeof(WeekDetailsModel),
    };
}
