﻿using System;
using System.Collections.Generic;
using System.Reflection;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Collections_Generic_Dictionary_2_ILTypeInstance_Int32_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodInfo method;
            Type[] args;
            Type type = typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>);
            args = new Type[]{};
            method = type.GetMethod("get_Comparer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Comparer_0);
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_1);
            args = new Type[]{};
            method = type.GetMethod("get_Keys", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Keys_2);
            args = new Type[]{};
            method = type.GetMethod("get_Values", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Values_3);
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_4);
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance), typeof(System.Int32)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_5);
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance), typeof(System.Int32)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_6);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_7);
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetMethod("ContainsKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ContainsKey_8);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ContainsValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ContainsValue_9);
            args = new Type[]{};
            method = type.GetMethod("GetEnumerator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnumerator_10);
            args = new Type[]{typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext)};
            method = type.GetMethod("GetObjectData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetObjectData_11);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("OnDeserialization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDeserialization_12);
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_13);
            args = new Type[]{typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("TryGetValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetValue_14);

        }

        static StackObject* get_Comparer_0(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Comparer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Count_1(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Keys_2(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Keys;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Values_3(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Values;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Item_4(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[key];

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Item_5(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[key] = value;

            return __ret;
        }

        static StackObject* Add_6(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(key, value);

            return __ret;
        }

        static StackObject* Clear_7(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* ContainsKey_8(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ContainsKey(key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ContainsValue_9(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ContainsValue(value);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetEnumerator_10(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnumerator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetObjectData_11(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Runtime.Serialization.StreamingContext context = (System.Runtime.Serialization.StreamingContext)typeof(System.Runtime.Serialization.StreamingContext).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Runtime.Serialization.SerializationInfo info = (System.Runtime.Serialization.SerializationInfo)typeof(System.Runtime.Serialization.SerializationInfo).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GetObjectData(info, context);

            return __ret;
        }

        static StackObject* OnDeserialization_12(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object sender = (System.Object)typeof(System.Object).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDeserialization(sender);

            return __ret;
        }

        static StackObject* Remove_13(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Remove(key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetValue_14(ILIntepreter __intp, StackObject* __esp, List<object> __mStack, CLRMethod __method)
        {
            ILRuntime.Runtime.Enviorment.AppDomain domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ILRuntime.Runtime.Intepreter.ILTypeInstance key = (ILRuntime.Runtime.Intepreter.ILTypeInstance)typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)typeof(System.Collections.Generic.Dictionary<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>).CheckCLRTypes(domain, StackObject.ToObject(ptr_of_this_method, domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryGetValue(key, out value);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var dst = *(StackObject**)&ptr_of_this_method->Value;
                        dst->ObjectType = ObjectTypes.Integer;
                        dst->Value = value;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var obj = __mStack[ptr_of_this_method->Value];
                        if(obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)obj)[ptr_of_this_method->ValueLow] = value;
                        }
                        else
                        {
                            var t = domain.GetType(obj.GetType()) as CLRType;
                            t.Fields[ptr_of_this_method->ValueLow].SetValue(obj, value);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = value;
                        }
                        else
                        {
                            ((CLRType)t).Fields[ptr_of_this_method->ValueLow].SetValue(null, value);
                        }
                    }
                    break;
            }

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


    }
}
