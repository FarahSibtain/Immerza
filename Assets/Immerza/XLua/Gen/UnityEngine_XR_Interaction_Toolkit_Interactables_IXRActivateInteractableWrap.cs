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
    public class UnityEngineXRInteractionToolkitInteractablesIXRActivateInteractableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnActivated", _m_OnActivated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnDeactivated", _m_OnDeactivated);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "activated", _g_get_activated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deactivated", _g_get_deactivated);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnActivated(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs));
                    
                    gen_to_be_invoked.OnActivated( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnDeactivated(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs));
                    
                    gen_to_be_invoked.OnDeactivated( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.activated);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deactivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.deactivated);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
