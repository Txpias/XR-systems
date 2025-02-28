using UnityEngine;

public class TargetScoring : MonoBehaviour
{
    public ScoreManager scoreManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            int points = GetPointsForHit(other.transform.position);
            Debug.Log("Pisteet: " + points);

            if (scoreManager != null)
            {
                scoreManager.AddPoints(points); 
            }
        }
    }

    int GetPointsForHit(Vector3 hitPosition)
    {
        float radius = GetComponent<SphereCollider>().radius * transform.localScale.x;
        float distance = Vector3.Distance(hitPosition, transform.position);

        if (distance < radius * 0.2f) return 10;
        if (distance < radius * 0.4f) return 8;
        if (distance < radius * 0.6f) return 5;
        if (distance < radius * 0.8f) return 3;
        return 1;
    }
}
