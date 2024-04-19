namespace DirectN;

[GeneratedComInterface, Guid("79ac9ef4-f9c1-4d2b-a50b-a7ffba4dcf37")]
public partial interface IFeedItem2 : IFeedItem
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EffectiveId(out int effectiveId);
}
