using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NAO UTILIZEI ESSE SCRIPT (AINDA, MAS QUEM SABE?)


public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    private void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime);
    }
}
