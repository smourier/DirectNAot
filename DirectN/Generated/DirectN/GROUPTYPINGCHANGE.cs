#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct GROUPTYPINGCHANGE
{
    public NMHDR nmhdr;
    public BOOL fGroupTyping;
}
