using UnityEditor;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;

    private void Start()
    {
        if (obstaclePrefab == null)
        {
            return;
        }

        float count = (transform.localScale.z / obstaclePrefab.GetComponentsInChildren<Transform>()[1].transform.localScale.z) / 2;


        for (int i = 0; i < count; i++)
        {
            if (i % 2 == 0)
            {                
                Vector3 pos = new Vector3(-0.50f, transform.position.y + 1, (Random.Range(19,21) * (1 + i)) + (transform.position.z - 55));
                Instantiate(obstaclePrefab, pos, Quaternion.identity);                
            }
            else
            {                
                Vector3 pos = new Vector3(0.50f, transform.position.y + 1, (Random.Range(19,21) * (1 + i)) + (transform.position.z - 55));
                Instantiate(obstaclePrefab, pos, Quaternion.identity);
            }

            
        }

    }
}
