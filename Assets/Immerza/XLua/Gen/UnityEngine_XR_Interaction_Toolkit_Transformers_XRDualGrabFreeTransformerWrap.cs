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
    public class UnityEngineXRInteractionToolkitTransformersXRDualGrabFreeTransformerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrabCountChanged", _m_OnGrabCountChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "multiSelectPosition", _g_get_multiSelectPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "multiSelectRotation", _g_get_multiSelectRotation);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "multiSelectPosition", _s_set_multiSelectPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "multiSelectRotation", _s_set_multiSelectRotation);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnGrabCountChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_Process(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_multiSelectPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.multiSelectPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_multiSelectRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.multiSelectRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_multiSelectPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer.PoseContributor gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.multiSelectPosition = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_multiSelectRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer.PoseContributor gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.multiSelectRotation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
