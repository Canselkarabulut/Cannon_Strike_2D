using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControlLvl2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D _pltRb;
    [SerializeField] int _topuFýrlatmahizi = 15;
    [SerializeField] Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.SetBool("sahne2", true);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Top")
        {
           // _pltRb.velocity = new Vector2(0, _topuFýrlatmahizi);
        }
    }
}
