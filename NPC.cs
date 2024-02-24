using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NPC : MonoBehaviour
{
    public int vida = 5;
    public int level = 1;
    public float speed = 1.2f;

    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        vida += level;
        print(vida);
        newPosition.y = 1;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
