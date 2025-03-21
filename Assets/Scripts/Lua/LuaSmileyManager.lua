local unity = CS.UnityEngine
local lua_util = CS.ImmerzaSDK.Lua.LuaComponent

local startAngle = 96
local endAngle = 90
local speed = 4
local maxIntensityForSmiley = 2
local maxIntensityForSmileyFrame = 3.5
local duration = 30

local origSmileyMaterial
local origSmileyFrameMaterial

function start()
     desiredAngle = startAngle
     elapsedTime = duration

     interactable.hoverEntered:AddListener(on_hover_entered);
	 interactable.hoverExited:AddListener(on_hover_exited);

     -- Get the base color (assumes the material has an emission color)
        baseColor = smileyMaterial:GetColor("_EmissionColor")
    
        origSmileyMaterial = smileyRenderer.material;
        origSmileyFrameMaterial = smileyFrameRenderer.material;
end

function update()
        currentAngle = transform.localEulerAngles.y        
        if (unity.Mathf.Abs(desiredAngle - currentAngle) > 0.01) then
            -- Interpolate the angle
            currentAngle = unity.Mathf.LerpAngle(currentAngle, desiredAngle, speed * unity.Time.deltaTime);
            -- Apply the interpolated angle to the game object's rotation
            transform.localRotation = unity.Quaternion.Euler(0, currentAngle, -180);       
        end

        if (elapsedTime < duration) then
            elapsedTime = elapsedTime + unity.Time.deltaTime;

            --For Smiley
            intensity = unity.Mathf.Lerp(1, maxIntensityForSmiley, elapsedTime / duration);  -- Interpolate from 0 to 1

            -- Apply the new intensity to the material's emission
            smileyMaterial:SetColor("_EmissionColor", baseColor * intensity);

            --For Smiley Frame
            --Emission
            intensity = unity.Mathf.Lerp(1, maxIntensityForSmileyFrame, elapsedTime / duration);  -- Interpolate from 0 to 1
            -- Apply the new intensity to the material's emission
            smileyFrameMaterial:SetColor("_EmissionColor", baseColor * intensity);
            --Alpha
            alpha = unity.Mathf.Lerp(1, 0, elapsedTime / duration);
            -- Apply the new color with updated alpha
            smileyFrameMaterial.color = unity.Color(smileyFrameMaterial.color.r, smileyFrameMaterial.color.g, smileyFrameMaterial.color.b, alpha);
        end
end

--            unity.Debug.Log("ALL IS WELL")

function on_hover_entered(args)
	    desiredAngle = endAngle
        elapsedTime = 0        

        --Set smiley material        
        smileyRenderer.material = smileyMaterial        
        smileyFrameRenderer.material = smileyFrameMaterial
        
        lua_util.TriggerEvent("OnWindowEnterHover", { message = "Enter" })
end

function on_hover_exited(args)
        desiredAngle = startAngle
        elapsedTime = duration
        smileyMaterial:SetColor("_EmissionColor", baseColor);
        
        smileyFrameMaterial:SetColor("_EmissionColor", baseColor);
        smileyFrameMaterial.color = unity.Color(smileyFrameMaterial.color.r, smileyFrameMaterial.color.g, smileyFrameMaterial.color.b, 1);
        
        --Set smiley material back to original
        smileyRenderer.material = origSmileyMaterial;
        smileyFrameRenderer.material = origSmileyFrameMaterial;

	lua_util.TriggerEvent("OnWindowExitHover", { message = "Exit" })
end

function on_destroy()
	    smileyMaterial:SetColor("_EmissionColor", baseColor);
        smileyFrameMaterial:SetColor("_EmissionColor", baseColor);
        smileyFrameMaterial.color = unity.Color(smileyFrameMaterial.color.r, smileyFrameMaterial.color.g, smileyFrameMaterial.color.b, 1);
        
        --Set smiley material back to original       
        smileyRenderer.material = origSmileyMaterial;
        smileyFrameRenderer.material = origSmileyFrameMaterial;
end
