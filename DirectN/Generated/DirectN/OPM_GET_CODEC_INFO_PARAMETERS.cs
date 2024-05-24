﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_get_codec_info_parameters
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct OPM_GET_CODEC_INFO_PARAMETERS
{
    public uint cbVerifier;
    public InlineArrayByte_4052 Verifier;
}
