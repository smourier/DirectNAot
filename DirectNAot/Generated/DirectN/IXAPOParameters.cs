#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapo/nn-xapo-ixapoparameters
[GeneratedComInterface, Guid("26d95c66-80f2-499a-ad54-5ae7f01c6d98")]
public partial interface IXAPOParameters
{
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapoparameters-setparameters
    [PreserveSig]
    void SetParameters(nint pParameters, uint ParameterByteSize);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapoparameters-getparameters
    [PreserveSig]
    void GetParameters(nint pParameters, uint ParameterByteSize);
}
