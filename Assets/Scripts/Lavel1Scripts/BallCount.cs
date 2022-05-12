using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallCount : MonoBehaviour
{
    [SerializeField] Text _ballCountTxt;
    int _ballcount = 0;
    [SerializeField] GameObject _countinePanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Top")
        {
            _ballcount++;
            if(_ballcount <= 20)
            {
                _ballCountTxt.text = $"{_ballcount} / 20";
            }
            else
            {
               
                _countinePanel.SetActive(true);
            }
        }
    }
}
