namespace DirectN;

[GeneratedComInterface, Guid("b5ade81e-0e61-4fe1-81c6-c333e4ffe0f1")]
public partial interface IPrintSchemaParameterDefinition : IPrintSchemaDisplayableElement
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_UserInputRequired([MarshalAs(UnmanagedType.U4)] out bool pbIsRequired);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_UnitType(out BSTR pbstrUnitType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_DataType(out PrintSchemaParameterDataType pDataType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_RangeMin(out int pRangeMin);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_RangeMax(out int pRangeMax);
}
