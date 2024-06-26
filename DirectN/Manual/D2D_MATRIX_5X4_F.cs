﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D2D_MATRIX_5X4_F(
    float m11, float m12, float m13, float m14,
    float m21, float m22, float m23, float m24,
    float m31, float m32, float m33, float m34,
    float m41, float m42, float m43, float m44,
    float m51, float m52, float m53, float m54
    )
{
    public float _11 = m11;
    public float _12 = m12;
    public float _13 = m13;
    public float _14 = m14;
    public float _21 = m21;
    public float _22 = m22;
    public float _23 = m23;
    public float _24 = m24;
    public float _31 = m31;
    public float _32 = m32;
    public float _33 = m33;
    public float _34 = m34;
    public float _41 = m41;
    public float _42 = m42;
    public float _43 = m43;
    public float _44 = m44;
    public float _51 = m51;
    public float _52 = m52;
    public float _53 = m53;
    public float _54 = m54;

    public readonly float[] ToArray() => [
        _11, _12, _13, _14,
        _21, _22, _23, _24,
        _31, _32, _33, _34,
        _41, _42, _43, _44,
        _51, _52, _53, _54,
    ];
}
