local unity = CS.UnityEngine
local lua_util = CS.ImmerzaSDK.Lua.LuaComponent

local frameOuterDefaultMat
local frameInnerDefaultMat

function start()
		frameOuterDefaultMat = frameOuter.material;
        frameInnerDefaultMat = frameInner.material;

		interactable.hoverEntered:AddListener(on_hover_entered);
		interactable.hoverExited:AddListener(on_hover_exited);
end

function on_hover_entered(args)
	    windowName = args.interactableObject.transform.parent.parent.name;
        unity.Debug.Log("Hover enter event called for window "..windowName);
        frameOuter.material = frameOuterSelectMat;
        frameInner.material = frameInnerSelectMat;        
end

function on_hover_exited(args)
	    windowName = args.interactableObject.transform.parent.parent.name;
        unity.Debug.Log("Hover exit event called for window "..windowName);        
        frameOuter.material = frameOuterDefaultMat;
        frameInner.material = frameInnerDefaultMat;
end