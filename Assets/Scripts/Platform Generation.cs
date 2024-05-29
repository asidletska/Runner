using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    [SerializeField] private GameObject _platform;
    [SerializeField] private float _speed;
    [SerializeField] private int max_count;
    [SerializeField] private List<Platform> platforms = new List<Platform>();
    [SerializeField] private GameObject _coin;
    [SerializeField] private GameObject _bomb;
    [SerializeField] private float _startSpawnBomb = 3f;

    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        platforms.First().speed = _speed;
        for (int i = 0; i < max_count; i++)
        {
            GeneratePlatform();
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if(platforms.Count < max_count)
        {
            GeneratePlatform();
        }
    }
    private void GeneratePlatform()
    {
      GameObject newPlatformObject = Instantiate(_platform, platforms.Last().transform.position + Vector3.forward * _platform.transform.localScale.z, Quaternion.identity);
        Platform newPlatform = newPlatformObject.GetComponent<Platform>();
        newPlatform.Initialize(_coin, _bomb, _startSpawnBomb, _timer);
        newPlatform.speed = _speed;
        platforms.Add(newPlatform);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        platforms.Remove(other.GetComponent<Platform>());
        Destroy(other.gameObject);
    }
}
