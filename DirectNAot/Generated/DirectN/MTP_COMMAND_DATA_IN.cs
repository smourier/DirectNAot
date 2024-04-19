namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mtpext/ns-mtpext-mtp_command_data_in
[StructLayout(LayoutKind.Sequential)]
public partial struct MTP_COMMAND_DATA_IN
{
    public ushort OpCode;
    public uint NumParams;
    public InlineArrayUInt325 Params;
    public uint NextPhase;
    public uint CommandWriteDataSize;
    public InlineArrayByte1 CommandWriteData; // variable-length array placeholder
}
