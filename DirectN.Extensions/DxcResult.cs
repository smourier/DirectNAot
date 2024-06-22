namespace DirectN;

public class DxcResult(IComObject<IDxcResult> result) : DxcResult<IDxcResult>(result) { }
public class DxcResult<T> : InterlockedComObject<T> where T : IDxcResult
{
    private readonly List<DxcResultOutput> _outputs = [];

    public DxcResult(IComObject<T> result)
        : base(result)
    {
        ArgumentNullException.ThrowIfNull(result);

        var count = result.Object.GetNumOutputs();
        for (uint i = 0; i < count; i++)
        {
            var type = result.Object.GetOutputByIndex(i);
            if (type == DXC_OUT_KIND.DXC_OUT_NONE)
                continue;

            var output = new DxcResultOutput(type);
            result.Object.GetOutput(type, typeof(IDxcBlob).GUID, out var ppv, out var name);
            if (ppv != 0)
            {
                output.Blob = new DxcBlob(DirectN.Extensions.Com.ComObject.FromPointer<IDxcBlob>(ppv)!);
                var t = output.Blob.Text;
                Marshal.Release(ppv);
            }

            if (name != null)
            {
                output.Name = ((ID3DBlob)name).GetUnicodeStringFromBlob();
            }
            _outputs.Add(output);
        }

        PrimaryOutput = result.Object.PrimaryOutput();
        if (result.Object.GetErrorBuffer(out var encoding).IsSuccess)
        {
            using var blob = new ComObject<IDxcBlob>(encoding);
            using var errorBlob = new DxcBlob(blob);
            Error = errorBlob.Text;
        }

        result.Object.GetResult(out var res);
        if (res != null)
        {
            Result = new DxcBlob(new ComObject<IDxcBlob>(res));
        }

        result.Object.GetStatus(out var status);
        Status = status;
    }

    public DXC_OUT_KIND PrimaryOutput { get; }
    public DxcBlob? Result { get; }
    public HRESULT Status { get; }
    public string? Error { get; private set; }
    public IReadOnlyList<DxcResultOutput> Outputs => _outputs.AsReadOnly();

    public virtual void ThrowOnError()
    {
        if (Status.IsOk)
            return;

        throw new COMException(Error.Nullify() ?? "An error has occured", Status.Value);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Result?.Dispose();
        }
        base.Dispose(disposing);
    }
}
