using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    [SerializeField] private GameObject go;
    private bool _active;

    public void ButtonFunction()
    {
        go.SetActive(Invert());
    }
    
    private bool Invert()
    {
        _active = !_active;
        return _active;
    }
}
