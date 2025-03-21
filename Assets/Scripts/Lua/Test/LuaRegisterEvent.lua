local lua_util = CS.ImmerzaSDK.Lua.LuaComponent

local unity = CS.UnityEngine

function awake()
	lua_util.RegisterEvent("CubeNotify", function (event_data)
			unity.Debug.Log(event_data.message)
		end
	)		
end