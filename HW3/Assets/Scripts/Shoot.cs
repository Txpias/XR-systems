using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using TMPro;

public class CrossbowShoot : MonoBehaviour
{
    public Transform firePoint; // Nuolen lähtöpiste
    public GameObject boltPrefab; // Nuoliprefab
    public float shootForce = 10f;
    public AudioSource selectSound;
    public InputActionProperty shootAction;
    public ScoreManager scoreManager; // Viittaus ScoreManageriin

    private bool isButtonPressed = false;

    private void OnEnable()
    {
        shootAction.action.Enable();
    }

    private void OnDisable()
    {
        shootAction.action.Disable();
    }

    private void Update()
    {
        if (shootAction.action.ReadValue<float>() > 0.5f)
        {
            if (!isButtonPressed && scoreManager.CanShoot())
            {
                ShootArrow();
                scoreManager.ArrowShot();
                isButtonPressed = true;
            }
        }
        else
        {
            isButtonPressed = false;
        }
    }

    private void ShootArrow()
    {
        // Luodaan nuoli ja ammutaan se
        GameObject bolt = Instantiate(boltPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bolt.GetComponent<Rigidbody>();

        rb.linearVelocity = Vector3.zero;

        // Säädetään nuolen nopeus ja lisätään gravitaatio
        rb.useGravity = true;
        rb.mass = 0.1f;
        rb.linearVelocity = firePoint.forward * shootForce;
        selectSound.Play();


        Debug.Log("Nuoli ammuttu!");
    }
}
