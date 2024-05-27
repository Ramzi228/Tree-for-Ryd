using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class EndGame : MonoBehaviour
{

    [SerializeField] private GameObject[] _objects;

    

    public YandexGame sdk;

    public void End()
    {
        Invoke(nameof(Set), 0.5f);

        
    }

    private void Set()
    {
        _objects[0].SetActive(true);
        _objects[1].SetActive(true);
    }


    public void Retry()
    {
        _objects[3].GetComponent<Score>()._set = 1;
        _objects[2].GetComponent<Animator>().SetTrigger("Show");
        Invoke(nameof(Load), 1f);
        YandexGame.FullscreenShow();
        Debug.Log("pokazal");
    }

    private void OnApplicationQuit()
    {
        _objects[3].GetComponent<Score>()._set = 1;
    }

    private void Load()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score._score = 0;
    }

    public void AdButton()
    {
        sdk._RewardedShow(1);
    }

    public void AdButtonCul()
    {

        Score._score += 15;
        

    }
}

