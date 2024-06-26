﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_copp_compatible_get_info_parameters
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS
{
    public OPM_RANDOM_NUMBER rnRandomNumber;
    public Guid guidInformation;
    public uint ulSequenceNumber;
    public uint cbParametersSize;
    public InlineArrayByte_4056 abParameters;
}
