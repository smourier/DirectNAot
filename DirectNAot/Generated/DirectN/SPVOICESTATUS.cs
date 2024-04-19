namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPVOICESTATUS
{
    public uint ulCurrentStream;
    public uint ulLastStreamQueued;
    public HRESULT hrLastResult;
    public uint dwRunningState;
    public uint ulInputWordPos;
    public uint ulInputWordLen;
    public uint ulInputSentPos;
    public uint ulInputSentLen;
    public int lBookmarkId;
    public ushort PhonemeId;
    public SPVISEMES VisemeId;
    public uint dwReserved1;
    public uint dwReserved2;
}
