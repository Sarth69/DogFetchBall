using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeSinceLastDog = 3.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        timeSinceLastDog = Time.deltaTime + timeSinceLastDog;
        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastDog > 1.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeSinceLastDog = 0.0f;
        }
    }
}
