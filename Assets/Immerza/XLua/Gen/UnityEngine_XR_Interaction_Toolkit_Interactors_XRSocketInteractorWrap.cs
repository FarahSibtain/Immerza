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
    public class UnityEngineXRInteractionToolkitInteractorsXRSocketInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 14, 11);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessInteractor", _m_ProcessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValidTargets", _m_GetValidTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanHover", _m_CanHover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanSelect", _m_CanSelect);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "showInteractableHoverMeshes", _g_get_showInteractableHoverMeshes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactableHoverMeshMaterial", _g_get_interactableHoverMeshMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactableCantHoverMeshMaterial", _g_get_interactableCantHoverMeshMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "socketActive", _g_get_socketActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactableHoverScale", _g_get_interactableHoverScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "recycleDelayTime", _g_get_recycleDelayTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverSocketSnapping", _g_get_hoverSocketSnapping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "socketSnappingRadius", _g_get_socketSnappingRadius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "socketScaleMode", _g_get_socketScaleMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fixedScale", _g_get_fixedScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetBoundsSize", _g_get_targetBoundsSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHoverActive", _g_get_isHoverActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelectActive", _g_get_isSelectActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectedInteractableMovementTypeOverride", _g_get_selectedInteractableMovementTypeOverride);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "showInteractableHoverMeshes", _s_set_showInteractableHoverMeshes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactableHoverMeshMaterial", _s_set_interactableHoverMeshMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactableCantHoverMeshMaterial", _s_set_interactableCantHoverMeshMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "socketActive", _s_set_socketActive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactableHoverScale", _s_set_interactableHoverScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "recycleDelayTime", _s_set_recycleDelayTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverSocketSnapping", _s_set_hoverSocketSnapping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "socketSnappingRadius", _s_set_socketSnappingRadius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "socketScaleMode", _s_set_socketScaleMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fixedScale", _s_set_fixedScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetBoundsSize", _s_set_targetBoundsSize);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_CanHover(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_CanSelect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_showInteractableHoverMeshes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.showInteractableHoverMeshes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactableHoverMeshMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactableHoverMeshMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactableCantHoverMeshMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactableCantHoverMeshMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_socketActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.socketActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactableHoverScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.interactableHoverScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_recycleDelayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.recycleDelayTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverSocketSnapping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hoverSocketSnapping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_socketSnappingRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.socketSnappingRadius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_socketScaleMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.socketScaleMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fixedScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.fixedScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetBoundsSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.targetBoundsSize);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isHoverActive);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelectActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectedInteractableMovementTypeOverride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.selectedInteractableMovementTypeOverride);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showInteractableHoverMeshes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.showInteractableHoverMeshes = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactableHoverMeshMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactableHoverMeshMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactableCantHoverMeshMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactableCantHoverMeshMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_socketActive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.socketActive = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactableHoverScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactableHoverScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_recycleDelayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.recycleDelayTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverSocketSnapping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverSocketSnapping = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_socketSnappingRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.socketSnappingRadius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_socketScaleMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.SocketScaleMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.socketScaleMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fixedScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.fixedScale = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetBoundsSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetBoundsSize = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
