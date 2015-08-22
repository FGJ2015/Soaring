using UnityEngine;

/// <summary>
/// Singleton mono behaviour.
/// </summary>
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour {
    private static GameObject singletonGameObject;
    private static T instance;
    public static T Instance {
        get {
            if (instance == null) {
                instance = FindObjectOfType<T>();

                if (instance == null) {
                    if (singletonGameObject == null) {
                        singletonGameObject = GameObject.Find("SingletonGameObject");
                        if (singletonGameObject == null) {
                            singletonGameObject = new GameObject("SingletonGameObject");
                            if (singletonGameObject == null) {
                                Debug.LogError(typeof(T) + "is nothing");
                                return null;
                            }
                        }
                    }
                    instance = singletonGameObject.AddComponent<T>();
                    if (instance == null) {
                        Debug.LogError(typeof(T) + "is nothing");
                        return null;
                    }
                    singletonGameObject = instance.gameObject;
                    DontDestroyOnLoad(singletonGameObject);
                }
            }
            return instance;
        }
    }

    protected void Awake() {
        if (instance == null) {
            instance = this as T;
            return;
        } else if (Instance == this) {
            return;
        }
        Destroy(this);
        return;
    }
}