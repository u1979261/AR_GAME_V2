using UnityEngine;
using TMPro;
public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Usa TextMeshProUGUI en lugar de Text
    private int score = 0;

    private void OnEnable()
    {
        TriggerDetector.OnObjectTriggered += UpdateScore; // Suscribirse al evento
    }

    private void OnDisable()
    {
        TriggerDetector.OnObjectTriggered -= UpdateScore; // Desuscribirse del evento
    }

    private void UpdateScore()
    {
        score += 1; // Incrementar el puntaje
        scoreText.text = "Captures: " + score; // Actualizar el texto
    }
}
