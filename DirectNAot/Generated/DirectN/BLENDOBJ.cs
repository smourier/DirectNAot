#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-blendobj
[StructLayout(LayoutKind.Sequential)]
public partial struct BLENDOBJ
{
    public BLENDFUNCTION BlendFunction;
}
