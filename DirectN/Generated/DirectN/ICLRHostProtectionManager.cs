#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("89f25f5c-ceef-43e1-9cfa-a68ce863aaac")]
public partial interface ICLRHostProtectionManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProtectedCategories(EApiCategories categories);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEagerSerializeGrantSets();
}
