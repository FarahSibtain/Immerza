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
    public class UnityEngineXRInteractionToolkitInteractablesXRHoverInteractableExtensionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRHoverInteractableExtensions);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetOldestInteractorHovering", _m_GetOldestInteractorHovering_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsHoveredByLeft", _m_IsHoveredByLeft_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsHoveredByRight", _m_IsHoveredByRight_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactables.XRHoverInteractableExtensions does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOldestInteractorHovering_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 1, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = UnityEngine.XR.Interaction.Toolkit.Interactables.XRHoverInteractableExtensions.GetOldestInteractorHovering( _interactable );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHoveredByLeft_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 1, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = UnityEngine.XR.Interaction.Toolkit.Interactables.XRHoverInteractableExtensions.IsHoveredByLeft( _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHoveredByRight_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 1, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = UnityEngine.XR.Interaction.Toolkit.Interactables.XRHoverInteractableExtensions.IsHoveredByRight( _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
