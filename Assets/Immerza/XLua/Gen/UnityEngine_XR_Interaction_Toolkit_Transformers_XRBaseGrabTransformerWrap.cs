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
    public class UnityEngineXRInteractionToolkitTransformersXRBaseGrabTransformerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLink", _m_OnLink);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrab", _m_OnGrab);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrabCountChanged", _m_OnGrabCountChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUnlink", _m_OnUnlink);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "canProcess", _g_get_canProcess);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLink(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    
                    gen_to_be_invoked.OnLink( _grabInteractable );
                    
                    
                    
                    return 0;
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OnUnlink(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable _grabInteractable = (UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable));
                    
                    gen_to_be_invoked.OnUnlink( _grabInteractable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canProcess(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canProcess);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
