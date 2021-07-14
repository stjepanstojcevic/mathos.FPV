using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransferManager : MonoBehaviour
{
    static SceneTransferManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("0");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("1");
        }

        if (SceneManager.GetActiveScene().name == "1")
        {
            gameObject.transform.position = new Vector3(0, 0, -5);
        }

        if (SceneManager.GetActiveScene().name == "0")
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
        }

    }
}