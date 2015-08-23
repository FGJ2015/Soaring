using UnityEngine;
using System.Collections;

public class Human : MonoBehaviour {
    public GameObject body;
    public GameObject leftArm;
    public GameObject righrArm;
	// Use this for initialization
	void Start () {
        if (!PublicTexture.Instance.SetTexture.g_bFlag_Assets || PublicTexture.Instance.SetTexture.g_arAssets_Body.Count <= 0)
            return;
        Texture2D bt = PublicTexture.GetTextureBody();
        if (bt == null)
            return;
        var mrb = body.GetComponent<MeshRenderer>();
        var mtb = new Material(mrb.material);
        mtb.mainTexture = bt;
        mrb.material = mtb;
        if (!PublicTexture.Instance.SetTexture.g_bFlag_Assets || PublicTexture.Instance.SetTexture.g_arAssets_Arm.Count <= 0)
            return;
        Texture2D at = PublicTexture.GetTextureArm();
        if (at == null)
            return;
        var mrl = leftArm.GetComponent<MeshRenderer>();
        var mtl = new Material(mrl.material);
        mtl.mainTexture = at;
        mrl.material = mtl;
        var mra = righrArm.GetComponent<MeshRenderer>();
        var mta = new Material(mra.material);
        mta.mainTexture = at;
        mra.material = mta;
    }

    // Update is called once per frame
    float rot = 0.0f;
	void Update () {
        transform.LookAt(Camera.main.transform.position);
        rot += 2.0f;
        leftArm.transform.Rotate(new Vector3(0.0f, 0.0f, -4.0f));
        righrArm.transform.Rotate(new Vector3(0.0f, 0.0f, 4.0f));
    }
}
