using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.NetworkManagerEffectiveSecurityAdminRules;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AddressPrefixTypeConstant
{
    [Description("IPPrefix")]
    IPPrefix,

    [Description("ServiceTag")]
    ServiceTag,
}
