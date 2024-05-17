using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private CharacterController _characterController;
    public UnityEvent addCoin;
    public UnityEvent collisionBomb;

    void Update()
    {
        _characterController.Move(Vector3.right * _speed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            addCoin.Invoke();
        }
        else if (other.tag == "bomb")
        {
            collisionBomb.Invoke();
        }
    }
}
