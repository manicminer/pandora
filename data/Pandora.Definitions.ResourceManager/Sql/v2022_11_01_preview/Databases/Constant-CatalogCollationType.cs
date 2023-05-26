using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Sql.v2022_11_01_preview.Databases;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CatalogCollationTypeConstant
{
    [Description("DATABASE_DEFAULT")]
    DATABASEDEFAULT,

    [Description("SQL_Latin1_General_CP1_CI_AS")]
    SQLLatinOneGeneralCPOneCIAS,
}
