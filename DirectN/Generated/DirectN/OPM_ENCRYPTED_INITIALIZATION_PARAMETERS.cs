﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_encrypted_initialization_parameters
public partial struct OPM_ENCRYPTED_INITIALIZATION_PARAMETERS
{
    public InlineArrayByte_256 abEncryptedInitializationParameters;
}
