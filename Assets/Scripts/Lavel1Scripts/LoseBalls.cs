using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBalls : MonoBehaviour
{
    [SerializeField] Text _loseBallTxt;
    int _loseBallsCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.tag =="Top")
        {
            _loseBallsCount++;
            _loseBallTxt.text = "Lose Balls : " + _loseBallsCount;
        }
    }
}
