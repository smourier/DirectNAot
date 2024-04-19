namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmperroritem2
[GeneratedComInterface, Guid("f75ccec0-c67c-475c-931e-8719870bee7d")]
public partial interface IWMPErrorItem2 : IWMPErrorItem
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperroritem2-get_condition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_condition(ref int plCondition);
}
