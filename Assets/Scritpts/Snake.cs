using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Snake : MonoBehaviour
{
    public List<Transform> Tails;
    public float BonesDistance;
    public GameObject BonesPrefab;
    [Range(0, 4)]
    public float Speed;
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();

    }

    private void Update()
    {
        MoveSnake(_transform.position + _transform.forward * Speed);

        float angel = Input.GetAxis("Horizontal") * 4;
        _transform.Rotate(0, angel, 0);
    }

    private void MoveSnake(Vector3 newPosition)
    {
        _transform.position = newPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
           var bone = Instantiate(BonesPrefab);
            Tails.Add(bone.transform);
        }
    }

}


