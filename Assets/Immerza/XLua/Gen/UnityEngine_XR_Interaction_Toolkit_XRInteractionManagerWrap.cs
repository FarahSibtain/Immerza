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
    public class UnityEngineXRInteractionToolkitXRInteractionManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 48, 5, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanHover", _m_CanHover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHoverPossible", _m_IsHoverPossible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanSelect", _m_CanSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSelectPossible", _m_IsSelectPossible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanFocus", _m_CanFocus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsFocusPossible", _m_IsFocusPossible);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterInteractionGroup", _m_RegisterInteractionGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterInteractionGroup", _m_UnregisterInteractionGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteractionGroups", _m_GetInteractionGroups);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteractionGroup", _m_GetInteractionGroup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterInteractor", _m_RegisterInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterInteractor", _m_UnregisterInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterInteractable", _m_RegisterInteractable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterInteractable", _m_UnregisterInteractable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterSnapVolume", _m_RegisterSnapVolume);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnregisterSnapVolume", _m_UnregisterSnapVolume);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRegisteredInteractionGroups", _m_GetRegisteredInteractionGroups);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRegisteredInteractors", _m_GetRegisteredInteractors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRegisteredInteractables", _m_GetRegisteredInteractables);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsRegistered", _m_IsRegistered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetInteractableForCollider", _m_TryGetInteractableForCollider);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsColliderRegisteredToInteractable", _m_IsColliderRegisteredToInteractable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsColliderRegisteredSnapVolume", _m_IsColliderRegisteredSnapVolume);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHighestPriorityTarget", _m_IsHighestPriorityTarget);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHandSelecting", _m_IsHandSelecting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValidTargets", _m_GetValidTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelInteractableFocus", _m_CancelInteractableFocus);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelInteractorSelection", _m_CancelInteractorSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelInteractableSelection", _m_CancelInteractableSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelInteractorHover", _m_CancelInteractorHover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelInteractableHover", _m_CancelInteractableHover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FocusEnter", _m_FocusEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FocusExit", _m_FocusExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FocusCancel", _m_FocusCancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectEnter", _m_SelectEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectExit", _m_SelectExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SelectCancel", _m_SelectCancel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HoverEnter", _m_HoverEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HoverExit", _m_HoverExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HoverCancel", _m_HoverCancel);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "interactionGroupRegistered", _e_interactionGroupRegistered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "interactionGroupUnregistered", _e_interactionGroupUnregistered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "interactorRegistered", _e_interactorRegistered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "interactorUnregistered", _e_interactorUnregistered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "interactableRegistered", _e_interactableRegistered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "interactableUnregistered", _e_interactableUnregistered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "focusGained", _e_focusGained);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "focusLost", _e_focusLost);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingHoverFilters", _g_get_startingHoverFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverFilters", _g_get_hoverFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingSelectFilters", _g_get_startingSelectFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectFilters", _g_get_selectFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastFocused", _g_get_lastFocused);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingHoverFilters", _s_set_startingHoverFilters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingSelectFilters", _s_set_startingSelectFilters);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.XRInteractionManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanHover(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = gen_to_be_invoked.CanHover( _interactor, _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHoverPossible(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                        var gen_ret = gen_to_be_invoked.IsHoverPossible( _interactor, _interactable );
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
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.CanSelect( _interactor, _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSelectPossible(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.IsSelectPossible( _interactor, _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanFocus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable));
                    
                        var gen_ret = gen_to_be_invoked.CanFocus( _interactor, _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsFocusPossible(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable));
                    
                        var gen_ret = gen_to_be_invoked.IsFocusPossible( _interactor, _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterInteractionGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup _interactionGroup = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
                    
                    gen_to_be_invoked.RegisterInteractionGroup( _interactionGroup );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterInteractionGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup _interactionGroup = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
                    
                    gen_to_be_invoked.UnregisterInteractionGroup( _interactionGroup );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteractionGroups(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup> _interactionGroups = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup>));
                    
                    gen_to_be_invoked.GetInteractionGroups( _interactionGroups );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteractionGroup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _groupName = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetInteractionGroup( _groupName );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                    gen_to_be_invoked.RegisterInteractor( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                    gen_to_be_invoked.UnregisterInteractor( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterInteractable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable));
                    
                    gen_to_be_invoked.RegisterInteractable( _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterInteractable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable));
                    
                    gen_to_be_invoked.UnregisterInteractable( _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterSnapVolume(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume _snapVolume = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume));
                    
                    gen_to_be_invoked.RegisterSnapVolume( _snapVolume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterSnapVolume(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume _snapVolume = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume));
                    
                    gen_to_be_invoked.UnregisterSnapVolume( _snapVolume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRegisteredInteractionGroups(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup> _results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup>));
                    
                    gen_to_be_invoked.GetRegisteredInteractionGroups( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRegisteredInteractors(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor> _results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>));
                    
                    gen_to_be_invoked.GetRegisteredInteractors( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRegisteredInteractables(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable> _results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>));
                    
                    gen_to_be_invoked.GetRegisteredInteractables( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRegistered(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup>(L, 2)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup _interactionGroup = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
                    
                        var gen_ret = gen_to_be_invoked.IsRegistered( _interactionGroup );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>(L, 2)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                        var gen_ret = gen_to_be_invoked.IsRegistered( _interactor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>(L, 2)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable));
                    
                        var gen_ret = gen_to_be_invoked.IsRegistered( _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.IsRegistered!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetInteractableForCollider(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider>(L, 2)) 
                {
                    UnityEngine.Collider _interactableCollider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable;
                    
                        var gen_ret = gen_to_be_invoked.TryGetInteractableForCollider( _interactableCollider, out _interactable );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _interactable);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider>(L, 2)) 
                {
                    UnityEngine.Collider _interactableCollider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable;
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRInteractableSnapVolume _snapVolume;
                    
                        var gen_ret = gen_to_be_invoked.TryGetInteractableForCollider( _interactableCollider, out _interactable, out _snapVolume );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _interactable);
                        
                    translator.Push(L, _snapVolume);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.TryGetInteractableForCollider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsColliderRegisteredToInteractable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Collider _colliderToCheck = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
                    
                        var gen_ret = gen_to_be_invoked.IsColliderRegisteredToInteractable( _colliderToCheck );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _colliderToCheck);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsColliderRegisteredSnapVolume(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Collider _potentialSnapVolumeCollider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
                    
                        var gen_ret = gen_to_be_invoked.IsColliderRegisteredSnapVolume( _potentialSnapVolumeCollider );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _potentialSnapVolumeCollider);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHighestPriorityTarget(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRTargetPriorityInteractor>>(L, 3)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _target = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRTargetPriorityInteractor> _interactors = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRTargetPriorityInteractor>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRTargetPriorityInteractor>));
                    
                        var gen_ret = gen_to_be_invoked.IsHighestPriorityTarget( _target, _interactors );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable>(L, 2)) 
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _target = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                        var gen_ret = gen_to_be_invoked.IsHighestPriorityTarget( _target );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.IsHighestPriorityTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHandSelecting(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.InteractorHandedness _hand;translator.Get(L, 2, out _hand);
                    
                        var gen_ret = gen_to_be_invoked.IsHandSelecting( _hand );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable> _targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>));
                    
                    gen_to_be_invoked.GetValidTargets( _interactor, _targets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelInteractableFocus(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable));
                    
                    gen_to_be_invoked.CancelInteractableFocus( _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelInteractorSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                    gen_to_be_invoked.CancelInteractorSelection( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelInteractableSelection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                    gen_to_be_invoked.CancelInteractableSelection( _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelInteractorHover(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    
                    gen_to_be_invoked.CancelInteractorHover( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelInteractableHover(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                    gen_to_be_invoked.CancelInteractableHover( _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FocusEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable));
                    
                    gen_to_be_invoked.FocusEnter( _interactor, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FocusExit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup _group = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable));
                    
                    gen_to_be_invoked.FocusExit( _group, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FocusCancel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup _group = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionGroup));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable));
                    
                    gen_to_be_invoked.FocusCancel( _group, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                    gen_to_be_invoked.SelectEnter( _interactor, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectExit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                    gen_to_be_invoked.SelectExit( _interactor, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SelectCancel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                    gen_to_be_invoked.SelectCancel( _interactor, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HoverEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                    gen_to_be_invoked.HoverEnter( _interactor, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HoverExit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                    gen_to_be_invoked.HoverExit( _interactor, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HoverCancel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)translator.GetObject(L, 3, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable));
                    
                    gen_to_be_invoked.HoverCancel( _interactor, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingHoverFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingHoverFilters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.hoverFilters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingSelectFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingSelectFilters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selectFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.selectFilters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastFocused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.lastFocused);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingHoverFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingHoverFilters = (System.Collections.Generic.List<UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Object>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingSelectFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingSelectFilters = (System.Collections.Generic.List<UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Object>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_interactionGroupRegistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupRegisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.interactionGroupRegistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.interactionGroupRegistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.interactionGroupRegistered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_interactionGroupUnregistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupUnregisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupUnregisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractionGroupUnregisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.interactionGroupUnregistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.interactionGroupUnregistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.interactionGroupUnregistered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_interactorRegistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.interactorRegistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.interactorRegistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.interactorRegistered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_interactorUnregistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.interactorUnregistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.interactorUnregistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.interactorUnregistered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_interactableRegistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.interactableRegistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.interactableRegistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.interactableRegistered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_interactableUnregistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.interactableUnregistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.interactableUnregistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.interactableUnregistered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_focusGained(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.FocusEnterEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.focusGained += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.focusGained -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.focusGained!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_focusLost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.XRInteractionManager gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.focusLost += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.focusLost -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.XRInteractionManager.focusLost!");
            return 0;
        }
        
		
		
    }
}
