function start()
	CS.UnityEngine.Debug.LogWarning("This is a warning.")
    	self:GetComponent("MeshRenderer").enabled = false
	-- gameObject variable could also be used instead of this - this refers to the LuaComponent
end

local unity = CS.UnityEngine
local cube_location = gameObject

function update()
	local x = unity.Mathf.Cos(unity.Time.time)
	local y = unity.Mathf.Sin(unity.Time.time)

	local new_pos = unity.Vector3(cube_location.transform.position.x, cube_location.transform.position.y, cube_location.transform.position.z)

    local new_rot = unity.Quaternion.Euler(x * 360.0, 0.0, y * 360.0)

    gameObject.transform:SetPositionAndRotation(new_pos, new_rot)
end