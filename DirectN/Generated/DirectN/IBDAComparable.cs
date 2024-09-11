#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ibdacomparable
[GeneratedComInterface, Guid("b34505e0-2f0e-497b-80bc-d43f3b24ed7f")]
public partial interface IBDAComparable
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibdacomparable-compareexact
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompareExact([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch CompareTo, out int Result);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibdacomparable-compareequivalent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompareEquivalent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] IDispatch CompareTo, uint dwFlags, out int Result);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibdacomparable-hashexact
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HashExact(out long Result);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibdacomparable-hashexactincremental
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HashExactIncremental(long PartialResult, out long Result);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibdacomparable-hashequivalent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HashEquivalent(uint dwFlags, out long Result);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibdacomparable-hashequivalentincremental
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HashEquivalentIncremental(long PartialResult, uint dwFlags, out long Result);
}
