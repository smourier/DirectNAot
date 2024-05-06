#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_omac
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_OMAC
{
    public InlineArrayByte_16 abOMAC;
}
