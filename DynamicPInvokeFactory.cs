using System;
using System.Linq;
using System.Security;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[SuppressUnmanagedCodeSecurity]
public static class DynamicPInvokeFactory
{
    public static unsafe IntPtr GetAddress(this object o)
    {
        TypedReference tr = __makeref(o);
        return **(IntPtr**)&tr;
    }
    static DynamicPInvokeFactory()
    {
        string asmName = "DynamicPInvokeFactory" + new object().GetAddress();
        asmBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(asmName), AssemblyBuilderAccess.RunAndSave);
        moduleBuilder = asmBuilder.DefineDynamicModule($"Module", "PInvoke.dll", true);
    }
    static int TypeCount;
    static readonly AssemblyBuilder asmBuilder;
    static readonly ModuleBuilder moduleBuilder;
    public static void Save(string path) => asmBuilder.Save(path);
    public static T GetPInvokeMethod<T>(string dllPath) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, parametersArray,
            CallingConvention.StdCall, CallingConventions.Standard,
            CharSet.Auto, parameters.Select(x => x.ParameterType).ToArray())
            .CreateDelegate(typeof(T));
        return t;
    }
    public static T GetPInvokeMethod<T>(string dllPath, CallingConvention callingConvention) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, parametersArray,
            callingConvention, CallingConventions.Standard,
            CharSet.Auto, parameters.Select(x => x.ParameterType).ToArray())
            .CreateDelegate(typeof(T));
        return t;
    }
    public static T GetPInvokeMethod<T>(string dllPath, CharSet charSet) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, parametersArray,
            CallingConvention.StdCall, CallingConventions.Standard,
            charSet, parameters.Select(x => x.ParameterType).ToArray())
            .CreateDelegate(typeof(T));
        return t;
    }
    public static T GetPInvokeMethod<T>(string dllPath, CallingConvention callingConvention, CharSet charSet) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, parametersArray,
             callingConvention, CallingConventions.Standard,
             charSet, parameters.Select(x => x.ParameterType).ToArray())
             .CreateDelegate(typeof(T));
        return t;
    }
    public static T GetPInvokeMethod<T>(string dllPath, string entryPoint) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, entryPoint, parametersArray,
            CallingConvention.StdCall, CallingConventions.Standard,
            CharSet.Auto, parameters.Select(x => x.ParameterType).ToArray())
            .CreateDelegate(typeof(T));
        return t;
    }
    public static T GetPInvokeMethod<T>(string dllPath, string entryPoint, CallingConvention callingConvention) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, entryPoint, parametersArray,
            callingConvention, CallingConventions.Standard,
            CharSet.Auto, parameters.Select(x => x.ParameterType).ToArray())
            .CreateDelegate(typeof(T));
        return t;
    }
    public static T GetPInvokeMethod<T>(string dllPath, string entryPoint, CharSet charSet) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, entryPoint, parametersArray,
            CallingConvention.StdCall, CallingConventions.Standard,
            charSet, parameters.Select(x => x.ParameterType).ToArray())
            .CreateDelegate(typeof(T));
        return t;
    }
    public static T GetPInvokeMethod<T>(string dllPath, string entryPoint, CallingConvention callingConvention, CharSet charSet) where T : Delegate
    {
        Type delType = typeof(T);
        MethodInfo delMethod = delType.GetMethod("Invoke");
        var parametersArray = delMethod.GetParameters();
        List<ParameterInfo> parameters = parametersArray.ToList();
        T t = (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, parametersArray,
            CallingConvention.StdCall, CallingConventions.Standard,
            CharSet.Auto, parameters.Select(x => x.ParameterType).ToArray())
            .CreateDelegate(typeof(T));
        return t;
    }
    public static MethodInfo GetPInvokeMethod(string dllPath, string methodName, string entryPoint, Type returnType, Type[] parameterTypes, CallingConvention callingConvention, CharSet charSet)
    {
        return GetPInvokeMethod(methodName, dllPath, returnType, entryPoint, null, callingConvention, CallingConventions.Standard, charSet, parameterTypes);
    }
    public static MethodInfo GetPInvokeMethod(string dllPath, string methodName, Type returnType, Type[] parameterTypes, CallingConvention callingConvention, CharSet charSet)
    {
        return GetPInvokeMethod(methodName, dllPath, returnType, null, null, callingConvention, CallingConventions.Standard, charSet, parameterTypes);
    }
    static MethodInfo GetPInvokeMethod(string methodName, string dllPath, Type returnType, string entryPoint = null, ParameterInfo[] parameters = null, CallingConvention callingConvention = CallingConvention.StdCall, CallingConventions callingConventions = CallingConventions.Standard, CharSet charSet = CharSet.Auto, params Type[] parameterTypes)
    {
        TypeBuilder typeBuilder = moduleBuilder.DefineType($"PInvoke.Type{TypeCount}", TypeAttributes.Public | TypeAttributes.Class);
        MethodBuilder methodBuilder;
        if (entryPoint != null)
            methodBuilder = typeBuilder.DefinePInvokeMethod(methodName, dllPath, entryPoint, MethodAttributes.Public | MethodAttributes.Static, callingConventions, returnType, parameterTypes, callingConvention, charSet);
        else
            methodBuilder = typeBuilder.DefinePInvokeMethod(methodName, dllPath, MethodAttributes.Public | MethodAttributes.Static, callingConventions, returnType, parameterTypes, callingConvention, charSet);
        if (parameters != null)
            for (int i = 0; i < parameters.Length; i++)
                methodBuilder.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
        else
            for (int i = 0; i < parameterTypes.Length; i++)
                methodBuilder.DefineParameter(i + 1, ParameterAttributes.None, $"{i}_{parameterTypes[i].Name}");
        methodBuilder.SetImplementationFlags(methodBuilder.MethodImplementationFlags | MethodImplAttributes.PreserveSig);
        TypeCount++;
        return typeBuilder.CreateType().GetMethod(methodName);
    }
}
