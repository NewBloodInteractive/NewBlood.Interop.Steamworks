using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace NewBlood.Interop.Steamworks.SourceGenerator;

internal sealed record MethodRecord(string Name, TypeRecord ContainingType, TypeRecord ReturnType, EquatableArray<ParameterRecord> Parameters, bool IsObsolete)
{
    public MethodRecord(IMethodSymbol symbol)
        : this(symbol.Name, new(symbol.ContainingType), new(symbol.ReturnType), GetParameters(symbol), GetIsObsolete(symbol))
    {
    }

    private static ImmutableArray<ParameterRecord> GetParameters(IMethodSymbol symbol)
    {
        var parameters = ImmutableArray.CreateBuilder<ParameterRecord>(symbol.Parameters.Length);

        for (int i = 0; i < symbol.Parameters.Length; i++)
        {
            var parameter = symbol.Parameters[i];
            var type      = new TypeRecord(parameter.Type);
            parameters.Add(new ParameterRecord(type, parameter.Name));
        }

        return parameters.MoveToImmutable();
    }

    private static bool GetIsObsolete(IMethodSymbol symbol)
    {
        foreach (var attribute in symbol.GetAttributes())
        {
            if (attribute.AttributeClass is
                {
                    Name: "ObsoleteAttribute",
                    ContainingNamespace.Name: "System"
                })
            {
                return true;
            }
        }

        return false;
    }
}
