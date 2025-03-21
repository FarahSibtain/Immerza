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
    public class UnityEngineXRInteractionToolkitInteractablesIXRSelectInteractableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 8, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSelectableBy", _m_IsSelectableBy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachPoseOnSelect", _m_GetAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLocalAttachPoseOnSelect", _m_GetLocalAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectEntering", _m_OnSelectEntering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectEntered", _m_OnSelectEntered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectExiting", _m_OnSelectExiting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectExited", _m_OnSelectExited);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstSelectEntered", _g_get_firstSelectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastSelectExited", _g_get_lastSelectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectEntered", _g_get_selectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectExited", _g_get_selectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactorsSelecting", _g_get_interactorsSelecting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstInteractorSelecting", _g_get_firstInteractorSelecting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelected", _g_get_isSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectMode", _g_get_selectMode);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSelectableBy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                        var gen_ret = gen_to_be_invoked.IsSelectableBy( _interactor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAttachPoseOnSelect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                        var gen_ret = gen_to_be_invoked.GetAttachPoseOnSelect( _interactor );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLocalAttachPoseOnSelect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                        var gen_ret = gen_to_be_invoked.GetLocalAttachPoseOnSelect( _interactor );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSelectEntering(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs));
                    
                    gen_to_be_invoked.OnSelectEntering( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSelectEntered(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs));
                    
                    gen_to_be_invoked.OnSelectEntered( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSelectExiting(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs));
                    
                    gen_to_be_invoked.OnSelectExiting( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSelectExited(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs _args = (UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs));
                    
                    gen_to_be_invoked.OnSelectExited( _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstSelectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.firstSelectEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastSelectExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lastSelectExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactorsSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactorsSelecting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstInteractorSelecting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.firstInteractorSelecting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
