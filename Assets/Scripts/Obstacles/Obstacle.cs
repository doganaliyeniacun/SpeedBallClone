using UnityEngine;
using UnityEngine.Events;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameplayManager.playerName))
        {
            GameplayManager.instance.GameOver();
        }
    }
}
