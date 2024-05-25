#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-endropfiles
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct ENDROPFILES
{
    public NMHDR nmhdr;
    public HANDLE hDrop;
    public int cp;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fProtected;
}
