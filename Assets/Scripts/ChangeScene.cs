using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{ 
    public string sceneName; //Nom de la scene vers laquelle on va
    void Start(){}

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(sceneName);
    }
}
