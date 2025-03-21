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
    public class UnityEngineXRInteractionToolkitInteractablesXRBaseInteractableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 45, 31);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachTransform", _m_GetAttachTransform);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachPoseOnSelect", _m_GetAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLocalAttachPoseOnSelect", _m_GetLocalAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDistanceSqrToInteractor", _m_GetDistanceSqrToInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDistance", _m_GetDistance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteractionStrength", _m_GetInteractionStrength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHoverableBy", _m_IsHoverableBy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSelectableBy", _m_IsSelectableBy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHovered", _m_IsHovered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSelected", _m_IsSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCustomReticle", _m_GetCustomReticle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AttachCustomReticle", _m_AttachCustomReticle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveCustomReticle", _m_RemoveCustomReticle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessInteractable", _m_ProcessInteractable);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "registered", _e_registered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "unregistered", _e_unregistered);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "getDistanceOverride", _g_get_getDistanceOverride);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionManager", _g_get_interactionManager);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colliders", _g_get_colliders);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionLayers", _g_get_interactionLayers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "distanceCalculationMode", _g_get_distanceCalculationMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectMode", _g_get_selectMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusMode", _g_get_focusMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "customReticle", _g_get_customReticle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowGazeInteraction", _g_get_allowGazeInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowGazeSelect", _g_get_allowGazeSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideGazeTimeToSelect", _g_get_overrideGazeTimeToSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gazeTimeToSelect", _g_get_gazeTimeToSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overrideTimeToAutoDeselectGaze", _g_get_overrideTimeToAutoDeselectGaze);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "timeToAutoDeselectGaze", _g_get_timeToAutoDeselectGaze);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowGazeAssistance", _g_get_allowGazeAssistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstHoverEntered", _g_get_firstHoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastHoverExited", _g_get_lastHoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverEntered", _g_get_hoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverExited", _g_get_hoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstSelectEntered", _g_get_firstSelectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastSelectExited", _g_get_lastSelectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectEntered", _g_get_selectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectExited", _g_get_selectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstFocusEntered", _g_get_firstFocusEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastFocusExited", _g_get_lastFocusExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusEntered", _g_get_focusEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "focusExited", _g_get_focusExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activated", _g_get_activated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "deactivated", _g_get_deactivated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactorsHovering", _g_get_interactorsHovering);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHovered", _g_get_isHovered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactorsSelecting", _g_get_interactorsSelecting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstInteractorSelecting", _g_get_firstInteractorSelecting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelected", _g_get_isSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionGroupsFocusing", _g_get_interactionGroupsFocusing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstInteractionGroupFocusing", _g_get_firstInteractionGroupFocusing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFocused", _g_get_isFocused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canFocus", _g_get_canFocus);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingHoverFilters", _g_get_startingHoverFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverFilters", _g_get_hoverFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingSelectFilters", _g_get_startingSelectFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectFilters", _g_get_selectFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingInteractionStrengthFilters", _g_get_startingInteractionStrengthFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionStrengthFilters", _g_get_interactionStrengthFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "largestInteractionStrength", _g_get_largestInteractionStrength);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "getDistanceOverride", _s_set_getDistanceOverride);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionManager", _s_set_interactionManager);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionLayers", _s_set_interactionLayers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "distanceCalculationMode", _s_set_distanceCalculationMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectMode", _s_set_selectMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "focusMode", _s_set_focusMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "customReticle", _s_set_customReticle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowGazeInteraction", _s_set_allowGazeInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowGazeSelect", _s_set_allowGazeSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideGazeTimeToSelect", _s_set_overrideGazeTimeToSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gazeTimeToSelect", _s_set_gazeTimeToSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "overrideTimeToAutoDeselectGaze", _s_set_overrideTimeToAutoDeselectGaze);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "timeToAutoDeselectGaze", _s_set_timeToAutoDeselectGaze);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowGazeAssistance", _s_set_allowGazeAssistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "firstHoverEntered", _s_set_firstHoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lastHoverExited", _s_set_lastHoverExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverEntered", _s_set_hoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverExited", _s_set_hoverExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "firstSelectEntered", _s_set_firstSelectEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lastSelectExited", _s_set_lastSelectExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectEntered", _s_set_selectEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectExited", _s_set_selectExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "firstFocusEntered", _s_set_firstFocusEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lastFocusExited", _s_set_lastFocusExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "focusEntered", _s_set_focusEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "focusExited", _s_set_focusExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "activated", _s_set_activated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "deactivated", _s_set_deactivated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingHoverFilters", _s_set_startingHoverFilters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingSelectFilters", _s_set_startingSelectFilters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingInteractionStrengthFilters", _s_set_startingInteractionStrengthFilters);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAttachTransform(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                        var gen_ret = gen_to_be_invoked.GetAttachTransform( _interactor );
                        translator.Push(L, gen_ret);
                    
                    
                    
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetDistanceSqrToInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                        var gen_ret = gen_to_be_invoked.GetDistanceSqrToInteractor( _interactor );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDistance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    
                        var gen_ret = gen_to_be_invoked.GetDistance( _position );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteractionStrength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                        var gen_ret = gen_to_be_invoked.GetInteractionStrength( _interactor );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsHoverableBy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_IsSelectableBy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_IsHovered(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor));
                    
                        var gen_ret = gen_to_be_invoked.IsHovered( _interactor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSelected(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor));
                    
                        var gen_ret = gen_to_be_invoked.IsSelected( _interactor );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCustomReticle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                        var gen_ret = gen_to_be_invoked.GetCustomReticle( _interactor );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttachCustomReticle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                    gen_to_be_invoked.AttachCustomReticle( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveCustomReticle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor _interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
                    
                    gen_to_be_invoked.RemoveCustomReticle( _interactor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessInteractable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase _updatePhase;translator.Get(L, 2, out _updatePhase);
                    
                    gen_to_be_invoked.ProcessInteractable( _updatePhase );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_getDistanceOverride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.getDistanceOverride);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionManager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionManager);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliders(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.colliders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionLayers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionLayers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_distanceCalculationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.distanceCalculationMode);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.focusMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customReticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.customReticle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowGazeInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowGazeInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowGazeSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowGazeSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overrideGazeTimeToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overrideGazeTimeToSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gazeTimeToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gazeTimeToSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overrideTimeToAutoDeselectGaze(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.overrideTimeToAutoDeselectGaze);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeToAutoDeselectGaze(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.timeToAutoDeselectGaze);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowGazeAssistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowGazeAssistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstSelectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstFocusEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.firstFocusEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastFocusExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lastFocusExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.focusEntered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_focusExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.focusExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.deactivated);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isHovered);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelected);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionGroupsFocusing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionGroupsFocusing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_firstInteractionGroupFocusing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.firstInteractionGroupFocusing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFocused(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isFocused);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canFocus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingHoverFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.selectFilters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingInteractionStrengthFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingInteractionStrengthFilters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionStrengthFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.interactionStrengthFilters);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_largestInteractionStrength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.largestInteractionStrength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_getDistanceOverride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.getDistanceOverride = translator.GetDelegate<System.Func<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable, UnityEngine.Vector3, UnityEngine.XR.Interaction.Toolkit.Interactables.DistanceInfo>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionManager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.interactionManager = (UnityEngine.XR.Interaction.Toolkit.XRInteractionManager)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionLayers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.interactionLayers = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_distanceCalculationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable.DistanceCalculationMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.distanceCalculationMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactables.InteractableSelectMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.selectMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_focusMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactables.InteractableFocusMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.focusMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customReticle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.customReticle = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowGazeInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowGazeInteraction = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowGazeSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowGazeSelect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overrideGazeTimeToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overrideGazeTimeToSelect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gazeTimeToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gazeTimeToSelect = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_overrideTimeToAutoDeselectGaze(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.overrideTimeToAutoDeselectGaze = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeToAutoDeselectGaze(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.timeToAutoDeselectGaze = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowGazeAssistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowGazeAssistance = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_firstHoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.firstHoverEntered = (UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastHoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lastHoverExited = (UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverEntered = (UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverExited = (UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_firstSelectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.firstSelectEntered = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastSelectExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lastSelectExited = (UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectEntered = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selectExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectExited = (UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_firstFocusEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.firstFocusEntered = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastFocusExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lastFocusExited = (UnityEngine.XR.Interaction.Toolkit.FocusExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_focusEntered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.focusEntered = (UnityEngine.XR.Interaction.Toolkit.FocusEnterEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusEnterEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_focusExited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.focusExited = (UnityEngine.XR.Interaction.Toolkit.FocusExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.FocusExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_activated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.activated = (UnityEngine.XR.Interaction.Toolkit.ActivateEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.ActivateEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_deactivated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.deactivated = (UnityEngine.XR.Interaction.Toolkit.DeactivateEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.DeactivateEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingHoverFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingSelectFilters = (System.Collections.Generic.List<UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Object>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingInteractionStrengthFilters(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingInteractionStrengthFilters = (System.Collections.Generic.List<UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Object>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_registered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.registered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.registered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable.registered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_unregistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.unregistered += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.unregistered -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable.unregistered!");
            return 0;
        }
        
		
		
    }
}
