using System;
using System.Diagnostics;

namespace NewBlood.Interop.Steamworks;

[Conditional("SOURCE_GENERATOR")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
internal sealed class GenerateMemberFunctionAttribute : Attribute
{
    public string Name { get; }

    public GenerateMemberFunctionAttribute(string name)
    {
        Name = name;
    }
}
