using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNoseSpriteSelector : MonoBehaviour
{
    [SerializeField] Sprite[] nose_SpritesArray;
    void Start()
    {
        SelectNewNoseSprite();
    }

    // Update is called once per frame
    public void SelectNewNoseSprite()
    {
        GetComponent<SpriteRenderer>().sprite = nose_SpritesArray[Random.Range(0, nose_SpritesArray.Length)];
    }
}
