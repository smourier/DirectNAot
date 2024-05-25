#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextstoryranges
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8cc497c5-a1df-11ce-8098-00aa0047be5d")]
public partial interface ITextStoryRanges : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstoryranges-_newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT _NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppunkEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstoryranges-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange>))] out ITextRange ppRange);
    
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstoryranges-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out int pCount);
}
