#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tom/nn-tom-itextstoryranges2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c241f5e5-7206-11d8-a2c7-00a0d1d6c6b3")]
public partial interface ITextStoryRanges2 : ITextStoryRanges
{
    // https://learn.microsoft.com/windows/win32/api/tom/nf-tom-itextstoryranges2-item2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item2(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITextRange2>))] out ITextRange2 ppRange);
}
