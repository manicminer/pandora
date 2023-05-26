using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.ApplicationGateways;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ApplicationGatewayCookieBasedAffinityConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
