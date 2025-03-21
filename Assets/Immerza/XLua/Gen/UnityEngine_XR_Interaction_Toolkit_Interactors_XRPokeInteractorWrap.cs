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
    public class UnityEngineXRInteractionToolkitInteractorsXRPokeInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 13, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreprocessInteractor", _m_PreprocessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessInteractor", _m_ProcessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValidTargets", _m_GetValidTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUIModel", _m_UpdateUIModel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetUIModel", _m_TryGetUIModel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachPointVelocity", _m_GetAttachPointVelocity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachPointAngularVelocity", _m_GetAttachPointAngularVelocity);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeDepth", _g_get_pokeDepth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeWidth", _g_get_pokeWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeSelectWidth", _g_get_pokeSelectWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeHoverRadius", _g_get_pokeHoverRadius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeInteractionOffset", _g_get_pokeInteractionOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "physicsLayerMask", _g_get_physicsLayerMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "physicsTriggerInteraction", _g_get_physicsTriggerInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "requirePokeFilter", _g_get_requirePokeFilter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableUIInteraction", _g_get_enableUIInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "debugVisualizationsEnabled", _g_get_debugVisualizationsEnabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiHoverEntered", _g_get_uiHoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiHoverExited", _g_get_uiHoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pokeStateData", _g_get_pokeStateData);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeDepth", _s_set_pokeDepth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeWidth", _s_set_pokeWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeSelectWidth", _s_set_pokeSelectWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeHoverRadius", _s_set_pokeHoverRadius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pokeInteractionOffset", _s_set_pokeInteractionOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "physicsLayerMask", _s_set_physicsLayerMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "physicsTriggerInteraction", _s_set_physicsTriggerInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "requirePokeFilter", _s_set_requirePokeFilter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableUIInteraction", _s_set_enableUIInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "debugVisualizationsEnabled", _s_set_debugVisualizationsEnabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiHoverEntered", _s_set_uiHoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiHoverExited", _s_set_uiHoverExited);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreprocessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetValidTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable> _targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>));
                    
                    gen_to_be_invoked.GetValidTargets( _targets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateUIModel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.UI.TrackedDeviceModel _model;translator.Get(L, 2, out _model);
                    
                    gen_to_be_invoked.UpdateUIModel( ref _model );
                    translator.Push(L, _model);
                        translator.Update(L, 2, _model);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetUIModel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.UI.TrackedDeviceModel _model;
                    
                        var gen_ret = gen_to_be_invoked.TryGetUIModel( out _model );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _model);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAttachPointVelocity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetAttachPointVelocity(  );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAttachPointAngularVelocity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetAttachPointAngularVelocity(  );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeDepth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pokeDepth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pokeWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeSelectWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pokeSelectWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeHoverRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pokeHoverRadius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeInteractionOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.pokeInteractionOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_physicsLayerMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.physicsLayerMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_physicsTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.physicsTriggerInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_requirePokeFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.requirePokeFilter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableUIInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableUIInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_debugVisualizationsEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.debugVisualizationsEnabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiHoverEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiHoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pokeStateData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.pokeStateData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeDepth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeDepth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeSelectWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeSelectWidth = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeHoverRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeHoverRadius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pokeInteractionOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pokeInteractionOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_physicsLayerMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.physicsLayerMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_physicsTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.QueryTriggerInteraction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.physicsTriggerInteraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_requirePokeFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.requirePokeFilter = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableUIInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableUIInteraction = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_debugVisualizationsEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.debugVisualizationsEnabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiHoverEntered = (UnityEngine.XR.Interaction.Toolkit.UI.UIHoverEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.UI.UIHoverEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiHoverExited = (UnityEngine.XR.Interaction.Toolkit.UI.UIHoverExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.UI.UIHoverExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
