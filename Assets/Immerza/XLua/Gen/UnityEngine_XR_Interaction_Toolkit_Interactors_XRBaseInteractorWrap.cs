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
    public class UnityEngineXRInteractionToolkitInteractorsXRBaseInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 32, 19);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachTransform", _m_GetAttachTransform);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachPoseOnSelect", _m_GetAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLocalAttachPoseOnSelect", _m_GetLocalAttachPoseOnSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValidTargets", _m_GetValidTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanHover", _m_CanHover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanSelect", _m_CanSelect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsHovering", _m_IsHovering);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSelecting", _m_IsSelecting);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreprocessInteractor", _m_PreprocessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessInteractor", _m_ProcessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteractionStrength", _m_GetInteractionStrength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartManualInteraction", _m_StartManualInteraction);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndManualInteraction", _m_EndManualInteraction);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "registered", _e_registered);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "unregistered", _e_unregistered);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionManager", _g_get_interactionManager);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "containingGroup", _g_get_containingGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactionLayers", _g_get_interactionLayers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "handedness", _g_get_handedness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "attachTransform", _g_get_attachTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keepSelectedTargetValid", _g_get_keepSelectedTargetValid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disableVisualsWhenBlockedInGroup", _g_get_disableVisualsWhenBlockedInGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingSelectedInteractable", _g_get_startingSelectedInteractable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingTargetFilter", _g_get_startingTargetFilter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverEntered", _g_get_hoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverExited", _g_get_hoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectEntered", _g_get_selectEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectExited", _g_get_selectExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetFilter", _g_get_targetFilter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowHover", _g_get_allowHover);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowSelect", _g_get_allowSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPerformingManualInteraction", _g_get_isPerformingManualInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactablesHovered", _g_get_interactablesHovered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasHover", _g_get_hasHover);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interactablesSelected", _g_get_interactablesSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "firstInteractableSelected", _g_get_firstInteractableSelected);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasSelection", _g_get_hasSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingHoverFilters", _g_get_startingHoverFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverFilters", _g_get_hoverFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingSelectFilters", _g_get_startingSelectFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectFilters", _g_get_selectFilters);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "largestInteractionStrength", _g_get_largestInteractionStrength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHoverActive", _g_get_isHoverActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelectActive", _g_get_isSelectActive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetPriorityMode", _g_get_targetPriorityMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetsForSelection", _g_get_targetsForSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selectedInteractableMovementTypeOverride", _g_get_selectedInteractableMovementTypeOverride);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionManager", _s_set_interactionManager);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interactionLayers", _s_set_interactionLayers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "handedness", _s_set_handedness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "attachTransform", _s_set_attachTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keepSelectedTargetValid", _s_set_keepSelectedTargetValid);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disableVisualsWhenBlockedInGroup", _s_set_disableVisualsWhenBlockedInGroup);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingSelectedInteractable", _s_set_startingSelectedInteractable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingTargetFilter", _s_set_startingTargetFilter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverEntered", _s_set_hoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverExited", _s_set_hoverExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectEntered", _s_set_selectEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selectExited", _s_set_selectExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetFilter", _s_set_targetFilter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowHover", _s_set_allowHover);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowSelect", _s_set_allowSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingHoverFilters", _s_set_startingHoverFilters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingSelectFilters", _s_set_startingSelectFilters);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetPriorityMode", _s_set_targetPriorityMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetsForSelection", _s_set_targetsForSelection);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAttachTransform(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable));
                    
                        var gen_ret = gen_to_be_invoked.GetAttachTransform( _interactable );
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetValidTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_IsHovering(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_IsSelecting(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_PreprocessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetInteractionStrength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable));
                    
                        var gen_ret = gen_to_be_invoked.GetInteractionStrength( _interactable );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartManualInteraction(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable _interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable));
                    
                    gen_to_be_invoked.StartManualInteraction( _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndManualInteraction(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.EndManualInteraction(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interactionManager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionManager);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_containingGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.containingGroup);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interactionLayers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_handedness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.handedness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.attachTransform);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.keepSelectedTargetValid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_disableVisualsWhenBlockedInGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.disableVisualsWhenBlockedInGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingSelectedInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingSelectedInteractable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingTargetFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingTargetFilter);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hoverExited);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.selectExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.targetFilter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowHover(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowHover);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isPerformingManualInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isPerformingManualInteraction);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasHover);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasSelection);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.selectFilters);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.largestInteractionStrength);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelectActive);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetPriorityMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetsForSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetsForSelection);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.selectedInteractableMovementTypeOverride);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interactionManager(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.InteractionLayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.interactionLayers = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_handedness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.InteractorHandedness gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.handedness = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_attachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.attachTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keepSelectedTargetValid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keepSelectedTargetValid = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_disableVisualsWhenBlockedInGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.disableVisualsWhenBlockedInGroup = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingSelectedInteractable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingSelectedInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingTargetFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingTargetFilter = (UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.XRBaseTargetFilter));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverExited = (UnityEngine.XR.Interaction.Toolkit.HoverExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.HoverExitEvent));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selectExited = (UnityEngine.XR.Interaction.Toolkit.SelectExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetFilter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetFilter = (UnityEngine.XR.Interaction.Toolkit.Filtering.IXRTargetFilter)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Filtering.IXRTargetFilter));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowHover(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowHover = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowSelect = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingSelectFilters = (System.Collections.Generic.List<UnityEngine.Object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Object>));
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.TargetPriorityMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetPriorityMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetsForSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.targetsForSelection = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable>));
            
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
			UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorRegisteredEventArgs>!");
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
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor.registered!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_unregistered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>!");
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
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor.unregistered!");
            return 0;
        }
        
		
		
    }
}
