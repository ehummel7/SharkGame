using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SharkScore : MonoBehaviour
{
    private float time = 300;
    public int score = 0;
    public float health = 100;

    public GameObject scoreUI;
    public GameObject healthUI;


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        scoreUI.gameObject.GetComponent<Text>().text = ("Score: " + score);
        healthUI.gameObject.GetComponent<Text>().text = ("Health: " + health);


        if (time < 0.1f)
        {
            Die();
        }

        if(health < 0.1f)
		{
            Die();
		}
    }

    void OnTriggerEnter2D(Collider2D trig)
	{
        if(trig.gameObject.tag == "CorrectFish")
		{
            score += 10;
            Destroy(trig.gameObject);
		}

        if(trig.gameObject.tag == "IncorrectFish")
		{
            score -= 10;
            health -= 10;
            Destroy(trig.gameObject);
		}
	}

    void Die()
	{
        SceneManager.LoadScene("SampleScene");

    }
}
