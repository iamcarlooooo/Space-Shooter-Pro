using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;

    void Update()
    {
        transform.Translate(new Vector3(0, _speed * Time.deltaTime, 0));

        if (transform.position.y >= 8f)
        {
            Destroy(gameObject);

        }
    }
}
