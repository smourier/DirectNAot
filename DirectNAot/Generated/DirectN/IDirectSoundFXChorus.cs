#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("880842e3-145f-43e6-a934-a71806e50547")]
public partial interface IDirectSoundFXChorus
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXChorus pcDsFxChorus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXChorus pDsFxChorus);
}
