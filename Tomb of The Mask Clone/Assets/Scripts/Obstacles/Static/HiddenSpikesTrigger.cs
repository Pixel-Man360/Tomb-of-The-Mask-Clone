using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenSpikesTrigger : MonoBehaviour
{
    [Header("Dependencies:")]
    [SerializeField] private GameObject _usableSpikes;

    private enum SpikeDirection
    {
        left,
        right,
        up,
        down
    };


    [Header("Values:")]
    [SerializeField] private SpikeDirection _spikeDirection;


    private Vector3 _initialPosition;

    void Awake()
    {
        _initialPosition = _usableSpikes.transform.localPosition;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            HandleSpikeMovement();
        }
    }

    void HandleSpikeMovement()
    {
        HandleSpikeMoveDirection();
    }

    void HandleSpikeMoveDirection()
    {
        switch(_spikeDirection)
        {
            case SpikeDirection.left:
                StartCoroutine(ShowThenHide(new Vector3(-0.25f, _usableSpikes.transform.localPosition.y, 0f)));
            break;

            case SpikeDirection.right:
                StartCoroutine(ShowThenHide(new Vector3(0.25f, _usableSpikes.transform.localPosition.y, 0f)));
            break;

            case SpikeDirection.up:
                StartCoroutine(ShowThenHide(new Vector3(_usableSpikes.transform.localPosition.x, 0.25f, 0f)));
            break;

            case SpikeDirection.down:
               StartCoroutine(ShowThenHide(new Vector3(_usableSpikes.transform.localPosition.x, -0.25f, 0f)));
            break;
        }
    }

    IEnumerator ShowThenHide(Vector3 movePos)
    {
        _usableSpikes.SetActive(true);

        yield return new WaitForSeconds(1f);
        _usableSpikes.transform.localPosition += movePos;

        yield return new WaitForSeconds(0.5f);
        _usableSpikes.transform.localPosition += movePos;

        yield return new WaitForSeconds(0.8f);
        _usableSpikes.transform.localPosition = _initialPosition;
        
        _usableSpikes.SetActive(false);
    }
}
