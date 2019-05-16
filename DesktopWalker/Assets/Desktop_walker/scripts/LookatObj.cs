using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesktopWalker {
    public class LookatObj : MonoBehaviour {
        public float lookDepth = 1.5f;
        public Transform avatarObj = null;
        void Update() {
            if(avatarObj != null){
                Vector3 ScreenPos = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 AvaPos = Camera.main.WorldToScreenPoint(avatarObj.gameObject.transform.position);
                Vector3 CursorPos = new Vector3(Input.mousePosition.x, 
                                                Input.mousePosition.y,
                                                AvaPos.z-lookDepth); //アバターからの位置をカメラから1.5fと仮定
                CursorPos = Camera.main.ScreenToWorldPoint(CursorPos);
                transform.position = CursorPos;
            }else{
                Vector3 ScreenPos = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 CursorPos = new Vector3(Input.mousePosition.x, 
                                                Input.mousePosition.y,
                                                lookDepth); //デスクトップ画面の位置をカメラから1.5fと仮定
                CursorPos = Camera.main.ScreenToWorldPoint(CursorPos);
                transform.position = CursorPos;
            }
        }
    }
}