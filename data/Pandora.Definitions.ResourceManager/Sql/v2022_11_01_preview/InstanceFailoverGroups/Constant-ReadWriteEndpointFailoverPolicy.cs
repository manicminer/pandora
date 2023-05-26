using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.InstanceFailoverGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ReadWriteEndpointFailoverPolicyConstant
{
    [Description("Automatic")]
    Automatic,

    [Description("Manual")]
    Manual,
}
