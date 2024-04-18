namespace DirectN;

[GeneratedComInterface, Guid("511e025f-d6cb-43be-bf65-63fe88515a39")]
public partial interface IPartFont2 : IPartFont
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontRestriction(out EXpsFontRestriction pRestriction);
}
