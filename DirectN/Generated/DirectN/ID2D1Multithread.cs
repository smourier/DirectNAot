#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1multithread
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3")]
public partial interface ID2D1Multithread
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1multithread-getmultithreadprotected
    [PreserveSig]
    BOOL GetMultithreadProtected();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1multithread-enter
    [PreserveSig]
    void Enter();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1multithread-leave
    [PreserveSig]
    void Leave();
}
