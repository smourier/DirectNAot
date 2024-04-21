namespace DirectN;

[GeneratedComInterface, Guid("b8aab0cf-346f-49d8-9499-c8b03f161d51")]
public partial interface ISpObjectTokenInit : ISpObjectToken
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitFromDataKey(PWSTR pszCategoryId, PWSTR pszTokenId, ISpDataKey? pDataKey);
}
