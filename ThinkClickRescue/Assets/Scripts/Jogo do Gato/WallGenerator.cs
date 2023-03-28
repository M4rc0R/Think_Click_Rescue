using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script que gera os foguinhos no chao e reutilizei ele pra gerar as arvores animadas do background

public class WallGenerator : MonoBehaviour
{
    public GameObject wall;
    public GameObject wall2;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;


    
    void Awake() 
    {
        currentSpeed = MinSpeed;

        if (timercontroller.temtempo == true) 
        {
            generateWall();
        }
        
        
    }
    
    public void GenerateNextWallWithGap()
    {
        if (timercontroller.temtempo == true) { 
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateWall", randomWait);
        }
    }
    public void generateWall()
    {
        GameObject WallIns = Instantiate(wall, transform.position, transform.rotation);

        WallIns.GetComponent<WallScript>().wallGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
