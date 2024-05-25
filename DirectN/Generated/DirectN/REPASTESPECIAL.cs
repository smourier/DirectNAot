#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-repastespecial
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct REPASTESPECIAL
{
    public DVASPECT dwAspect;
    public nuint dwParam;
}
