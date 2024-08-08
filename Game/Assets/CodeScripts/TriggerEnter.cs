using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    public GameObject objectGame;
    public UnityEvent enterEvent;
    private void OnTriggerEnter(){
        objectGame.SetActive(true);
        enterEvent.Invoke();
    }
}
