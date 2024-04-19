namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct TRANSPORTSTATUS
{
    public int Mode;
    public int LastError;
    public int RecordInhibit;
    public int ServoLock;
    public int MediaPresent;
    public int MediaLength;
    public int MediaSize;
    public int MediaTrackCount;
    public int MediaTrackLength;
    public int MediaTrackSide;
    public int MediaType;
    public int LinkMode;
    public int NotifyOn;
}
