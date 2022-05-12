using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class MoveController : MonoBehaviour
{
    [SerializeField] float _oyundaKalacagiSure;
    float _currentTime;
    bool yokEt;
    void Update()
    {
        if (yokEt)
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _oyundaKalacagiSure)
            {
                Destroy(this.gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "YokEt")
        {
            yokEt = true;
        }
        else
        {
            yokEt = false;
        }
    }
}
