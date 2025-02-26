using UnityEngine;
using UnityEngine.InputSystem;

public class Teleportplayer : MonoBehaviour
{
    // Pelaajan kaksi sijaintia
    public Transform roomPosition;
    public Transform externalViewPosition;
    
    public InputActionReference teleport;

    private bool isExternalView = false;

    void Start()
    {
        teleport.action.Enable();
        teleport.action.performed += (ctx) =>
        {
            SwitchPosition();
        };
        
    }

    void SwitchPosition()
    {
        if (isExternalView)
        {
            // Takaisin huoneeseen
            transform.position = roomPosition.position;
            transform.rotation = roomPosition.rotation;
        }
        else
        {
            // Ulkopuoliseen näkymään
            transform.position = externalViewPosition.position;
            transform.rotation = externalViewPosition.rotation;
        }

        isExternalView = !isExternalView;
    }
}
