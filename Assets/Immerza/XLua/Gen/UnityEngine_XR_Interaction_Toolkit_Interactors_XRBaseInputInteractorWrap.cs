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
    public class UnityEngineXRInteractionToolkitInteractorsXRBaseInputInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 11, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreprocessInteractor", _m_PreprocessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessInteractor", _m_ProcessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetActivateTargets", _m_GetActivateTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendHapticImpulse", _m_SendHapticImpulse);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectInput", _g_get_selectInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activateInput", _g_get_activateInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectActionTrigger", _g_get_selectActionTrigger);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowHoveredActivate", _g_get_allowHoveredActivate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetPriorityMode", _g_get_targetPriorityMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowActivate", _g_get_allowActivate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelectActive", _g_get_isSelectActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shouldActivate", _g_get_shouldActivate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shouldDeactivate", _g_get_shouldDeactivate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "logicalSelectState", _g_get_logicalSelectState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "logicalActivateState", _g_get_logicalActivateState);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectInput", _s_set_selectInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "activateInput", _s_set_activateInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectActionTrigger", _s_set_selectActionTrigger);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowHoveredActivate", _s_set_allowHoveredActivate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetPriorityMode", _s_set_targetPriorityMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowActivate", _s_set_allowActivate);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreprocessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase _updatePhase;translator.Get(L, 2, out _updatePhase);
                    
                    gen_to_be_invoked.PreprocessInteractor( _updatePhase );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase _updatePhase;translator.Get(L, 2, out _updatePhase);
                    
                    gen_to_be_invoked.ProcessInteractor( _updatePhase );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActivateTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable> _targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable>));
                    
                    gen_to_be_invoked.GetActivateTargets( _targets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendHapticImpulse(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _amplitude = (float)LuaAPI.lua_tonumber(L, 2);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.SendHapticImpulse( _amplitude, _duration );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activateInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.activateInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectActionTrigger(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectActionTrigger);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowHoveredActivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowHoveredActivate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetPriorityMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetPriorityMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowActivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowActivate);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelectActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shouldActivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.shouldActivate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shouldDeactivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.shouldDeactivate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logicalSelectState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.logicalSelectState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logicalActivateState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.logicalActivateState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_activateInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.activateInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectActionTrigger(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor.InputTriggerType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.selectActionTrigger = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowHoveredActivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowHoveredActivate = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetPriorityMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.TargetPriorityMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetPriorityMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowActivate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowActivate = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
