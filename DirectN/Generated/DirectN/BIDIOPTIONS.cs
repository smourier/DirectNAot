#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-bidioptions
public partial struct BIDIOPTIONS
{
    public uint cbSize;
    public ushort wMask;
    public ushort wEffects;
}
