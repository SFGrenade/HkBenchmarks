using System.Reflection;
using Modding;

// ReSharper disable StringLiteralTypo
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace Benchmarking.Utils;

public static class Utils
{
    public static void SetAttr<TSelf, TVal>(this TSelf self, string name, TVal val)
    {
        ReflectionHelper.SetField<TSelf, TVal>(self, name, val);
    }

    public static TVal GetAttr<TSelf, TVal>(this TSelf self, string name)
    {
        return ReflectionHelper.GetField<TSelf, TVal>(self, name);
    }
}
