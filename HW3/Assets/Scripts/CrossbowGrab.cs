using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CrossbowGrab : MonoBehaviour
{
    public Transform attachPoint;
    private XRGrabInteractable interactable;
    private Rigidbody rb;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();

        if (attachPoint != null)
        {
            interactable.attachTransform = attachPoint; // Aseta kiinnityskohta oikein
        }
    }

    private void OnEnable()
    {
        interactable.selectEntered.AddListener(OnSelectEntered);
        interactable.selectExited.AddListener(OnSelectExited);
    }

    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(OnSelectEntered);
        interactable.selectExited.RemoveListener(OnSelectExited);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        rb.isKinematic = true; // Estä fysiikan bugit
        Debug.Log("Crossbow grabbed!");
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        rb.isKinematic = false; // Aktivoi fysiikka irrottaessa
        Debug.Log("Crossbow released!");
    }
}
