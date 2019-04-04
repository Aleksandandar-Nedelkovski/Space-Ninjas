using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlButtonManager : MonoBehaviour
{
    public void Restart ()
    {
        Application.LoadLevel(0);
    }
}
