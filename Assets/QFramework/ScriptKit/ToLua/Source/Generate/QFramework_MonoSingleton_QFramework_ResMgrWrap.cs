﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class QFramework_MonoSingleton_QFramework_ResMgrWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(QFramework.MonoSingleton<QFramework.ResMgr>), typeof(UnityEngine.MonoBehaviour), "MonoSingleton_QFramework_ResMgr");
		L.RegFunction("OnSingletonInit", OnSingletonInit);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSingletonInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			QFramework.MonoSingleton<QFramework.ResMgr> obj = (QFramework.MonoSingleton<QFramework.ResMgr>)ToLua.CheckObject<QFramework.MonoSingleton<QFramework.ResMgr>>(L, 1);
			obj.OnSingletonInit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			QFramework.MonoSingleton<QFramework.ResMgr> obj = (QFramework.MonoSingleton<QFramework.ResMgr>)ToLua.CheckObject<QFramework.MonoSingleton<QFramework.ResMgr>>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, QFramework.MonoSingleton<QFramework.ResMgr>.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

