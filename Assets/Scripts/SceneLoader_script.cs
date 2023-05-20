using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader_script : MonoBehaviour
{
    public static SceneLoader_script instanceSceneLoader;

    public void OnClickButtonPlayGame()
    {
        // funktioniert irgwie noch nicht !!!
        SceneManager.LoadScene(1);
    }


    private void Awake()
    {
        // VL week 03
        if (instanceSceneLoader == null)        // if there is no SceneLoader
            instanceSceneLoader = this;         // then this should be the SceneLoader
        else                                    // if there is another SceneLoader
            Destroy(gameObject);                // then destroy it, so this will be the only existing one

        // each time when a scene is loaded, there will be the SceneLoader destroyed
        DontDestroyOnLoad(gameObject);          // this pretends this SCeneLoader to be destroyed
    }



    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            SceneManager.LoadScene(1);
    }
}
