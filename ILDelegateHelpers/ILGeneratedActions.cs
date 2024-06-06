using System.Reflection.Emit;
using ILDelegateCreation;

namespace ILDelegateHelpers;

public static partial class ILDelegate
{
    public static Action CreateAction(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Action>(
            Type.EmptyTypes, generatorInit);
    }

    public static Action<T1> CreateAction<T1>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Action<T1>>(
            new[] { typeof(T1) }, generatorInit);
    }

    public static Action<T1, T2> CreateAction<T1, T2>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Action<T1, T2>>(
            new[] { typeof(T1), typeof(T2) }, generatorInit);
    }

    public static Action<T1, T2, T3> CreateAction<T1, T2, T3>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Action<T1, T2, T3>>(
            new[] { typeof(T1), typeof(T2), typeof(T3) }, generatorInit);
    }

    public static Action<T1, T2, T3, T4> CreateAction<T1, T2, T3, T4>(Action<ILGenerator> generatorInit)
    {
        return ILDelegateCreator.CreateDelegate<Action<T1, T2, T3, T4>>(
            new[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4) }, generatorInit);
    }
}