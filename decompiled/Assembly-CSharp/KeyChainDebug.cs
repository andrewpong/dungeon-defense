// Decompiled with JetBrains decompiler
// Type: KeyChainDebug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

using UnityEngine;

public class KeyChainDebug : MonoBehaviour
{
  private string appKey = "application key";
  private string data = "user data";

  private void OnGUI()
  {
    GUILayout.BeginArea(new Rect(0.0f, 0.0f, (float) Screen.width, (float) Screen.height));
    GUILayout.Label("Application Key:");
    this.appKey = GUILayout.TextField(this.appKey);
    GUILayout.Label("User Data:");
    this.data = GUILayout.TextField(this.data);
    if (GUILayout.Button("Set"))
      KeyChainBinding.SetKeyChainData(this.appKey, this.data);
    if (GUILayout.Button("Get"))
    {
      string applicationKey;
      string data;
      KeyChainBinding.GetKeyChainData(out applicationKey, out data);
      Debug.Log((object) string.Format("retrieved key: \"{0}\" retrieved data: \"{1}\"", (object) applicationKey, (object) data));
    }
    if (GUILayout.Button("Reset"))
      KeyChainBinding.DeleteKeyChainData();
    GUILayout.EndArea();
  }
}
