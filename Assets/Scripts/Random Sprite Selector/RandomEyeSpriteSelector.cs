using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEyeSpriteSelector : MonoBehaviour
{
    
    [SerializeField] Sprite[] eyes_SpritesArray;
    void Start()
    {
        SelectNewEyeSprite();
    }

    // Update is called once per frame
    public void SelectNewEyeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = eyes_SpritesArray[Random.Range(0, eyes_SpritesArray.Length)];
    }
}
