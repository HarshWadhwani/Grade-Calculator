using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddClass : MonoBehaviour
{
    [SerializeField] private GameObject classButton;
    [SerializeField] private GameObject canvas;

    public void CreateNewButton()
    {
        Instantiate(classButton, new Vector2(0, 0), Quaternion.identity, canvas.transform);
    }
}
