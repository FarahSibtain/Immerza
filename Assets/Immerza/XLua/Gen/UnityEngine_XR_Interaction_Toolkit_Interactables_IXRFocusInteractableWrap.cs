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
    public class UnityEngineXRInteractionToolkitInteractablesIXRFocusInteractableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 9, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFocusEntering", _m_OnFocusEntering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFocusEntered", _m_OnFocusEntered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFocusExiting", _m_OnFocusExiting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnFocusExited", _m_OnFocusExited);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstFocusEntered", _g_get_firstFocusEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastFocusExited", _g_get_lastFocusExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusEntered", _g_get_focusEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusExited", _g_get_focusExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionGroupsFocusing", _g_get_interactionGroupsFocusing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstInteractionGroupFocusing", _g_get_firstInteractionGroupFocusing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFocused", _g_get_isFocused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusMode", _g_get_focusMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canFocus", _g_get_canFocus);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFocusEntering(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs));
                    
                    gen_to_be_invoked.OnFocusEntering( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFocusEntered(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs));
                    
                    gen_to_be_invoked.OnFocusEntered( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFocusExiting(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs));
                    
                    gen_to_be_invoked.OnFocusExiting( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnFocusExited(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs));
                    
                    gen_to_be_invoked.OnFocusExited( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstFocusEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.firstFocusEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastFocusExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lastFocusExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.focusEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.focusExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionGroupsFocusing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionGroupsFocusing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstInteractionGroupFocusing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.firstInteractionGroupFocusing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFocused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isFocused);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.focusMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canFocus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
