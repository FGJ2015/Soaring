using UnityEngine;
using System.Collections;

public class PublicTextureTest : MonoBehaviour {
    bool textureFlag = false;
	// Use this for initialization
	void Update () {
        if (textureFlag)
            return;
        if (!PublicTexture.Instance.SetTexture.g_bFlag_Assets || PublicTexture.Instance.SetTexture.g_arAssets_Body.Count <= 0)
            return;
        Texture2D bt = PublicTexture.GetTexture(0,"body");
        if (bt == null)
            return;
        textureFlag = true;
        var mr = GetComponent<MeshRenderer>();
        var mt = mr.material;
        mt.mainTexture = bt;
	}	
}
