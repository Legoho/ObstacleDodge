using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab1;
    [SerializeField] GameObject projectilePrefab2;
    [SerializeField] GameObject projectilePrefab3;
    [SerializeField] GameObject projectilePrefab4;
    [SerializeField] GameObject projectilePrefab5;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
       {
            projectilePrefab1.SetActive(true);
            projectilePrefab2.SetActive(true);
            projectilePrefab3.SetActive(true);
            projectilePrefab4.SetActive(true);
            projectilePrefab5.SetActive(true);
            Destroy(gameObject);

        }
    }
}

