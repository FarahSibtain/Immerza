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
    public class UnityEngineXRInteractionToolkitInteractorsIXRHoverInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 5, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanHover", _m_CanHover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHovering", _m_IsHovering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverEntering", _m_OnHoverEntering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverEntered", _m_OnHoverEntered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverExiting", _m_OnHoverExiting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnHoverExited", _m_OnHoverExited);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverEntered", _g_get_hoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverExited", _g_get_hoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactablesHovered", _g_get_interactablesHovered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasHover", _g_get_hasHover);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHoverActive", _g_get_isHoverActive);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanHover(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = gen_to_be_invoked.CanHover( _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHovering(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = gen_to_be_invoked.IsHovering( _interactable );
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_hoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactablesHovered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactablesHovered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasHover(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasHover);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isHoverActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isHoverActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
