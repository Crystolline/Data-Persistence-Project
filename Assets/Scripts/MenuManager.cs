using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameField;
    public TextMeshProUGUI BestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance != null && GameManager.Instance.bestScore != 0)
        {
            if (GameManager.Instance.bestName != "")
            {
                BestScoreText.text = $"Best Score: {GameManager.Instance.bestName}: {GameManager.Instance.bestScore}";
            }
            else
            {
                BestScoreText.text = $"Best Score: {GameManager.Instance.bestScore}";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void UpdateName()
    {
        GameManager.Instance.NewNameEntered(nameField.text);
    }
}
