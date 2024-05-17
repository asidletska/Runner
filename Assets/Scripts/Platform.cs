using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    [SerializeField] private List<Transform> points = new List<Transform>();
    private GameObject _coin;
    private GameObject _bomb;
    private float _startSpawnBomb;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        if (_coin == null || _bomb == null)
        {
           return;
        }

        int randomPointIndex = Random.Range(0, points.Count);

        if (_timer < _startSpawnBomb)
        {
            CreateObject(randomPointIndex, _coin);
        }
        else 
        {
            float chanceSpawnBomb = 20 + (_timer / 2);
            chanceSpawnBomb = Mathf.Clamp(chanceSpawnBomb, 0, 50);
            if (Random.Range(0, 100) < chanceSpawnBomb)
            {
                CreateObject(randomPointIndex, _bomb);
            }
            else
            {
                CreateObject(randomPointIndex, _coin);
            }
        }
    
    }
    public void CreateObject(int randomPointIndex, GameObject createdObject)
    {
        GameObject newCoin = Instantiate(createdObject, points[randomPointIndex].position, Quaternion.identity);
        newCoin.transform.SetParent(transform); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.back * speed * Time.fixedDeltaTime);
    }
    public void Initialize(GameObject coin, GameObject bomb, float startSpawnBomb, float timer)
    {
        _coin = coin;
        _bomb = bomb;
        _startSpawnBomb = startSpawnBomb;
        _timer = timer;

    }
}
