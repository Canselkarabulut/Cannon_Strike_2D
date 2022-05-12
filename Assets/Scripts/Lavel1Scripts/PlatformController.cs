using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlatformController :MonoBehaviour
{

    [SerializeField] Rigidbody2D _pltRb;
    [SerializeField] int _topuFýrlatmahizi = 15;
    [SerializeField] Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.SetBool("sahne1", true);

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Top")
        {
            _pltRb.velocity =  new Vector2(0, _topuFýrlatmahizi);

        }
    }
}
