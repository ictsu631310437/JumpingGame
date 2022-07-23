using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;

    public GameObject obstable1;
    public GameObject obstable2;
    public GameObject obstable3;
    public GameObject obstable4;
    public GameObject obstable5;
    public GameObject obstable6;
    public GameObject obstable_bird;

    int chooseObstacle;
    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            //generate Obstacle
            GenerateObstacle();
            timer = 0;
        }
    }

    void GenerateObstacle()
    {
        chooseObstacle = Random.Range(1, 8);
        if (chooseObstacle == 1) { GameObject newObstacle = Instantiate(obstable1); }
        if (chooseObstacle == 2) { GameObject newObstacle = Instantiate(obstable2); }
        if (chooseObstacle == 3) { GameObject newObstacle = Instantiate(obstable3); }
        if (chooseObstacle == 4) { GameObject newObstacle = Instantiate(obstable4); }
        if (chooseObstacle == 5) { GameObject newObstacle = Instantiate(obstable5); }
        if (chooseObstacle == 6) { GameObject newObstacle = Instantiate(obstable6); }
        if (chooseObstacle == 7) { GameObject newObstacle = Instantiate(obstable_bird); }

    }
}
