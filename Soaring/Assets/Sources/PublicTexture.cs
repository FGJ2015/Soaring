using UnityEngine;
using System.Collections;
[RequireComponent(typeof(SetTexture))]
public class PublicTexture : SingletonMonoBehaviour<PublicTexture> {
    private SetTexture m_setTexture;
    public SetTexture SetTexture {
        get { return m_setTexture; }
    }
	// Use this for initialization
	void Awake () {
        m_setTexture = GetComponent<SetTexture>();	
	}

    static public Texture2D GetTexture(int index,string place)
    {
        return Instance.m_setTexture.GetTexture(index,place) as Texture2D;
    }

    static int armCount = 0;
    static public Texture2D GetTextureArm()
    {
        if (!Instance.m_setTexture.g_bFlag_Assets || Instance.m_setTexture.g_arAssets_Arm.Count<=0 || Instance.m_setTexture.g_arAssets_Body.Count <= 0)
            return null;
        armCount = armCount % Instance.m_setTexture.g_arAssets_Arm.Count;
        Texture2D tx=Instance.m_setTexture.GetTexture(armCount,"arm") as Texture2D;
        if (tx == null)
            return tx;
        armCount++;
        return tx;
    }

    static int bodyCount = 0;
    static public Texture2D GetTextureBody()
    {
        if (!Instance.m_setTexture.g_bFlag_Assets || Instance.m_setTexture.g_arAssets_Arm.Count <= 0 || Instance.m_setTexture.g_arAssets_Body.Count <= 0)
            return null;
        bodyCount = bodyCount % Instance.m_setTexture.g_arAssets_Body.Count;
        Texture2D tx = Instance.m_setTexture.GetTexture(bodyCount,"body") as Texture2D;
        if (tx == null)
            return tx;
        bodyCount++;
        return tx;
    }
}
