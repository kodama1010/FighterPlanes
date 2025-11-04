using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GummyBear : MonoBehaviour
{

    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        float zDistance = Mathf.PingPong(Time.time * 2f, 3f);
        transform.position = StartPosition + new Vector3(0, 0, zDistance);
    }
}
