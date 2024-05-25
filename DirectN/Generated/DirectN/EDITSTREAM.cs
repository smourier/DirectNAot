#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-editstream
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct EDITSTREAM
{
    public nuint dwCookie;
    public uint dwError;
    public nint pfnCallback;
}
