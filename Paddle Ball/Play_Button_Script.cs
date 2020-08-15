using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu_Script : MonoBehaviour
{
    public void ChangeColor()
    {
        GetComponent<Text>().color = Color.yellow;
    }
}
