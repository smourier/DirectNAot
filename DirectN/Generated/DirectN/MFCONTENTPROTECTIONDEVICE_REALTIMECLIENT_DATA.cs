#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfcontentprotectiondevice_realtimeclient_data
public partial struct MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA
{
    public uint TaskIndex;
    public InlineArraySystemChar_260 ClassName;
    public int BasePriority;
}
