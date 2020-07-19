using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposeChildrenInEditor : MonoBehaviour
{
    [Header("In Line")]
    public int m_distanceOfObjectsInLine = 2;


    [ContextMenu("Put Children In Line")]
    public void SetInLine() {

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).localPosition = Vector3.right * i* m_distanceOfObjectsInLine;
        }
    }
}
