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
    public class UnityEngineXRInteractionToolkitTransformersXRGeneralGrabTransformerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 11, 11);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrab", _m_OnGrab);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrabCountChanged", _m_OnGrabCountChanged);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "permittedDisplacementAxes", _g_get_permittedDisplacementAxes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constrainedAxisDisplacementMode", _g_get_constrainedAxisDisplacementMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowTwoHandedRotation", _g_get_allowTwoHandedRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowOneHandedScaling", _g_get_allowOneHandedScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowTwoHandedScaling", _g_get_allowTwoHandedScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "oneHandedScaleSpeed", _g_get_oneHandedScaleSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "thresholdMoveRatioForScale", _g_get_thresholdMoveRatioForScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clampScaling", _g_get_clampScaling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minimumScaleRatio", _g_get_minimumScaleRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maximumScaleRatio", _g_get_maximumScaleRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleMultiplier", _g_get_scaleMultiplier);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "permittedDisplacementAxes", _s_set_permittedDisplacementAxes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "constrainedAxisDisplacementMode", _s_set_constrainedAxisDisplacementMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowTwoHandedRotation", _s_set_allowTwoHandedRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowOneHandedScaling", _s_set_allowOneHandedScaling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowTwoHandedScaling", _s_set_allowTwoHandedScaling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "oneHandedScaleSpeed", _s_set_oneHandedScaleSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "thresholdMoveRatioForScale", _s_set_thresholdMoveRatioForScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clampScaling", _s_set_clampScaling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minimumScaleRatio", _s_set_minimumScaleRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maximumScaleRatio", _s_set_maximumScaleRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleMultiplier", _s_set_scaleMultiplier);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Process(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    UnityEngine.XR.Interaction.Toolkit.XRInteractionUpdateOrder.UpdatePhase _updatePhase;translator.Get(L, 3, out _updatePhase);
                    UnityEngine.Pose _targetPose;translator.Get(L, 4, out _targetPose);
                    UnityEngine.Vector3 _localScale;translator.Get(L, 5, out _localScale);
                    
                    gen_to_be_invoked.Process( _grabInteractable, _updatePhase, ref _targetPose, ref _localScale );
                    translator.Push(L, _targetPose);
                        translator.Update(L, 4, _targetPose);
                        
                    translator.PushUnityEngineVector3(L, _localScale);
                        translator.UpdateUnityEngineVector3(L, 5, _localScale);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnGrab(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    
                    gen_to_be_invoked.OnGrab( _grabInteractable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnGrabCountChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    UnityEngine.Pose _targetPose;translator.Get(L, 3, out _targetPose);
                    UnityEngine.Vector3 _localScale;translator.Get(L, 4, out _localScale);
                    
                    gen_to_be_invoked.OnGrabCountChanged( _grabInteractable, _targetPose, _localScale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_permittedDisplacementAxes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.permittedDisplacementAxes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_constrainedAxisDisplacementMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.constrainedAxisDisplacementMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowTwoHandedRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.allowTwoHandedRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowOneHandedScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowOneHandedScaling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowTwoHandedScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowTwoHandedScaling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_oneHandedScaleSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.oneHandedScaleSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_thresholdMoveRatioForScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.thresholdMoveRatioForScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clampScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.clampScaling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minimumScaleRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minimumScaleRatio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maximumScaleRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maximumScaleRatio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleMultiplier);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_permittedDisplacementAxes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.ManipulationAxes gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.permittedDisplacementAxes = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_constrainedAxisDisplacementMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.ConstrainedAxisDisplacementMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.constrainedAxisDisplacementMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowTwoHandedRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer.TwoHandedRotationMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.allowTwoHandedRotation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowOneHandedScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowOneHandedScaling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowTwoHandedScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowTwoHandedScaling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_oneHandedScaleSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.oneHandedScaleSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_thresholdMoveRatioForScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.thresholdMoveRatioForScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clampScaling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.clampScaling = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minimumScaleRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minimumScaleRatio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maximumScaleRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maximumScaleRatio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleMultiplier = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
