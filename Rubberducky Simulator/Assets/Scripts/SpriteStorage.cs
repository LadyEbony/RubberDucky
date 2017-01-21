//Store a list of sprites

using UnityEngine;
using System.Collections;
using System;

public class SpriteStorage : MonoBehaviour
{
    [SerializeField]
    private Sprite[] SpriteList;

    [SerializeField]
    private int DefaultSpriteId;

    private SpriteRenderer SpriteRenderer;

    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        if (SpriteRenderer == null)
            throw new Exception("SpriteStorage must have SpriteRenderer attached to the same game object.");
    }

    void Start()
    {
        SetSprite(0);
    }

    /// <summary>
    /// Set new sprite image by id
    /// </summary>
    public void SetSprite(int id)
    {
        SpriteRenderer.sprite = GetSprite(id);
        //Debug.Log("set to " + id);
    }

    /// <summary>
    /// Set new sprite image by name
    /// </summary>
    public void SetSprite(string name)
    {
        SpriteRenderer.sprite = GetSprite(name);
        //Debug.Log("set to " + name);
    }

    /// <summary>
    /// Returns the sprite in the sprite list, given its name.
    /// </summary>
    private Sprite GetSprite(string name)
    {
        foreach(Sprite sprite in SpriteList)
        {
            if (name == sprite.name)
                return sprite;
        }

        throw new Exception("Sprite " + name + " was not found in the specified Sprite List.");
    }

    /// <summary>
    /// Returns the sprite in the sprite list, given itsindex.
    /// </summary>
    private Sprite GetSprite(int index)
    {
        if (index < 0 || index > SpriteList.Length)
        {
            throw new Exception("Index " + index + " is not within this sprite list.");
        }

        return SpriteList[index];
        
    }
}
