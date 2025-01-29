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
        // Vaihda pelaajan sijaintia ja rotaatiota
        if (isExternalView)
        {
            // Siirr‰ takaisin huoneeseen
            transform.position = roomPosition.position;
            transform.rotation = roomPosition.rotation;
        }
        else
        {
            // Siirr‰ ulkopuoliseen n‰kym‰‰n
            transform.position = externalViewPosition.position;
            transform.rotation = externalViewPosition.rotation;
        }

        isExternalView = !isExternalView;
    }
}
