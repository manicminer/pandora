using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.ServerConnectionPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ServerConnectionTypeConstant
{
    [Description("Default")]
    Default,

    [Description("Proxy")]
    Proxy,

    [Description("Redirect")]
    Redirect,
}
