using UnityEngine;
using System.Collections;
using UnityEngine.UI; //added
using UnityEngine.SceneManagement; //added

public class MenuScript : MonoBehaviour {
    //MAKE SURE FILE NAME AND CLASS NAME MATCH!

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;


	// Use this for initialization
	void Start () {

        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        
	}
	
    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        //try this if below doesnt work
        //SceneManager.LoadScene("MySceneName");
        Application.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
