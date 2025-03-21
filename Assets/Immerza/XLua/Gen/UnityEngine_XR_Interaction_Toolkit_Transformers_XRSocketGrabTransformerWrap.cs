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
    public class UnityEngineXRInteractionToolkitTransformersXRSocketGrabTransformerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLink", _m_OnLink);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrab", _m_OnGrab);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnGrabCountChanged", _m_OnGrabCountChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Process", _m_Process);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUnlink", _m_OnUnlink);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "canProcess", _g_get_canProcess);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "socketSnappingRadius", _g_get_socketSnappingRadius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleMode", _g_get_scaleMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fixedScale", _g_get_fixedScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetBoundsSize", _g_get_targetBoundsSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "socketInteractor", _g_get_socketInteractor);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "canProcess", _s_set_canProcess);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "socketSnappingRadius", _s_set_socketSnappingRadius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleMode", _s_set_scaleMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fixedScale", _s_set_fixedScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetBoundsSize", _s_set_targetBoundsSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "socketInteractor", _s_set_socketInteractor);
            
			
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
					
					var gen_ret = new UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLink(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
            
            
                
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canProcess);
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.socketSnappingRadius);
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.scaleMode);
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.fixedScale);
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.targetBoundsSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_socketInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.socketInteractor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_canProcess(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.canProcess = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.socketSnappingRadius = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                UnityEngine.XR.Interaction.Toolkit.Interactors.SocketScaleMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.scaleMode = gen_value;
            
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                Unity.Mathematics.float3 gen_value;translator.Get(L, 2, out gen_value);
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
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                Unity.Mathematics.float3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetBoundsSize = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_socketInteractor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer gen_to_be_invoked = (UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.socketInteractor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)translator.GetObject(L, 2, typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
