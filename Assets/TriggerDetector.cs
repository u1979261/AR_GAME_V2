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
            Debug.Log(personage.name);
            float probability = GetProbabilityByName(personage.name);
            float randomChance = Random.Range(0f, 1f);

            if (randomChance <= probability)
            {
                OnObjectTriggered?.Invoke();
                Destroy(personage);
            }
        }
    }

    private float GetProbabilityByName(string name)
    {
        switch (name)
        {
            case "Bear":
                return 0.1f; // 50% probability
            case "Mutante":
                return 0.2f; // 80% probability
            case "Reno":
                return 0.3f; // 20% probability
            default:
                return 0.1f; // Default 10% probability
        }
    }
}
