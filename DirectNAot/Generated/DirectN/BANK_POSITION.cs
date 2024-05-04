#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BANK_POSITION
{
    public uint ReadBankPosition;
    public uint WriteBankPosition;
}
