using UnityEngine;
using UnityEngine.Events;

public class Bomba : MonoBehaviour
{
    public GameObject explosionPrefab;
    public UnityEvent playAnimation;

    private void OnTriggerEnter(Collider other)
    {
          if (other.CompareTag("Player"))
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Invoke("Animation",1f);
            FindObjectOfType<GameManager>().GameOver();
        }
    }
    public void Animation()
    {
        playAnimation.Invoke();
    }


}
