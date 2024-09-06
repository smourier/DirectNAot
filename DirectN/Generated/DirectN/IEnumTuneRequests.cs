#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-ienumtunerequests
[GeneratedComInterface, Guid("1993299c-ced6-4788-87a3-420067dce0c7")]
public partial interface IEnumTuneRequests
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumtunerequests-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuneRequest>))] out ITuneRequest ppprop, out uint pcelt);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumtunerequests-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumtunerequests-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ienumtunerequests-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTuneRequests>))] out IEnumTuneRequests ppenum);
}
