// There are many ways of getting access to the main camera, but the approach here using
// a singleton works for any kind of MonoBehaviour.
using UnityEngine;

public class CameraSingleton : MonoBehaviour
{
    public static Camera Instance;

    void Awake()
    {
        Instance = GetComponent<Camera>();
    }
}