namespace DirectN;

public sealed class D2D1Property
{
    internal D2D1Property(D2D1_PROPERTY_TYPE type)
    {
        Type = type;
    }

    [AllowNull]
    public string Name { get; internal set; }
    public D2D1_PROPERTY_TYPE Type { get; }
    public byte[]? ValueBytes { get; internal set; }

    [AllowNull]
    public IReadOnlyList<D2D1Property> SubProperties { get; internal set; }
    public object? Value => GetValue(Type, ValueBytes, false);

    public override string ToString() => Type + " " + Name + " = " + Value;

    public static object? GetValue(D2D1_PROPERTY_TYPE type, byte[]? data, bool throwOnError = true)
    {
        if (data == null)
        {
            if (throwOnError)
                throw new ArgumentNullException(nameof(data));

            return null;
        }

        unsafe
        {
            fixed (byte* ptr = data)
            {
                switch (type)
                {
                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BOOL:
                        return *(bool*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_CLSID:
                        return *(Guid*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ENUM:
                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32:
                        return *(int*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32:
                        return *(uint*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT:
                        return *(float*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING:
                        // buffer contains a terminating zero
                        return Encoding.Unicode.GetString(data, 0, data.Length - 2);

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR2:
                        return *(D2D_VECTOR_2F*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR3:
                        return *(D2D_VECTOR_3F*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR4:
                        return *(D2D_VECTOR_4F*)ptr;

                    case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_3X2:
                        return *(D2D_MATRIX_3X2_F*)ptr;

                    default:
                        if (throwOnError)
                            throw new NotSupportedException("Value of type '" + type + "' is not supported.");

                        return null;
                }
            }
        }
    }
}
