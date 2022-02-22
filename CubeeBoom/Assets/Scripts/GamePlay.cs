using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public int force;
    [SerializeField] AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Cube"))
                {
                    audioSource.Play();
                    hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
                }
            }
        }
    }
}
