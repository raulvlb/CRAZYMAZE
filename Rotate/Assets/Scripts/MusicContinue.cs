using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContinue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private static MusicContinue instance = null;
    public static MusicContinue Instance
    {
        get { return instance; }
    }

    void Awake(){
        if (instance != null && instance != this){
            Destroy(this.gameObject);
            return;
        }else{
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
