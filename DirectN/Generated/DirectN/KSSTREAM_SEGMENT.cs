#nullable enable
namespace DirectN;

public partial struct KSSTREAM_SEGMENT
{
    public nint KsInterfaceHandler;
    public nint KsDataTypeHandler;
    public KSIOOPERATION IoOperation;
    public HANDLE CompletionEvent;
}
