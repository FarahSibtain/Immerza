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
    public class UnityEngineXRInteractionToolkitInteractablesXRGrabInteractableWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable);
			Utils.BeginObjectRegister(type, L, translator, 0, 18, 38, 36);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessInteractable", _m_ProcessInteractable);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachTransform", _m_GetAttachTransform);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddSingleGrabTransformer", _m_AddSingleGrabTransformer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddMultipleGrabTransformer", _m_AddMultipleGrabTransformer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveSingleGrabTransformer", _m_RemoveSingleGrabTransformer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveMultipleGrabTransformer", _m_RemoveMultipleGrabTransformer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearSingleGrabTransformers", _m_ClearSingleGrabTransformers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearMultipleGrabTransformers", _m_ClearMultipleGrabTransformers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSingleGrabTransformers", _m_GetSingleGrabTransformers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMultipleGrabTransformers", _m_GetMultipleGrabTransformers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSingleGrabTransformerAt", _m_GetSingleGrabTransformerAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMultipleGrabTransformerAt", _m_GetMultipleGrabTransformerAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveSingleGrabTransformerTo", _m_MoveSingleGrabTransformerTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveMultipleGrabTransformerTo", _m_MoveMultipleGrabTransformerTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTargetPose", _m_GetTargetPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTargetPose", _m_SetTargetPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTargetLocalScale", _m_GetTargetLocalScale);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTargetLocalScale", _m_SetTargetLocalScale);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "attachTransform", _g_get_attachTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "secondaryAttachTransform", _g_get_secondaryAttachTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useDynamicAttach", _g_get_useDynamicAttach);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "matchAttachPosition", _g_get_matchAttachPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "matchAttachRotation", _g_get_matchAttachRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "snapToColliderVolume", _g_get_snapToColliderVolume);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reinitializeDynamicAttachEverySingleGrab", _g_get_reinitializeDynamicAttachEverySingleGrab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "attachEaseInTime", _g_get_attachEaseInTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "movementType", _g_get_movementType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocityDamping", _g_get_velocityDamping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocityScale", _g_get_velocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularVelocityDamping", _g_get_angularVelocityDamping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularVelocityScale", _g_get_angularVelocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trackPosition", _g_get_trackPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothPosition", _g_get_smoothPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothPositionAmount", _g_get_smoothPositionAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tightenPosition", _g_get_tightenPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trackRotation", _g_get_trackRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothRotation", _g_get_smoothRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothRotationAmount", _g_get_smoothRotationAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tightenRotation", _g_get_tightenRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trackScale", _g_get_trackScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothScale", _g_get_smoothScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "smoothScaleAmount", _g_get_smoothScaleAmount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tightenScale", _g_get_tightenScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "throwOnDetach", _g_get_throwOnDetach);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "throwSmoothingDuration", _g_get_throwSmoothingDuration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "throwSmoothingCurve", _g_get_throwSmoothingCurve);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "throwVelocityScale", _g_get_throwVelocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "throwAngularVelocityScale", _g_get_throwAngularVelocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceGravityOnDetach", _g_get_forceGravityOnDetach);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "retainTransformParent", _g_get_retainTransformParent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingSingleGrabTransformers", _g_get_startingSingleGrabTransformers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startingMultipleGrabTransformers", _g_get_startingMultipleGrabTransformers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "addDefaultGrabTransformers", _g_get_addDefaultGrabTransformers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "farAttachMode", _g_get_farAttachMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "singleGrabTransformersCount", _g_get_singleGrabTransformersCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "multipleGrabTransformersCount", _g_get_multipleGrabTransformersCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "attachTransform", _s_set_attachTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "secondaryAttachTransform", _s_set_secondaryAttachTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useDynamicAttach", _s_set_useDynamicAttach);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "matchAttachPosition", _s_set_matchAttachPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "matchAttachRotation", _s_set_matchAttachRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "snapToColliderVolume", _s_set_snapToColliderVolume);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reinitializeDynamicAttachEverySingleGrab", _s_set_reinitializeDynamicAttachEverySingleGrab);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "attachEaseInTime", _s_set_attachEaseInTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "movementType", _s_set_movementType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocityDamping", _s_set_velocityDamping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocityScale", _s_set_velocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularVelocityDamping", _s_set_angularVelocityDamping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularVelocityScale", _s_set_angularVelocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trackPosition", _s_set_trackPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothPosition", _s_set_smoothPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothPositionAmount", _s_set_smoothPositionAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tightenPosition", _s_set_tightenPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trackRotation", _s_set_trackRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothRotation", _s_set_smoothRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothRotationAmount", _s_set_smoothRotationAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tightenRotation", _s_set_tightenRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trackScale", _s_set_trackScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothScale", _s_set_smoothScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "smoothScaleAmount", _s_set_smoothScaleAmount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tightenScale", _s_set_tightenScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "throwOnDetach", _s_set_throwOnDetach);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "throwSmoothingDuration", _s_set_throwSmoothingDuration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "throwSmoothingCurve", _s_set_throwSmoothingCurve);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "throwVelocityScale", _s_set_throwVelocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "throwAngularVelocityScale", _s_set_throwAngularVelocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forceGravityOnDetach", _s_set_forceGravityOnDetach);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "retainTransformParent", _s_set_retainTransformParent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingSingleGrabTransformers", _s_set_startingSingleGrabTransformers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startingMultipleGrabTransformers", _s_set_startingMultipleGrabTransformers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "addDefaultGrabTransformers", _s_set_addDefaultGrabTransformers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "farAttachMode", _s_set_farAttachMode);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ProcessInteractable(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetAttachTransform(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_AddSingleGrabTransformer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer _transformer = (UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer));
                    
                    gen_to_be_invoked.AddSingleGrabTransformer( _transformer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddMultipleGrabTransformer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer _transformer = (UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer));
                    
                    gen_to_be_invoked.AddMultipleGrabTransformer( _transformer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveSingleGrabTransformer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer _transformer = (UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer));
                    
                        var gen_ret = gen_to_be_invoked.RemoveSingleGrabTransformer( _transformer );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveMultipleGrabTransformer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer _transformer = (UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer));
                    
                        var gen_ret = gen_to_be_invoked.RemoveMultipleGrabTransformer( _transformer );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearSingleGrabTransformers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearSingleGrabTransformers(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearMultipleGrabTransformers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearMultipleGrabTransformers(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSingleGrabTransformers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer> _results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer>));
                    
                    gen_to_be_invoked.GetSingleGrabTransformers( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMultipleGrabTransformers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer> _results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer>));
                    
                    gen_to_be_invoked.GetMultipleGrabTransformers( _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSingleGrabTransformerAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetSingleGrabTransformerAt( _index );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMultipleGrabTransformerAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetMultipleGrabTransformerAt( _index );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveSingleGrabTransformerTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer _transformer = (UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer));
                    int _newIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.MoveSingleGrabTransformerTo( _transformer, _newIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveMultipleGrabTransformerTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer _transformer = (UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.IXRGrabTransformer));
                    int _newIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.MoveMultipleGrabTransformerTo( _transformer, _newIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTargetPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetTargetPose(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTargetPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Pose _pose;translator.Get(L, 2, out _pose);
                    
                    gen_to_be_invoked.SetTargetPose( _pose );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTargetLocalScale(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetTargetLocalScale(  );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTargetLocalScale(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _localScale;translator.Get(L, 2, out _localScale);
                    
                    gen_to_be_invoked.SetTargetLocalScale( _localScale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.attachTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_secondaryAttachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.secondaryAttachTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useDynamicAttach(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useDynamicAttach);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_matchAttachPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.matchAttachPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_matchAttachRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.matchAttachRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_snapToColliderVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.snapToColliderVolume);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reinitializeDynamicAttachEverySingleGrab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.reinitializeDynamicAttachEverySingleGrab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attachEaseInTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.attachEaseInTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_movementType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.movementType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocityDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.velocityDamping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.velocityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularVelocityDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angularVelocityDamping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angularVelocityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trackPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.trackPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.smoothPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothPositionAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.smoothPositionAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tightenPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.tightenPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trackRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.trackRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.smoothRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothRotationAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.smoothRotationAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tightenRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.tightenRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trackScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.trackScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.smoothScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothScaleAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.smoothScaleAmount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tightenScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.tightenScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_throwOnDetach(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.throwOnDetach);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_throwSmoothingDuration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.throwSmoothingDuration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_throwSmoothingCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.throwSmoothingCurve);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_throwVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.throwVelocityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_throwAngularVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.throwAngularVelocityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forceGravityOnDetach(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.forceGravityOnDetach);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_retainTransformParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.retainTransformParent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingSingleGrabTransformers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingSingleGrabTransformers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startingMultipleGrabTransformers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.startingMultipleGrabTransformers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_addDefaultGrabTransformers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.addDefaultGrabTransformers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_farAttachMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.farAttachMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_singleGrabTransformersCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.singleGrabTransformersCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_multipleGrabTransformersCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.multipleGrabTransformersCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_attachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.attachTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_secondaryAttachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.secondaryAttachTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useDynamicAttach(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useDynamicAttach = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_matchAttachPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.matchAttachPosition = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_matchAttachRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.matchAttachRotation = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_snapToColliderVolume(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.snapToColliderVolume = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reinitializeDynamicAttachEverySingleGrab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reinitializeDynamicAttachEverySingleGrab = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_attachEaseInTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.attachEaseInTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_movementType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable.MovementType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.movementType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocityDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.velocityDamping = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.velocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularVelocityDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angularVelocityDamping = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angularVelocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trackPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trackPosition = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothPosition = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothPositionAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothPositionAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tightenPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tightenPosition = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trackRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trackRotation = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothRotation = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothRotationAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothRotationAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tightenRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tightenRotation = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trackScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trackScale = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothScale = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_smoothScaleAmount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.smoothScaleAmount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tightenScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tightenScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_throwOnDetach(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.throwOnDetach = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_throwSmoothingDuration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.throwSmoothingDuration = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_throwSmoothingCurve(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.throwSmoothingCurve = (UnityEngine.AnimationCurve)translator.GetObject(L, 2, typeof(UnityEngine.AnimationCurve));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_throwVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.throwVelocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_throwAngularVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.throwAngularVelocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forceGravityOnDetach(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.forceGravityOnDetach = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_retainTransformParent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.retainTransformParent = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingSingleGrabTransformers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingSingleGrabTransformers = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startingMultipleGrabTransformers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startingMultipleGrabTransformers = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_addDefaultGrabTransformers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.addDefaultGrabTransformers = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_farAttachMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Attachment.InteractableFarAttachMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.farAttachMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
