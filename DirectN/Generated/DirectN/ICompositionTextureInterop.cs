#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d528a265-f0a5-422f-a39d-ef62d7cd1cc4")]
public partial interface ICompositionTextureInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableFence(out ulong fenceValue, in Guid iid, out nint availableFence);
}
