using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject panelLose;
    
        
    public void Lose()
    {
        panelLose.SetActive(true);
    }

    
}
