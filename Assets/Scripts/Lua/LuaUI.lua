local unity = CS.UnityEngine
local crt_num = 0

function start()
	local num_comp = num_field:GetComponent("TMP_Text")
	num_comp.text = crt_num
	increment_button:GetComponent("Button").onClick:AddListener(function()
		crt_num = crt_num + 1
		num_comp.text = crt_num
	end)
end