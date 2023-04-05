using UnityEngine;

public class WinArea : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameplayManager.playerName))
        {
            GameplayManager.instance.GameOver();
        }
    }
}
