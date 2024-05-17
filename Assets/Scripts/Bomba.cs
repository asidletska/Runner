using UnityEngine;
using UnityEngine.Events;

public class Bomba : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject panelGameOver;
    public UnityEvent blowUp;


    private void OnTriggerEnter(Collider other)
    {
          if (other.CompareTag("Player"))
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            blowUp.Invoke();
            panelGameOver.SetActive(true);
        }
    }
}
