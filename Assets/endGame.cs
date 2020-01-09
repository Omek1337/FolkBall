using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update

    void OnDestroy()
    {
        SceneManager.LoadScene(0);
    }
}
