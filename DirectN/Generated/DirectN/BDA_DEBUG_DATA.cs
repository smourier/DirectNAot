#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_DEBUG_DATA
{
    public int lResult;
    public Guid uuidDebugDataType;
    public uint ulDataSize;
    public InlineArrayByte_1 argbDebugData; // variable-length array placeholder
}
