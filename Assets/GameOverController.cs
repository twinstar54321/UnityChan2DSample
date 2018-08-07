using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {

    [SceneName]
    public string nextLevel;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length + 1);

        SceneManager.LoadScene(nextLevel);
    }
}
