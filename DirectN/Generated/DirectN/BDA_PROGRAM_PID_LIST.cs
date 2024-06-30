#nullable enable
namespace DirectN;

public partial struct BDA_PROGRAM_PID_LIST
{
    public uint ulProgramNumber;
    public uint ulcPIDs;
    public InlineArrayUInt32_1 ulPID; // variable-length array placeholder
}
