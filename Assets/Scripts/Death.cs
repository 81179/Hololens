using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour {
    public GameObject play;
    public GameObject gameOver;
    public GameObject title;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie") {
            GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
            for (int i = 0; i < zombies.Length; i++)
            {
                Destroy(zombies[i]);
            }
            play.SetActive(false);
            gameOver.SetActive(true);
            title.SetActive(true);
        }
    }
}
