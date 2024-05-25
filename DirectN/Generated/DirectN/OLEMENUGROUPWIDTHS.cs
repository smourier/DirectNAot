#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/ns-oleidl-olemenugroupwidths
[StructLayout(LayoutKind.Sequential)]
public partial struct OLEMENUGROUPWIDTHS
{
    public InlineArrayInt32_6 width;
}
