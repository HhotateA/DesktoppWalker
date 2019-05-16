using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesktopWalker {
    public class WalkatObj : MonoBehaviour {
        public Transform floorObj = null;
        private float xmax;
        private float xmin;
        private float ypos;
        private float zmax;
        private float zmin; 
        void Start() {
            Vector3 floorPos = floorObj.gameObject.transform.position;
            Vector3 floorScale = floorObj.gameObject.transform.localScale;
            xmax = floorPos.x + 5.0f * floorScale.x;
            xmin = floorPos.x - 5.0f * floorScale.x;
            ypos = floorPos.y;
            zmax = floorPos.z + 5.0f * floorScale.z;
            zmin = floorPos.z - 5.0f * floorScale.z;
        }
        void Update() {
            if (Input.GetButtonDown("Fire1")) {
                Vector3 ScreenPos = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 CursorPos = new Vector3(Input.mousePosition.x, 
                                                Input.mousePosition.y,
                                                ScreenPos.z);  // Z軸方向には移動させないので初期位置のまま
                CursorPos = Camera.main.ScreenToWorldPoint(CursorPos);
                Vector3 tmp = Camera.main.gameObject.transform.position;
                Vector3 vec = CursorPos - tmp; //カメラ-カーソル位置のベクトル
                float dist = (tmp.y-ypos) / vec.y;
                Vector3 pos = tmp - vec * dist; //y=0の時(床に衝突)
                pos.x = Mathf.Clamp(pos.x,xmin,xmax);
                pos.y = ypos;
                pos.z = Mathf.Clamp(pos.z,zmin,zmax);
                transform.position = pos;
            }
        }
    }
}