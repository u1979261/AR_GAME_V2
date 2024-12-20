using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    public delegate void TriggerAction();
    public static event TriggerAction OnObjectTriggered;
    public GameObject personage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            float randomChance = Random.Range(0f, 1f);
            if (randomChance <= 0.2f)
            {
                OnObjectTriggered?.Invoke();
                Destroy(personage);
            }
        }
    }
}
