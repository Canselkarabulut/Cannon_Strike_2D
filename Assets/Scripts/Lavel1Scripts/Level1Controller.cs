using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1Controller : MonoBehaviour
{
    [SerializeField] GameObject[] _top;
    [SerializeField] GameObject _spawnNoktasi;
    int _randomIndex;
    int _spawnsay = 30;
    [SerializeField] Text _spawnBallCountTxt;
    [SerializeField] GameObject _countinePanel;
    [SerializeField] GameObject ballFinishPanel;

    private void Start()
    {
        _countinePanel.SetActive(false);
        
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BallSpawer();
        }
    }
    private void BallSpawer()
    {
        switch(_spawnsay <=0)
        {
            case true:
                ballFinishPanel.SetActive(true);
               // _countinePanel.SetActive(true);
              //  SceneManager.LoadScene(1);
               
                break;
            case false:
           
                _spawnsay--;
                _spawnBallCountTxt.text = _spawnsay.ToString();
                _randomIndex = Random.Range(0, _top.Length);
                Instantiate(_top[_randomIndex], _spawnNoktasi.transform.position, _spawnNoktasi.transform.rotation, _spawnNoktasi.transform);
                ballFinishPanel.SetActive(false);
                break;

        }
    }
    public void Next()
    {
        switch (SceneManager.sceneCount)
        {
            case 1:
                SceneManager.LoadScene(2);
                break;
            case 2:
                SceneManager.LoadScene(3);
                break;
        }
    }
   public void TryAgainBtn()
    {
        switch (SceneManager.sceneCount)
        {
            case 1:
                SceneManager.LoadScene(1);
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
        }
    }

}
