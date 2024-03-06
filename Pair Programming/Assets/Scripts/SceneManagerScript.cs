using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitingCouroutine());
    }
    
    IEnumerator WaitingCouroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainScene");
    }
}
