#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfinputtrustauthority_access_params
[StructLayout(LayoutKind.Sequential)]
public partial struct MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS
{
    public uint dwSize;
    public uint dwVer;
    public uint cbSignatureOffset;
    public uint cbSignatureSize;
    public uint cbExtensionOffset;
    public uint cbExtensionSize;
    public uint cActions;
    public InlineArrayMFINPUTTRUSTAUTHORITY_ACCESS_ACTION_1 rgOutputActions; // variable-length array placeholder
}
