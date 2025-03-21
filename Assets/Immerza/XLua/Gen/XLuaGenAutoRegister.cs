#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Random), UnityEngineRandomWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Animator), UnityEngineAnimatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mesh), UnityEngineMeshWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.VFX.VisualEffect), UnityEngineVFXVisualEffectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Collider), UnityEngineColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MeshCollider), UnityEngineMeshColliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Material), UnityEngineMaterialWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Video.VideoPlayer), UnityEngineVideoVideoPlayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AudioSource), UnityEngineAudioSourceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.Spline), UnityEngineSplinesSplineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.SplineContainer), UnityEngineSplinesSplineContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.SplineAnimate), UnityEngineSplinesSplineAnimateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Splines.SplineComponent), UnityEngineSplinesSplineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionAsset), UnityEngineInputSystemInputActionAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputAction), UnityEngineInputSystemInputActionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionReference), UnityEngineInputSystemInputActionReferenceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputDevice), UnityEngineInputSystemInputDeviceWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionType), UnityEngineInputSystemInputActionTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.InputSystem.InputActionChange), UnityEngineInputSystemInputActionChangeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor), UnityEngineXRInteractionToolkitInteractorsXRSocketInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRSocketGrabTransformer), UnityEngineXRInteractionToolkitTransformersXRSocketGrabTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRSingleGrabFreeTransformer), UnityEngineXRInteractionToolkitTransformersXRSingleGrabFreeTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRSelectInteractorExtensions), UnityEngineXRInteractionToolkitInteractorsXRSelectInteractorExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor), UnityEngineXRInteractionToolkitInteractorsXRRayInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRPokeInteractor), UnityEngineXRInteractionToolkitInteractorsXRPokeInteractorWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRInteractorExtensions), UnityEngineXRInteractionToolkitInteractorsXRInteractorExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRGeneralGrabTransformer), UnityEngineXRInteractionToolkitTransformersXRGeneralGrabTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRBaseGrabTransformer), UnityEngineXRInteractionToolkitTransformersXRBaseGrabTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInputInteractor), UnityEngineXRInteractionToolkitInteractorsXRBaseInputInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor), UnityEngineXRInteractionToolkitInteractorsXRBaseInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor), UnityEngineXRInteractionToolkitInteractorsXRDirectInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Transformers.XRDualGrabFreeTransformer), UnityEngineXRInteractionToolkitTransformersXRDualGrabFreeTransformerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable), UnityEngineXRInteractionToolkitInteractablesXRBaseInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable), UnityEngineXRInteractionToolkitInteractablesXRGrabInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable), UnityEngineXRInteractionToolkitInteractablesXRSimpleInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRFocusInteractableExtensions), UnityEngineXRInteractionToolkitInteractablesXRFocusInteractableExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRHoverInteractableExtensions), UnityEngineXRInteractionToolkitInteractablesXRHoverInteractableExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRSelectInteractableExtensions), UnityEngineXRInteractionToolkitInteractablesXRSelectInteractableExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs), UnityEngineXRInteractionToolkitSelectEnterEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs), UnityEngineXRInteractionToolkitBaseInteractionEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.FocusExitEventArgs), UnityEngineXRInteractionToolkitFocusExitEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs), UnityEngineXRInteractionToolkitActivateEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs), UnityEngineXRInteractionToolkitDeactivateEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable), UnityEngineXRInteractionToolkitInteractablesIXRInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor), UnityEngineXRInteractionToolkitInteractorsIXRInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable), UnityEngineXRInteractionToolkitInteractablesIXRSelectInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor), UnityEngineXRInteractionToolkitInteractorsIXRSelectInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRActivateInteractable), UnityEngineXRInteractionToolkitInteractablesIXRActivateInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRActivateInteractor), UnityEngineXRInteractionToolkitInteractorsIXRActivateInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRFocusInteractable), UnityEngineXRInteractionToolkitInteractablesIXRFocusInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable), UnityEngineXRInteractionToolkitInteractablesIXRHoverInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor), UnityEngineXRInteractionToolkitInteractorsIXRHoverInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractionStrengthInteractable), UnityEngineXRInteractionToolkitInteractablesIXRInteractionStrengthInteractableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractionStrengthInteractor), UnityEngineXRInteractionToolkitInteractorsIXRInteractionStrengthInteractorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.XRInteractionManager), UnityEngineXRInteractionToolkitXRInteractionManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEvent), UnityEngineXRInteractionToolkitSelectEnterEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEvent), UnityEngineXRInteractionToolkitSelectExitEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(TMPro.TMP_Text), TMProTMP_TextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(TMPro.TMP_Dropdown), TMProTMP_DropdownWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Texture2D), UnityEngineTexture2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Sprite), UnityEngineSpriteWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.Lua.LuaAsset), ImmerzaSDKLuaLuaAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.BreathingDetection), ImmerzaSDKBreathingDetectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.ImmerzaEvents), ImmerzaSDKImmerzaEventsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.MultipathContainer), ImmerzaSDKMultipathContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ImmerzaSDK.Lua.LuaComponent), ImmerzaSDKLuaLuaComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
