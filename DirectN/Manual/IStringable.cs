namespace DirectN;

[GeneratedComInterface, Guid("96369f54-8eb6-48f0-abce-c1b211e627c3")]
public partial interface IStringable : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ToString(out HSTRING value);
}
