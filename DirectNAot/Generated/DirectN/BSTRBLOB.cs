namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BSTRBLOB
{
    public uint cbSize;
    public nint pData;
}
