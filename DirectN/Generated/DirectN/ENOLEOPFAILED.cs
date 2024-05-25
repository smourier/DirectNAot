#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-enoleopfailed
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct ENOLEOPFAILED
{
    public NMHDR nmhdr;
    public int iob;
    public int lOper;
    public HRESULT hr;
}
