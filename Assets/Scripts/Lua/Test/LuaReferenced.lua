local unity = CS.UnityEngine
local cs_coroutine = (require 'CSCoroutine')

function do_something()
	CS.UnityEngine.Debug.LogWarning("do_something was called")
	--do_something()

	cs_coroutine.start(self, function() -- can pass any function
		coroutine.yield(CS.UnityEngine.WaitForSeconds(3))
		unity.GameObject.Destroy(gameObject)
		CS.UnityEngine.Debug.LogWarning("GameObject deleted!")
	end)
end