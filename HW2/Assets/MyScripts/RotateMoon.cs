using UnityEngine;

public class RotateAroundYAxis : MonoBehaviour
{
    public float degreesPerSecond = 20.0f;


    private void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
    }
}
