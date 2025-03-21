#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    
    public class UnityEngineInputSystemInputActionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.InputSystem.InputActionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.InputSystem.InputActionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.InputSystem.InputActionType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Value", UnityEngine.InputSystem.InputActionType.Value);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Button", UnityEngine.InputSystem.InputActionType.Button);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PassThrough", UnityEngine.InputSystem.InputActionType.PassThrough);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.InputSystem.InputActionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineInputSystemInputActionType(L, (UnityEngine.InputSystem.InputActionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Value"))
                {
                    translator.PushUnityEngineInputSystemInputActionType(L, UnityEngine.InputSystem.InputActionType.Value);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Button"))
                {
                    translator.PushUnityEngineInputSystemInputActionType(L, UnityEngine.InputSystem.InputActionType.Button);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PassThrough"))
                {
                    translator.PushUnityEngineInputSystemInputActionType(L, UnityEngine.InputSystem.InputActionType.PassThrough);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.InputSystem.InputActionType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.InputSystem.InputActionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineInputSystemInputActionChangeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.InputSystem.InputActionChange), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.InputSystem.InputActionChange), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.InputSystem.InputActionChange), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActionEnabled", UnityEngine.InputSystem.InputActionChange.ActionEnabled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActionDisabled", UnityEngine.InputSystem.InputActionChange.ActionDisabled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActionMapEnabled", UnityEngine.InputSystem.InputActionChange.ActionMapEnabled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActionMapDisabled", UnityEngine.InputSystem.InputActionChange.ActionMapDisabled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActionStarted", UnityEngine.InputSystem.InputActionChange.ActionStarted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActionPerformed", UnityEngine.InputSystem.InputActionChange.ActionPerformed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActionCanceled", UnityEngine.InputSystem.InputActionChange.ActionCanceled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BoundControlsAboutToChange", UnityEngine.InputSystem.InputActionChange.BoundControlsAboutToChange);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BoundControlsChanged", UnityEngine.InputSystem.InputActionChange.BoundControlsChanged);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.InputSystem.InputActionChange), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineInputSystemInputActionChange(L, (UnityEngine.InputSystem.InputActionChange)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ActionEnabled"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.ActionEnabled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ActionDisabled"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.ActionDisabled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ActionMapEnabled"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.ActionMapEnabled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ActionMapDisabled"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.ActionMapDisabled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ActionStarted"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.ActionStarted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ActionPerformed"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.ActionPerformed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ActionCanceled"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.ActionCanceled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BoundControlsAboutToChange"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.BoundControlsAboutToChange);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BoundControlsChanged"))
                {
                    translator.PushUnityEngineInputSystemInputActionChange(L, UnityEngine.InputSystem.InputActionChange.BoundControlsChanged);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.InputSystem.InputActionChange!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.InputSystem.InputActionChange! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}