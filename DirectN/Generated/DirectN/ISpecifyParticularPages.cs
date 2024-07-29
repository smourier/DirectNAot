#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4c437b91-6e9e-11d1-a704-006097c4e476")]
public partial interface ISpecifyParticularPages
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPages(in Guid guidWhatPages, out CAUUID pPages);
}
