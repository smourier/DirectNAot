namespace DirectN;

[GeneratedComInterface, Guid("bf02fb7e-9792-4e10-a68d-033a2cc246a5")]
public partial interface IGenericDescriptor2 : IGenericDescriptor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint /* byte array */ pbDesc, ushort wCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(out ushort pwVal);
}
