﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_WMDRM_RENEWLICENSE
{
    public KSM_NODE NodeMethod;
    public uint ulXMRLicenseLength;
    public uint ulEntitlementTokenLength;
    public InlineArrayByte_1 argbDataBuffer; // variable-length array placeholder
}
