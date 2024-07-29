#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("02ef04dd-7580-11d1-bece-00c04fb6e937")]
public partial interface IAMRebuild
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RebuildNow();
}
