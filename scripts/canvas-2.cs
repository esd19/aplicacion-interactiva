using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    public GameObject canvas1;  // Arrastra el Canvas 1 desde la jerarquía
    public GameObject canvas2;  // Arrastra el Canvas 2 desde la jerarquía

    public void SwitchCanvas()
    {
        canvas1.SetActive(false);  // Oculta Canvas 1
        canvas2.SetActive(true);   // Muestra Canvas 2
    }
}
