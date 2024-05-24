#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mtpext/ns-mtpext-mtp_command_data_out
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MTP_COMMAND_DATA_OUT
{
    public ushort ResponseCode;
    public uint NumParams;
    public InlineArrayUInt32_5 Params;
    public uint CommandReadDataSize;
    public InlineArrayByte_1 CommandReadData; // variable-length array placeholder
}
