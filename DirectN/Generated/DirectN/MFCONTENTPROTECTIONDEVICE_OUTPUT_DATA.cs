﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfcontentprotectiondevice_output_data
public partial struct MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA
{
    public uint PrivateDataByteCount;
    public uint MaxHWProtectionDataByteCount;
    public uint HWProtectionDataByteCount;
    public HRESULT Status;
    public long TransportTimeInHundredsOfNanoseconds;
    public long ExecutionTimeInHundredsOfNanoseconds;
    public InlineArrayByte_4 OutputData;
}
