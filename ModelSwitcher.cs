using UnityEngine;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject[] models; // Assign your models in the Inspector
    private int currentIndex = 0;

    void Start()
    {
        ShowOnlyCurrentModel();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            SwitchModel(-1);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            SwitchModel(1);
    }

    void SwitchModel(int direction)
    {
        currentIndex += direction;

        if (currentIndex < 0)
            currentIndex = models.Length - 1;
        else if (currentIndex >= models.Length)
            currentIndex = 0;

        ShowOnlyCurrentModel();
    }

    void ShowOnlyCurrentModel()
    {
        for (int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(i == currentIndex);
        }
    }
}
