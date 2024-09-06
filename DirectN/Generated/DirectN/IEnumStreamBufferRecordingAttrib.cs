#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-ienumstreambufferrecordingattrib
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c18a9162-1e82-4142-8c73-5690fa62fe33")]
public partial interface IEnumStreamBufferRecordingAttrib
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-ienumstreambufferrecordingattrib-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint cRequest, [In][Out][MarshalUsing(CountElementName = nameof(cRequest))] STREAMBUFFER_ATTRIBUTE[] pStreamBufferAttribute, out uint pcReceived);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-ienumstreambufferrecordingattrib-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint cRecords);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-ienumstreambufferrecordingattrib-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-ienumstreambufferrecordingattrib-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumStreamBufferRecordingAttrib>))] out IEnumStreamBufferRecordingAttrib ppIEnumStreamBufferAttrib);
}
