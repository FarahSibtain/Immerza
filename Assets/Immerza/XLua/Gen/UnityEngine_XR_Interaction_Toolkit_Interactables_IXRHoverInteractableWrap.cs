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
    public class UnityEngineXRInteractionToolkitInteractablesIXRHoverInteractableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 6, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHoverableBy", _m_IsHoverableBy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverEntering", _m_OnHoverEntering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverEntered", _m_OnHoverEntered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverExiting", _m_OnHoverExiting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverExited", _m_OnHoverExited);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstHoverEntered", _g_get_firstHoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastHoverExited", _g_get_lastHoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverEntered", _g_get_hoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverExited", _g_get_hoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactorsHovering", _g_get_interactorsHovering);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHovered", _g_get_isHovered);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHoverableBy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    
                        var gen_ret = gen_to_be_invoked.IsHoverableBy( _interactor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnHoverEntering(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs));
                    
                    gen_to_be_invoked.OnHoverEntering( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnHoverEntered(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs));
                    
                    gen_to_be_invoked.OnHoverEntered( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnHoverExiting(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs));
                    
                    gen_to_be_invoked.OnHoverExiting( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnHoverExited(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs));
                    
                    gen_to_be_invoked.OnHoverExited( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.firstHoverEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lastHoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactorsHovering(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactorsHovering);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isHovered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isHovered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
