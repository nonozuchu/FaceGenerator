using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceSelector : MonoBehaviour
{
    [SerializeField]FaceBase[] face_GameObjectsArray;

    private void Start()
    {
        PickRandomFace();
    }
    public void PickRandomFace()
    {
        var selected_Face = face_GameObjectsArray[Random.Range(0, face_GameObjectsArray.Length)];
        Instantiate(selected_Face);
    }
}
