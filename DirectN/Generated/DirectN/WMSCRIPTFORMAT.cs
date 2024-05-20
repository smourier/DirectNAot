#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmscriptformat
[StructLayout(LayoutKind.Sequential)]
public partial struct WMSCRIPTFORMAT
{
    public Guid scriptType;
}
