using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;
    private bool isShowingMenu = false;

    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;

    void Start()
    {
        // Ẩn menu khi bắt đầu
        GameMenu.enabled = isShowingMenu;

        // Tải nội dung text tự động từ mã nguồn
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want continue?";
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    public void NextScene()
    {
        SceneManager.LoadScene("_Scene_1");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("_Scene_3_2");
    }
}