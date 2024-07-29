#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("6cda2dc7-9013-4522-9970-2a9dd9ead5a3")]
public partial interface IXFeedItem2 : IXFeedItem
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EffectiveId(out uint puiEffectiveId);
}
