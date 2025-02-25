using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private Transform testPosition;

    void Update()
    {
        float x = Mathf.Cos(Time.time);
        float y = Mathf.Sin(Time.time);

        transform.SetPositionAndRotation(new Vector3(testPosition.position.x + x, testPosition.position.y + y, testPosition.position.z), 
            Quaternion.Euler(x * 360.0f, 0.0f, y * 360.0f)
        );
    }
}
