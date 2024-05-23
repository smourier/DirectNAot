#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-icreatedevenum
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("29840822-5b84-11d0-bd3b-00a0c911ce86")]
public partial interface ICreateDevEnum
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icreatedevenum-createclassenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateClassEnumerator(in Guid clsidDeviceClass, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumMoniker>))] out IEnumMoniker ppEnumMoniker, uint dwFlags);
}
