using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public GameObject[] cubes = new GameObject[112];
    public Color[] randomColors;
    void Start()
    {
        for (int i = 1; i < cubes.Length + 1; i++)
        {
            cubes[i - 1] = GameObject.Find("Cube (" + i + ")");
        }
        foreach (GameObject cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = randomColors[Random.Range(0, randomColors.Length - 1)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
