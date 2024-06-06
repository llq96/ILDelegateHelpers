using System.Reflection.Emit;

namespace ILDelegateCreation;

internal static class ILDelegateCreator
{
    internal static TDelegate CreateDelegate<TDelegate>(
        Type[] parameterTypes,
        Action<ILGenerator> generatorInit)
        where TDelegate : Delegate
    {
        return CreateDelegate<TDelegate>(parameterTypes, null, generatorInit);
    }

    internal static TDelegate CreateDelegate<TDelegate>(
        Type[] parameterTypes,
        Type? returnType,
        Action<ILGenerator> generatorInit)
        where TDelegate : Delegate
    {
        var name = Guid.NewGuid().ToString();
        var dynamicMethod = new DynamicMethod(name, returnType, parameterTypes);
        var ilGenerator = dynamicMethod.GetILGenerator();

        generatorInit(ilGenerator);

        ilGenerator.Emit(OpCodes.Ret);

        return (TDelegate)dynamicMethod.CreateDelegate(typeof(TDelegate));
    }
}