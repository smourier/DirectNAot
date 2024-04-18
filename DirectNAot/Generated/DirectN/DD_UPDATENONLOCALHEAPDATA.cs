namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_updatenonlocalheapdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_UPDATENONLOCALHEAPDATA
{
    public nint lpDD;
    public uint dwHeap;
    public nuint fpGARTLin;
    public nuint fpGARTDev;
    public nuint ulPolicyMaxBytes;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint UpdateNonLocalHeap;
}
