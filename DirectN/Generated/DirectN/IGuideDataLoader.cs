#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4764ff7c-fa95-4525-af4d-d32236db9e38")]
public partial interface IGuideDataLoader
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init(IGuideData pGuideStore);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Terminate();
}
