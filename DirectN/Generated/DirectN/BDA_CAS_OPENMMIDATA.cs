#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_CAS_OPENMMIDATA
{
    public uint ulDialogNumber;
    public uint ulDialogRequest;
    public Guid uuidDialogType;
    public ushort usDialogDataLength;
    public InlineArrayByte_1 argbDialogData; // variable-length array placeholder
}
