local lua_util = CS.ImmerzaSDK.Lua.LuaComponent

function start()
    lua_util.TriggerEvent("CubeNotify", { message = "Hello from GetLuaComponentReference!" })
end