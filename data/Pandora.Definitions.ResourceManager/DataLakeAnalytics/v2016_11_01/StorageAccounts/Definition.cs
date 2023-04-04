using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataLakeAnalytics.v2016_11_01.StorageAccounts;

internal class Definition : ResourceDefinition
{
    public string Name => "StorageAccounts";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AddOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new GetStorageContainerOperation(),
        new ListByAccountOperation(),
        new ListSasTokensOperation(),
        new ListStorageContainersOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AddStorageAccountParametersModel),
        typeof(AddStorageAccountPropertiesModel),
        typeof(SasTokenInformationModel),
        typeof(StorageAccountInformationModel),
        typeof(StorageAccountInformationPropertiesModel),
        typeof(StorageContainerModel),
        typeof(StorageContainerPropertiesModel),
        typeof(UpdateStorageAccountParametersModel),
        typeof(UpdateStorageAccountPropertiesModel),
    };
}
