using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform2l : MonoBehaviour
{
    int count = 0;
    public int highscore;
    [SerializeField] Text HighScoreText;
    [SerializeField] Text T_count;
    [SerializeField] AudioSource audioSource;

    void Start()
    {

    }

    void Update()
    {
        T_count.text = count.ToString();
        CheckRecord();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            count++;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            count--;
        }
    }

    private void CheckRecord()
    {
        highscore = (int)count;
        if (PlayerPrefs.GetInt("count2") < highscore)
        {
            PlayerPrefs.SetInt("count2", highscore);
            audioSource.Play();
        }
        HighScoreText.text = "RECORD: " + PlayerPrefs.GetInt("count2").ToString();
    }
}
