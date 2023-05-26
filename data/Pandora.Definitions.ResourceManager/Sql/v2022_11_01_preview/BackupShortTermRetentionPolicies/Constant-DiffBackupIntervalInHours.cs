using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.BackupShortTermRetentionPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.Integer)]
internal enum DiffBackupIntervalInHoursConstant
{
    [Description("12")]
    OneTwo,

    [Description("24")]
    TwoFour,
}
