#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_waitforverticalblankdata
public partial struct DD_WAITFORVERTICALBLANKDATA
{
    public nint lpDD;
    public uint dwFlags;
    public uint bIsInVB;
    public nuint hEvent;
    public HRESULT ddRVal;
    public nint WaitForVerticalBlank;
}
