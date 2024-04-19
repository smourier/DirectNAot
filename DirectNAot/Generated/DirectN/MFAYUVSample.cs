namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfayuvsample
[StructLayout(LayoutKind.Sequential)]
public partial struct MFAYUVSample
{
    public byte bCrValue;
    public byte bCbValue;
    public byte bYValue;
    public byte bSampleAlpha8;
}
