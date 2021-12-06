public static class DynamicPInvokeFactory
    {
        static DynamicPInvokeFactory()
        {
            string asmName = "DynamicPInvokeFactory" + DateTime.Now.Ticks;
            asmBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName($"{asmName}{DateTime.Now.Ticks}"), AssemblyBuilderAccess.Run);
            moduleBuilder = asmBuilder.DefineDynamicModule($"{asmName}_Module");
        }
        static readonly AssemblyBuilder asmBuilder;
        static readonly ModuleBuilder moduleBuilder;
        public static T GetPInvokeMethod<T>(string dllPath) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, pas.ToArray(),
                CallingConvention.StdCall, CallingConventions.Standard,
                CharSet.Auto, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        public static T GetPInvokeMethod<T>(string dllPath, CallingConvention callingConvention) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, pas.ToArray(),
                callingConvention, CallingConventions.Standard,
                CharSet.Auto, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        public static T GetPInvokeMethod<T>(string dllPath, CharSet charSet) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, pas.ToArray(),
                CallingConvention.StdCall, CallingConventions.Standard,
                charSet, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        public static T GetPInvokeMethod<T>(string dllPath, CallingConvention callingConvention, CharSet charSet) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, null, pas.ToArray(),
                callingConvention, CallingConventions.Standard,
                charSet, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        public static T GetPInvokeMethod<T>(string dllPath, string entryPoint) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, entryPoint, pas.ToArray(),
                CallingConvention.StdCall, CallingConventions.Standard,
                CharSet.Auto, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        public static T GetPInvokeMethod<T>(string dllPath, string entryPoint, CallingConvention callingConvention) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, entryPoint, pas.ToArray(),
                callingConvention, CallingConventions.Standard,
                CharSet.Auto, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        public static T GetPInvokeMethod<T>(string dllPath, string entryPoint, CharSet charSet) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, entryPoint, pas.ToArray(),
                CallingConvention.StdCall, CallingConventions.Standard,
                charSet, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        public static T GetPInvokeMethod<T>(string dllPath, string entryPoint, CallingConvention callingConvention, CharSet charSet) where T : Delegate
        {
            Type delType = typeof(T);
            MethodInfo delMethod = delType.GetMethod("Invoke");
            List<ParameterInfo> parameters = delMethod.GetParameters().ToList();
            List<ParameterAttributes> pas = new List<ParameterAttributes>();
            foreach (ParameterInfo pi in parameters)
                pas.Add(pi.Attributes);
            return (T)GetPInvokeMethod(delType.Name, dllPath, delMethod.ReturnType, entryPoint, pas.ToArray(),
                callingConvention, CallingConventions.Standard,
                charSet, parameters.Select(x => x.ParameterType).Select(x => x.IsByRef ? x.GetElementType() : x).ToArray())
                .CreateDelegate(typeof(T));
        }
        static MethodInfo GetPInvokeMethod(string methodName, string dllPath, Type returnType, string entryPoint= null, ParameterAttributes[] parameterAttributesArray = null, CallingConvention callingConvention = CallingConvention.StdCall, CallingConventions callingConventions = CallingConventions.Standard, CharSet charSet = CharSet.Auto, params Type[] parameterTypes)
        {
            TypeBuilder typeBuilder = moduleBuilder.DefineType($"{moduleBuilder.Name}.Type{DateTime.Now.Ticks}", TypeAttributes.Public | TypeAttributes.Class);
            MethodBuilder methodBuilder;
            if (entryPoint != null)
            {
                methodBuilder = typeBuilder.DefinePInvokeMethod(methodName, dllPath, entryPoint, MethodAttributes.Public | MethodAttributes.Static,
                                                                            callingConventions, returnType, parameterTypes, callingConvention, charSet);
            }
            else
            {
                methodBuilder = typeBuilder.DefinePInvokeMethod(methodName, dllPath, MethodAttributes.Public | MethodAttributes.Static,
                                                                            callingConventions, returnType, parameterTypes, callingConvention, charSet);
            }
            if (parameterAttributesArray != null)
            {
                for (int i = 0; i < parameterTypes.Length; i++)
                    methodBuilder.DefineParameter(i + 1, parameterAttributesArray[i], $"param{i}");
            }
            else
            {
                for (int i = 0; i < parameterTypes.Length; i++)
                    methodBuilder.DefineParameter(i + 1, ParameterAttributes.None, $"param{i}");
            }
            //methodBuilder.SetImplementationFlags(MethodImplAttributes.Unmanaged | MethodImplAttributes.Native);
            return typeBuilder.CreateType().GetMethod(methodName);
        }
    }
