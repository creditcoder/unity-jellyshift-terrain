using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public sealed class AndroidJNIHelper
	{
		public static bool debug
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[GeneratedByOldBindingsGenerator]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[GeneratedByOldBindingsGenerator]
			set;
		}

		private AndroidJNIHelper()
		{
		}

		[ExcludeFromDocs]
		public static IntPtr GetConstructorID(IntPtr javaClass)
		{
			string signature = "";
			return GetConstructorID(javaClass, signature);
		}

		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue("\"\"")] string signature)
		{
			return _AndroidJNIHelper.GetConstructorID(javaClass, signature);
		}

		[ExcludeFromDocs]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature)
		{
			bool isStatic = false;
			return GetMethodID(javaClass, methodName, signature, isStatic);
		}

		[ExcludeFromDocs]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
		{
			bool isStatic = false;
			string signature = "";
			return GetMethodID(javaClass, methodName, signature, isStatic);
		}

		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue("\"\"")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return _AndroidJNIHelper.GetMethodID(javaClass, methodName, signature, isStatic);
		}

		[ExcludeFromDocs]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature)
		{
			bool isStatic = false;
			return GetFieldID(javaClass, fieldName, signature, isStatic);
		}

		[ExcludeFromDocs]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
		{
			bool isStatic = false;
			string signature = "";
			return GetFieldID(javaClass, fieldName, signature, isStatic);
		}

		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue("\"\"")] string signature, [DefaultValue("false")] bool isStatic)
		{
			return _AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, isStatic);
		}

		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			return _AndroidJNIHelper.CreateJavaRunnable(jrunnable);
		}

		[ThreadAndSerializationSafe]
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			INTERNAL_CALL_CreateJavaProxy(proxy, out IntPtr value);
			return value;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		[GeneratedByOldBindingsGenerator]
		private static extern void INTERNAL_CALL_CreateJavaProxy(AndroidJavaProxy proxy, out IntPtr value);

		public static IntPtr ConvertToJNIArray(Array array)
		{
			return _AndroidJNIHelper.ConvertToJNIArray(array);
		}

		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			return _AndroidJNIHelper.CreateJNIArgArray(args);
		}

		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
			_AndroidJNIHelper.DeleteJNIArgArray(args, jniArgs);
		}

		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			return _AndroidJNIHelper.GetConstructorID(jclass, args);
		}

		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return _AndroidJNIHelper.GetMethodID(jclass, methodName, args, isStatic);
		}

		public static string GetSignature(object obj)
		{
			return _AndroidJNIHelper.GetSignature(obj);
		}

		public static string GetSignature(object[] args)
		{
			return _AndroidJNIHelper.GetSignature(args);
		}

		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			return _AndroidJNIHelper.ConvertFromJNIArray<ArrayType>(array);
		}

		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			return _AndroidJNIHelper.GetMethodID<ReturnType>(jclass, methodName, args, isStatic);
		}

		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return _AndroidJNIHelper.GetFieldID<FieldType>(jclass, fieldName, isStatic);
		}

		public static string GetSignature<ReturnType>(object[] args)
		{
			return _AndroidJNIHelper.GetSignature<ReturnType>(args);
		}
	}
}
