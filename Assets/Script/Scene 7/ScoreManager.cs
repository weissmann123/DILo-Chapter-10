using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Score;
    public int kill;
    public int killed;
    public SpawnObject sp;
    float elapsedtime;
    int delay;
    void Start()
    {
        kill = 0;
        killed = 0;
        elapsedtime = 0;
        delay = 3;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedtime += Time.deltaTime;
        if (killed > 0 && elapsedtime >= delay) {
            sp.Spawn();
            Debug.Log("spawned 1");
            killed--;
            elapsedtime = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            kill++;
            killed++;
            Score.text = kill.ToString();
            Destroy(collision.gameObject);
        }
    }
}
