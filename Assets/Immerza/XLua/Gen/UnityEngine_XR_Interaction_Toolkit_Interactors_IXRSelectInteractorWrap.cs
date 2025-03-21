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
    public class UnityEngineXRInteractionToolkitInteractorsIXRSelectInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 7, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanSelect", _m_CanSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSelecting", _m_IsSelecting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachPoseOnSelect", _m_GetAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLocalAttachPoseOnSelect", _m_GetLocalAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectEntering", _m_OnSelectEntering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectEntered", _m_OnSelectEntered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectExiting", _m_OnSelectExiting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSelectExited", _m_OnSelectExited);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectEntered", _g_get_selectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectExited", _g_get_selectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactablesSelected", _g_get_interactablesSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstInteractableSelected", _g_get_firstInteractableSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasSelection", _g_get_hasSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelectActive", _g_get_isSelectActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keepSelectedTargetValid", _g_get_keepSelectedTargetValid);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanSelect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.CanSelect( _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSelecting(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.IsSelecting( _interactable );
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.GetAttachPoseOnSelect( _interactable );
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.GetLocalAttachPoseOnSelect( _interactable );
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_selectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactablesSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactablesSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstInteractableSelected(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.firstInteractableSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasSelection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isSelectActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelectActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keepSelectedTargetValid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.keepSelectedTargetValid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
