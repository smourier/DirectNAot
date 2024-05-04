#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8565572f-c094-41cc-b56e-10bd9c3ff044")]
public partial interface ISpContainerLexicon : ISpLexicon
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddLexicon(ISpLexicon? pAddLexicon, uint dwFlags);
}
