using Microsoft.CodeAnalysis;

namespace NewBlood.Interop.Steamworks.SourceGenerator;

internal sealed record TypeRecord(string Name, string FullName)
{
    public TypeRecord(ITypeSymbol symbol)
        : this(symbol.Name, symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
    {
    }
}
