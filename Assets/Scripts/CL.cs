using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CL : MonoBehaviour
{
    private void OnMouseEnter()  //���콺�� ������Ʈ ���� ���� ��
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    private void OnMouseExit()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
    }
}