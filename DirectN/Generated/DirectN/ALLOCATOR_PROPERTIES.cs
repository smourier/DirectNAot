#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-allocator_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct ALLOCATOR_PROPERTIES
{
    public int cBuffers;
    public int cbBuffer;
    public int cbAlign;
    public int cbPrefix;
}
