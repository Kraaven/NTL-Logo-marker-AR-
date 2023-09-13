using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonEvents : MonoBehaviour
{
    public void reload()
    {
        

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
