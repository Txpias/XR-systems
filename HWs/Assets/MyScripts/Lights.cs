using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lights : MonoBehaviour
{
    public InputActionReference action;
    public Light light;
    private Color color = Color.cyan;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
        action.action.performed += (ctx) =>
        {
            Debug.Log("color changed");
            light.color = color;
        };
        
    }

    // Update is called once per frame
}
