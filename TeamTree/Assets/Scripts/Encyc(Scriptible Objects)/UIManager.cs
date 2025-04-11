using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject popupPanel;
    public Image popupImage;
    public Text popupTitle;
    public Text popupDescription;

    public GameObject encyclopediaPanel;
    public Transform encyclopediaContent;
    public GameObject bugEntryPrefab;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            UIManager.Instance.OpenEncyclopedia();
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            UIManager.Instance.CloseEncyclopedia();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {

            UIManager.Instance.ClosePopup();
        }
       // if(Input.GetKeyDown(KeyCode.P))
       // {
          
       // }
    }
    public void ShowBugPopup(BugData bug)
    {
        popupTitle.text = bug.bugName;
        popupDescription.text = bug.info;
        popupImage.sprite = bug.bugImage;

        popupPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OpenEncyclopedia()
    {
      
        foreach (Transform child in encyclopediaContent)
        {
            Destroy(child.gameObject);
        }

        
        foreach (var bug in BugManager.instance.discoverdBugs)
        {
            GameObject entry = Instantiate(bugEntryPrefab, encyclopediaContent);
            entry.GetComponentInChildren<Text>().text = bug.bugName;
            entry.GetComponentInChildren<Image>().sprite = bug.bugImage;
        }

        encyclopediaPanel.SetActive(true);
    }

    public void CloseEncyclopedia()
    {
        encyclopediaPanel.SetActive(false);
    }
}

