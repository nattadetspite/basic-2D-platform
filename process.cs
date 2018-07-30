using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Process : MonoBehaviour
{
	int t=1;
    private int Timeout = 5;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Timeout <= 0)
        {
			StartCoroutine("LoseTime");
            StopCoroutine("LoseTime");
			if(t == 1){
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
            Timeout--;
        }
    }
}