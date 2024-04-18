namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_4/nn-d3d11_4-id3d11multithread
[GeneratedComInterface, Guid("9b7e4e00-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D11Multithread
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11multithread-enter
    [PreserveSig]
    public void Enter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11multithread-leave
    [PreserveSig]
    public void Leave();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11multithread-setmultithreadprotected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool SetMultithreadProtected([MarshalAs(UnmanagedType.U4)] bool bMTProtect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_4/nf-d3d11_4-id3d11multithread-getmultithreadprotected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetMultithreadProtected();
}
