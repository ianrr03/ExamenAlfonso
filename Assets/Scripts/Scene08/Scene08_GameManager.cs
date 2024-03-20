using UnityEngine;

public class Scene08_GameManager : MonoBehaviour
{
    #region GameManager
    private static Scene08_GameManager instance;
    public static Scene08_GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                SetupInstance();
            }
            return instance;
        }
    }

    private static void SetupInstance()
    {
        instance = FindObjectOfType<Scene08_GameManager>();
        if (instance == null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = "GameManager";
            instance = gameObj.AddComponent<Scene08_GameManager>();
            DontDestroyOnLoad(gameObj);
        }
    }
    #endregion
}
