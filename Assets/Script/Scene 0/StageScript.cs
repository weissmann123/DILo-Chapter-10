using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageScript : MonoBehaviour
{
    [SerializeField] private Button Stage1;
    [SerializeField] private Button Stage2;

    [SerializeField] private Button Stage3;
    [SerializeField] private Button Stage4;

    [SerializeField] private Button Stage5;
    [SerializeField] private Button Stage6;

    [SerializeField] private Button Stage7;
    [SerializeField] private Button Stage8;

    [SerializeField] private Button Back;
    // Start is called before the first frame update
    void Start()
    {
        Stage1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 1");
        });
        Stage2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 2");
        });

        Stage3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 3");
        });
        Stage4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 4");
        });

        Stage5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 5");
        });
        Stage6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 6");
        });

        Stage7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 7");
        });
        Stage8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Problem 8");
        });

        Back.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainMenu");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
