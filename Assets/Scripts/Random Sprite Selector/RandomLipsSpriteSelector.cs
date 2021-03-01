using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLipsSpriteSelector : MonoBehaviour
{
    [SerializeField] Sprite[] lips_SpritesArray;
    void Start()
    {
        SelectNewLipsSprite();
    }
    public void SelectNewLipsSprite()
    {
        GetComponent<SpriteRenderer>().sprite = lips_SpritesArray[Random.Range(0, lips_SpritesArray.Length)];
    }
}
