namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1printcontrol
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("2c1d867d-c290-41c8-ae7e-34a98702e9a5")]
public partial interface ID2D1PrintControl
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1printcontrol-addpage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddPage(ID2D1CommandList commandList, D2D_SIZE_F pageSize, IStream pagePrintTicketStream, nint/* nint */ tag1, nint/* nint */ tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1printcontrol-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Close();
}
