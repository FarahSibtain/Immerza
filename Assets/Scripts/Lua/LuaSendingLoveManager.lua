local unity = CS.UnityEngine
local lua_comp = CS.ImmerzaSDK.Lua.LuaComponent

local particleSystem1
local particleSystem2
local particleSystem3

function start()
    particleSystem1 = ps1:GetComponent("ParticleSystem") 
    particleSystem2 = ps2:GetComponent("ParticleSystem") 
    particleSystem3 = ps3:GetComponent("ParticleSystem")	

    lua_comp.RegisterEvent("OnWindowEnterHover", function (event_data)
			particleSystem1:Play()
            particleSystem2:Play()
            particleSystem3:Play()
		    end
            )

    lua_comp.RegisterEvent("OnWindowExitHover", function (event_data)
			particleSystem1:Stop()
            particleSystem2:Stop()
            particleSystem3:Stop()
		    end
            )

    lua_comp.TriggerEvent("OnWindowExitHover", { message = "Exit" })
end

--[[
function on_window_enter_hover()    
    particleSystem1:Play()
    particleSystem2:Play()
    particleSystem3:Play()
end

function on_window_exit_hover()
    particleSystem1:Stop()
    particleSystem2:Stop()
    particleSystem3:Stop()    
end

    particleSystems = ps1:GetComponentsInChildren("ParticleSystem") 
    particleSystems = ps1:GetComponent("ParticleSystem") 
]]