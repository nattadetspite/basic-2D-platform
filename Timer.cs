using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
	int t=1;
    public int timeLeft = 120;
    public Text countdownText;
 
    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }
 
    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);
 
        if (timeLeft <= 0)
        {
			StartCoroutine("LoseTime");
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
			if(t == 1){
				var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
				SceneManager.LoadScene(currentSceneIndex + 1);
				t=0;
				Destroy(gameObject);
			}

        }
		
    }
 
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}