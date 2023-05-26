using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2022_11_01.WebApplicationFirewallPolicies;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ApplicationGatewaySslCipherSuiteConstant
{
    [Description("TLS_DHE_DSS_WITH_AES_128_CBC_SHA")]
    TLSDHEDSSWITHAESOneTwoEightCBCSHA,

    [Description("TLS_DHE_DSS_WITH_AES_128_CBC_SHA256")]
    TLSDHEDSSWITHAESOneTwoEightCBCSHATwoFiveSix,

    [Description("TLS_DHE_DSS_WITH_AES_256_CBC_SHA")]
    TLSDHEDSSWITHAESTwoFiveSixCBCSHA,

    [Description("TLS_DHE_DSS_WITH_AES_256_CBC_SHA256")]
    TLSDHEDSSWITHAESTwoFiveSixCBCSHATwoFiveSix,

    [Description("TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA")]
    TLSDHEDSSWITHThreeDESEDECBCSHA,

    [Description("TLS_DHE_RSA_WITH_AES_128_CBC_SHA")]
    TLSDHERSAWITHAESOneTwoEightCBCSHA,

    [Description("TLS_DHE_RSA_WITH_AES_128_GCM_SHA256")]
    TLSDHERSAWITHAESOneTwoEightGCMSHATwoFiveSix,

    [Description("TLS_DHE_RSA_WITH_AES_256_CBC_SHA")]
    TLSDHERSAWITHAESTwoFiveSixCBCSHA,

    [Description("TLS_DHE_RSA_WITH_AES_256_GCM_SHA384")]
    TLSDHERSAWITHAESTwoFiveSixGCMSHAThreeEightFour,

    [Description("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA")]
    TLSECDHEECDSAWITHAESOneTwoEightCBCSHA,

    [Description("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256")]
    TLSECDHEECDSAWITHAESOneTwoEightCBCSHATwoFiveSix,

    [Description("TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256")]
    TLSECDHEECDSAWITHAESOneTwoEightGCMSHATwoFiveSix,

    [Description("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA")]
    TLSECDHEECDSAWITHAESTwoFiveSixCBCSHA,

    [Description("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384")]
    TLSECDHEECDSAWITHAESTwoFiveSixCBCSHAThreeEightFour,

    [Description("TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384")]
    TLSECDHEECDSAWITHAESTwoFiveSixGCMSHAThreeEightFour,

    [Description("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA")]
    TLSECDHERSAWITHAESOneTwoEightCBCSHA,

    [Description("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256")]
    TLSECDHERSAWITHAESOneTwoEightCBCSHATwoFiveSix,

    [Description("TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256")]
    TLSECDHERSAWITHAESOneTwoEightGCMSHATwoFiveSix,

    [Description("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA")]
    TLSECDHERSAWITHAESTwoFiveSixCBCSHA,

    [Description("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384")]
    TLSECDHERSAWITHAESTwoFiveSixCBCSHAThreeEightFour,

    [Description("TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384")]
    TLSECDHERSAWITHAESTwoFiveSixGCMSHAThreeEightFour,

    [Description("TLS_RSA_WITH_AES_128_CBC_SHA")]
    TLSRSAWITHAESOneTwoEightCBCSHA,

    [Description("TLS_RSA_WITH_AES_128_CBC_SHA256")]
    TLSRSAWITHAESOneTwoEightCBCSHATwoFiveSix,

    [Description("TLS_RSA_WITH_AES_128_GCM_SHA256")]
    TLSRSAWITHAESOneTwoEightGCMSHATwoFiveSix,

    [Description("TLS_RSA_WITH_AES_256_CBC_SHA")]
    TLSRSAWITHAESTwoFiveSixCBCSHA,

    [Description("TLS_RSA_WITH_AES_256_CBC_SHA256")]
    TLSRSAWITHAESTwoFiveSixCBCSHATwoFiveSix,

    [Description("TLS_RSA_WITH_AES_256_GCM_SHA384")]
    TLSRSAWITHAESTwoFiveSixGCMSHAThreeEightFour,

    [Description("TLS_RSA_WITH_3DES_EDE_CBC_SHA")]
    TLSRSAWITHThreeDESEDECBCSHA,
}
