using System.Reflection.Emit;
using ILDelegateCreation;

namespace ILDelegateHelpers;

public static partial class ILDelegate
{
    public static Func<TOut> CreateFunc<TOut>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Func<TOut>>(
            Type.EmptyTypes, typeof(TOut), generatorInit);
    }

    public static Func<T1, TOut> CreateFunc<T1, TOut>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Func<T1, TOut>>(
            new[] { typeof(T1) }, typeof(TOut), generatorInit);
    }

    public static Func<T1, T2, TOut> CreateFunc<T1, T2, TOut>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Func<T1, T2, TOut>>(
            new[] { typeof(T1), typeof(T2) }, typeof(TOut), generatorInit);
    }

    public static Func<T1, T2, T3, TOut> CreateFunc<T1, T2, T3, TOut>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Func<T1, T2, T3, TOut>>(
            new[] { typeof(T1), typeof(T2), typeof(T3) }, typeof(TOut), generatorInit);
    }

    public static Func<T1, T2, T3, T4, TOut> CreateFunc<T1, T2, T3, T4, TOut>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Func<T1, T2, T3, T4, TOut>>(
            new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, typeof(TOut), generatorInit);
    }
}