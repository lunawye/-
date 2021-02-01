using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform hero;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - hero.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = hero.position + offset;
    }
}
