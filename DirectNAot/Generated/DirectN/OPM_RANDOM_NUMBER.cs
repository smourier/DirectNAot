#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/opmapi/ns-opmapi-opm_random_number
[StructLayout(LayoutKind.Sequential)]
public partial struct OPM_RANDOM_NUMBER
{
    public InlineArrayByte16 abRandomNumber;
}
