using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject panelGameOver;

    private void OnTriggerEnter(Collider other)
    {
          if (other.CompareTag("Player"))
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosionPrefab);
            Time.timeScale = 1f;
            panelGameOver.SetActive(true);
        }
    }
}
