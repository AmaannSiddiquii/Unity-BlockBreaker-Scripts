using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; //serialized for debug needs

    SceneLoader1 sceneloader; //cached ref

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader1>();
    }


    public void CountBreakableBlocks()
    {
        breakableBlocks++;

    }

    public void BlockDestroyed()
    {

        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }

    }
   
}
