using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Cognitive.v2023_05_01.Deployments;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeploymentModelVersionUpgradeOptionConstant
{
    [Description("NoAutoUpgrade")]
    NoAutoUpgrade,

    [Description("OnceCurrentVersionExpired")]
    OnceCurrentVersionExpired,

    [Description("OnceNewDefaultVersionAvailable")]
    OnceNewDefaultVersionAvailable,
}
