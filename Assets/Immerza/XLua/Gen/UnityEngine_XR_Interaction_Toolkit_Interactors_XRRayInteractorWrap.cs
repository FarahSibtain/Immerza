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
    public class UnityEngineXRInteractionToolkitInteractorsXRRayInteractorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 53, 48);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsOverUIGameObject", _m_IsOverUIGameObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLinePoints", _m_GetLinePoints);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLineOriginAndDirection", _m_GetLineOriginAndDirection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetHitInfo", _m_TryGetHitInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateUIModel", _m_UpdateUIModel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetUIModel", _m_TryGetUIModel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCurrent3DRaycastHit", _m_TryGetCurrent3DRaycastHit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCurrentUIRaycastResult", _m_TryGetCurrentUIRaycastResult);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCurrentARRaycastHit", _m_TryGetCurrentARRaycastHit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetCurrentRaycast", _m_TryGetCurrentRaycast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreprocessInteractor", _m_PreprocessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ProcessInteractor", _m_ProcessInteractor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValidTargets", _m_GetValidTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanHover", _m_CanHover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanSelect", _m_CanSelect);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "lineType", _g_get_lineType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blendVisualLinePoints", _g_get_blendVisualLinePoints);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxRaycastDistance", _g_get_maxRaycastDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rayOriginTransform", _g_get_rayOriginTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "referenceFrame", _g_get_referenceFrame);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", _g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "acceleration", _g_get_acceleration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "additionalGroundHeight", _g_get_additionalGroundHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "additionalFlightTime", _g_get_additionalFlightTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endPointDistance", _g_get_endPointDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endPointHeight", _g_get_endPointHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "controlPointDistance", _g_get_controlPointDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "controlPointHeight", _g_get_controlPointHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sampleFrequency", _g_get_sampleFrequency);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hitDetectionType", _g_get_hitDetectionType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sphereCastRadius", _g_get_sphereCastRadius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "coneCastAngle", _g_get_coneCastAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastMask", _g_get_raycastMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastTriggerInteraction", _g_get_raycastTriggerInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "raycastSnapVolumeInteraction", _g_get_raycastSnapVolumeInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hitClosestOnly", _g_get_hitClosestOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverToSelect", _g_get_hoverToSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hoverTimeToSelect", _g_get_hoverTimeToSelect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoDeselect", _g_get_autoDeselect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "timeToAutoDeselect", _g_get_timeToAutoDeselect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableUIInteraction", _g_get_enableUIInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blockUIOnInteractableSelection", _g_get_blockUIOnInteractableSelection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "manipulateAttachTransform", _g_get_manipulateAttachTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useForceGrab", _g_get_useForceGrab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotateSpeed", _g_get_rotateSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "translateSpeed", _g_get_translateSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotateReferenceFrame", _g_get_rotateReferenceFrame);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotateMode", _g_get_rotateMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiHoverEntered", _g_get_uiHoverEntered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiHoverExited", _g_get_uiHoverExited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableARRaycasting", _g_get_enableARRaycasting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "occludeARHitsWith3DObjects", _g_get_occludeARHitsWith3DObjects);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "occludeARHitsWith2DObjects", _g_get_occludeARHitsWith2DObjects);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleMode", _g_get_scaleMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiPressInput", _g_get_uiPressInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiScrollInput", _g_get_uiScrollInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "translateManipulationInput", _g_get_translateManipulationInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotateManipulationInput", _g_get_rotateManipulationInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directionalManipulationInput", _g_get_directionalManipulationInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleToggleInput", _g_get_scaleToggleInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleOverTimeInput", _g_get_scaleOverTimeInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleDistanceDeltaInput", _g_get_scaleDistanceDeltaInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trackableType", _g_get_trackableType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angle", _g_get_angle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rayEndPoint", _g_get_rayEndPoint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rayEndTransform", _g_get_rayEndTransform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleValue", _g_get_scaleValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSelectActive", _g_get_isSelectActive);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "lineType", _s_set_lineType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blendVisualLinePoints", _s_set_blendVisualLinePoints);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxRaycastDistance", _s_set_maxRaycastDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rayOriginTransform", _s_set_rayOriginTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "referenceFrame", _s_set_referenceFrame);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocity", _s_set_velocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "acceleration", _s_set_acceleration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "additionalGroundHeight", _s_set_additionalGroundHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "additionalFlightTime", _s_set_additionalFlightTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endPointDistance", _s_set_endPointDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endPointHeight", _s_set_endPointHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "controlPointDistance", _s_set_controlPointDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "controlPointHeight", _s_set_controlPointHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sampleFrequency", _s_set_sampleFrequency);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hitDetectionType", _s_set_hitDetectionType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sphereCastRadius", _s_set_sphereCastRadius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "coneCastAngle", _s_set_coneCastAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastMask", _s_set_raycastMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastTriggerInteraction", _s_set_raycastTriggerInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "raycastSnapVolumeInteraction", _s_set_raycastSnapVolumeInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hitClosestOnly", _s_set_hitClosestOnly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverToSelect", _s_set_hoverToSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hoverTimeToSelect", _s_set_hoverTimeToSelect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoDeselect", _s_set_autoDeselect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "timeToAutoDeselect", _s_set_timeToAutoDeselect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableUIInteraction", _s_set_enableUIInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blockUIOnInteractableSelection", _s_set_blockUIOnInteractableSelection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "manipulateAttachTransform", _s_set_manipulateAttachTransform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useForceGrab", _s_set_useForceGrab);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotateSpeed", _s_set_rotateSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "translateSpeed", _s_set_translateSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotateReferenceFrame", _s_set_rotateReferenceFrame);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotateMode", _s_set_rotateMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiHoverEntered", _s_set_uiHoverEntered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiHoverExited", _s_set_uiHoverExited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableARRaycasting", _s_set_enableARRaycasting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "occludeARHitsWith3DObjects", _s_set_occludeARHitsWith3DObjects);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "occludeARHitsWith2DObjects", _s_set_occludeARHitsWith2DObjects);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleMode", _s_set_scaleMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiPressInput", _s_set_uiPressInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiScrollInput", _s_set_uiScrollInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "translateManipulationInput", _s_set_translateManipulationInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotateManipulationInput", _s_set_rotateManipulationInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directionalManipulationInput", _s_set_directionalManipulationInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleToggleInput", _s_set_scaleToggleInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleOverTimeInput", _s_set_scaleOverTimeInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleDistanceDeltaInput", _s_set_scaleDistanceDeltaInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trackableType", _s_set_trackableType);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsOverUIGameObject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsOverUIGameObject(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLinePoints(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3[]>(L, 2)) 
                {
                    UnityEngine.Vector3[] _linePoints = (UnityEngine.Vector3[])translator.GetObject(L, 2, typeof(UnityEngine.Vector3[]));
                    int _numPoints;
                    
                        var gen_ret = gen_to_be_invoked.GetLinePoints( ref _linePoints, out _numPoints );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _linePoints);
                        
                    LuaAPI.xlua_pushinteger(L, _numPoints);
                        
                    
                    
                    
                    return 3;
                }
                if(gen_param_count == 3&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Vector3>>(L, 2)&& translator.Assignable<System.Nullable<UnityEngine.Ray>>(L, 3)) 
                {
                    Unity.Collections.NativeArray<UnityEngine.Vector3> _linePoints;translator.Get(L, 2, out _linePoints);
                    int _numPoints;
                    System.Nullable<UnityEngine.Ray> _rayOriginOverride;translator.Get(L, 3, out _rayOriginOverride);
                    
                        var gen_ret = gen_to_be_invoked.GetLinePoints( ref _linePoints, out _numPoints, _rayOriginOverride );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _linePoints);
                        translator.Update(L, 2, _linePoints);
                        
                    LuaAPI.xlua_pushinteger(L, _numPoints);
                        
                    
                    
                    
                    return 3;
                }
                if(gen_param_count == 2&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Vector3>>(L, 2)) 
                {
                    Unity.Collections.NativeArray<UnityEngine.Vector3> _linePoints;translator.Get(L, 2, out _linePoints);
                    int _numPoints;
                    
                        var gen_ret = gen_to_be_invoked.GetLinePoints( ref _linePoints, out _numPoints );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _linePoints);
                        translator.Update(L, 2, _linePoints);
                        
                    LuaAPI.xlua_pushinteger(L, _numPoints);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.GetLinePoints!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLineOriginAndDirection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _origin;
                    UnityEngine.Vector3 _direction;
                    
                    gen_to_be_invoked.GetLineOriginAndDirection( out _origin, out _direction );
                    translator.PushUnityEngineVector3(L, _origin);
                        
                    translator.PushUnityEngineVector3(L, _direction);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetHitInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _position;
                    UnityEngine.Vector3 _normal;
                    int _positionInLine;
                    bool _isValidTarget;
                    
                        var gen_ret = gen_to_be_invoked.TryGetHitInfo( out _position, out _normal, out _positionInLine, out _isValidTarget );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _position);
                        
                    translator.PushUnityEngineVector3(L, _normal);
                        
                    LuaAPI.xlua_pushinteger(L, _positionInLine);
                        
                    LuaAPI.lua_pushboolean(L, _isValidTarget);
                        
                    
                    
                    
                    return 5;
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_TryGetCurrent3DRaycastHit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    UnityEngine.RaycastHit _raycastHit;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrent3DRaycastHit( out _raycastHit );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _raycastHit);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 1) 
                {
                    UnityEngine.RaycastHit _raycastHit;
                    int _raycastEndpointIndex;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrent3DRaycastHit( out _raycastHit, out _raycastEndpointIndex );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _raycastHit);
                        
                    LuaAPI.xlua_pushinteger(L, _raycastEndpointIndex);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.TryGetCurrent3DRaycastHit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetCurrentUIRaycastResult(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    UnityEngine.EventSystems.RaycastResult _raycastResult;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrentUIRaycastResult( out _raycastResult );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _raycastResult);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 1) 
                {
                    UnityEngine.EventSystems.RaycastResult _raycastResult;
                    int _raycastEndpointIndex;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrentUIRaycastResult( out _raycastResult, out _raycastEndpointIndex );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _raycastResult);
                        
                    LuaAPI.xlua_pushinteger(L, _raycastEndpointIndex);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.TryGetCurrentUIRaycastResult!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetCurrentARRaycastHit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    UnityEngine.XR.ARFoundation.ARRaycastHit _raycastHit;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrentARRaycastHit( out _raycastHit );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _raycastHit);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 1) 
                {
                    UnityEngine.XR.ARFoundation.ARRaycastHit _raycastHit;
                    int _raycastEndpointIndex;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrentARRaycastHit( out _raycastHit, out _raycastEndpointIndex );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _raycastHit);
                        
                    LuaAPI.xlua_pushinteger(L, _raycastEndpointIndex);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.TryGetCurrentARRaycastHit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetCurrentRaycast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    System.Nullable<UnityEngine.RaycastHit> _raycastHit;
                    int _raycastHitIndex;
                    System.Nullable<UnityEngine.EventSystems.RaycastResult> _uiRaycastHit;
                    int _uiRaycastHitIndex;
                    bool _isUIHitClosest;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrentRaycast( out _raycastHit, out _raycastHitIndex, out _uiRaycastHit, out _uiRaycastHitIndex, out _isUIHitClosest );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _raycastHit);
                        
                    LuaAPI.xlua_pushinteger(L, _raycastHitIndex);
                        
                    translator.PushAny(L, _uiRaycastHit);
                        
                    LuaAPI.xlua_pushinteger(L, _uiRaycastHitIndex);
                        
                    LuaAPI.lua_pushboolean(L, _isUIHitClosest);
                        
                    
                    
                    
                    return 6;
                }
                if(gen_param_count == 1) 
                {
                    System.Nullable<UnityEngine.RaycastHit> _raycastHit;
                    int _raycastHitIndex;
                    System.Nullable<UnityEngine.EventSystems.RaycastResult> _uiRaycastHit;
                    int _uiRaycastHitIndex;
                    bool _isUIHitClosest;
                    System.Nullable<UnityEngine.XR.ARFoundation.ARRaycastHit> _arRaycastHit;
                    int _arRaycastHitIndex;
                    bool _isARHitClosest;
                    
                        var gen_ret = gen_to_be_invoked.TryGetCurrentRaycast( out _raycastHit, out _raycastHitIndex, out _uiRaycastHit, out _uiRaycastHitIndex, out _isUIHitClosest, out _arRaycastHit, out _arRaycastHitIndex, out _isARHitClosest );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _raycastHit);
                        
                    LuaAPI.xlua_pushinteger(L, _raycastHitIndex);
                        
                    translator.PushAny(L, _uiRaycastHit);
                        
                    LuaAPI.xlua_pushinteger(L, _uiRaycastHitIndex);
                        
                    LuaAPI.lua_pushboolean(L, _isUIHitClosest);
                        
                    translator.PushAny(L, _arRaycastHit);
                        
                    LuaAPI.xlua_pushinteger(L, _arRaycastHitIndex);
                        
                    LuaAPI.lua_pushboolean(L, _isARHitClosest);
                        
                    
                    
                    
                    return 9;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.TryGetCurrentRaycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreprocessInteractor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_lineType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lineType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blendVisualLinePoints(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.blendVisualLinePoints);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxRaycastDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxRaycastDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rayOriginTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rayOriginTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_referenceFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.referenceFrame);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.velocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_acceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.acceleration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_additionalGroundHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.additionalGroundHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_additionalFlightTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.additionalFlightTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endPointDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.endPointDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endPointHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.endPointHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controlPointDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.controlPointDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_controlPointHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.controlPointHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sampleFrequency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sampleFrequency);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hitDetectionType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.hitDetectionType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sphereCastRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sphereCastRadius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_coneCastAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.coneCastAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.raycastMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.raycastTriggerInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_raycastSnapVolumeInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.raycastSnapVolumeInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hitClosestOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hitClosestOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hoverToSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hoverTimeToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.hoverTimeToSelect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoDeselect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.autoDeselect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeToAutoDeselect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.timeToAutoDeselect);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableUIInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blockUIOnInteractableSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.blockUIOnInteractableSelection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_manipulateAttachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.manipulateAttachTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useForceGrab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useForceGrab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.rotateSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_translateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.translateSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotateReferenceFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rotateReferenceFrame);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotateMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rotateMode);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiHoverExited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableARRaycasting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableARRaycasting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_occludeARHitsWith3DObjects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.occludeARHitsWith3DObjects);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_occludeARHitsWith2DObjects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.occludeARHitsWith2DObjects);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.scaleMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiPressInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiPressInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiScrollInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiScrollInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_translateManipulationInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.translateManipulationInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotateManipulationInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rotateManipulationInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directionalManipulationInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directionalManipulationInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleToggleInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.scaleToggleInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleOverTimeInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.scaleOverTimeInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleDistanceDeltaInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.scaleDistanceDeltaInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trackableType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.trackableType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rayEndPoint(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.rayEndPoint);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rayEndTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rayEndTransform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleValue);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSelectActive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lineType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.LineType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.lineType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blendVisualLinePoints(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.blendVisualLinePoints = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxRaycastDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxRaycastDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rayOriginTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rayOriginTransform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_referenceFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.referenceFrame = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.velocity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_acceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.acceleration = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_additionalGroundHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.additionalGroundHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_additionalFlightTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.additionalFlightTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endPointDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.endPointDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endPointHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.endPointHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_controlPointDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.controlPointDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_controlPointHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.controlPointHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sampleFrequency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sampleFrequency = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hitDetectionType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.HitDetectionType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.hitDetectionType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sphereCastRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sphereCastRadius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_coneCastAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.coneCastAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.raycastMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastTriggerInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.QueryTriggerInteraction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.raycastTriggerInteraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_raycastSnapVolumeInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.QuerySnapVolumeInteraction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.raycastSnapVolumeInteraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hitClosestOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hitClosestOnly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverToSelect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hoverTimeToSelect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hoverTimeToSelect = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoDeselect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoDeselect = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeToAutoDeselect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.timeToAutoDeselect = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableUIInteraction = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blockUIOnInteractableSelection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.blockUIOnInteractableSelection = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_manipulateAttachTransform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.manipulateAttachTransform = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useForceGrab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useForceGrab = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotateSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_translateSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.translateSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotateReferenceFrame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotateReferenceFrame = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotateMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor.RotateMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rotateMode = gen_value;
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiHoverExited = (UnityEngine.XR.Interaction.Toolkit.UI.UIHoverExitEvent)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.UI.UIHoverExitEvent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableARRaycasting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableARRaycasting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_occludeARHitsWith3DObjects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.occludeARHitsWith3DObjects = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_occludeARHitsWith2DObjects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.occludeARHitsWith2DObjects = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.ScaleMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.scaleMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiPressInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiPressInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiScrollInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.uiScrollInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_translateManipulationInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.translateManipulationInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotateManipulationInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotateManipulationInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directionalManipulationInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.directionalManipulationInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleToggleInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleToggleInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputButtonReader));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleOverTimeInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleOverTimeInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<UnityEngine.Vector2>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleDistanceDeltaInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleDistanceDeltaInput = (UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<float>)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Inputs.Readers.XRInputValueReader<float>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trackableType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.ARSubsystems.TrackableType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.trackableType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
