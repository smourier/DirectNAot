#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/ns-wcsplugin-blackinformation
[StructLayout(LayoutKind.Sequential)]
public partial struct BlackInformation
{
    public BOOL fBlackOnly;
    public float blackWeight;
}
