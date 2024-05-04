#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfcontentprotectiondevice_input_data
[StructLayout(LayoutKind.Sequential)]
public partial struct MFCONTENTPROTECTIONDEVICE_INPUT_DATA
{
    public uint HWProtectionFunctionID;
    public uint PrivateDataByteCount;
    public uint HWProtectionDataByteCount;
    public uint Reserved;
    public InlineArrayByte4 InputData;
}
