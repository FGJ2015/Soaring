#pragma strict

var g_arTextures = new ArrayList();
var g_length = 10;
var g_arAssets_Body : ArrayList = new ArrayList();
var g_arAssets_Arm : ArrayList = new ArrayList();
var g_url;
var g_bFlag_Assets = false;

function Start () {
	StartCoroutine("GetTextureList");

}

function Update () {
}

function GetTexture(index, place) {
	if ( g_bFlag_Assets )
	{
		while ( parseInt( index.ToString() ) >= g_length )
		{
			index = parseInt( index.ToString() ) - g_length;
		}

		switch ( place )
		{
			case "arm":
				return g_arAssets_Arm[index];
		
			case "body":
				return g_arAssets_Body[index];
		}
	}
	else
	{
		return null;
	}

	return null;
}

function GetTextureList() {
	var www : WWW = new WWW ("http://fgj.igda.jp/drawws/assets.php?count=" + g_length);
	yield www;
	eval( www.text + ";BuildTextures( drawws_assets );" );
}

function BuildTextures(drawws_assets) {
	var assets : Array = drawws_assets;

	for ( var i = 0; i < g_length; i++ )
	{
		var aaAsset : Hashtable = assets[i];
		var aaBody : Hashtable = aaAsset["body"];
		var aaArm : Hashtable = aaAsset["arm"];
		g_url = aaBody["image"];
		StartCoroutine("AddTexture_Body");
		g_url = aaArm["image"];
		StartCoroutine("AddTexture_Arm");
	}

	Debug.Log ("completed");
	g_bFlag_Assets = true;
}

function AddTexture_Body() {
	var www : WWW = new WWW (g_url);
	Debug.Log (g_url);
	yield www;
	g_arAssets_Body.Add(www.texture);
}

function AddTexture_Arm() {
	var www : WWW = new WWW (g_url);
	Debug.Log (g_url);
	yield www;
	g_arAssets_Arm.Add(www.texture);
}

