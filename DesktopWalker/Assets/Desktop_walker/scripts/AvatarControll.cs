using UnityEngine;
using System.Collections;

namespace DesktopWalker {
    [RequireComponent(typeof(Animator))]
    public class AvatarControll : MonoBehaviour {

        private Animator anim;
        private AnimatorStateInfo currentState;

        public Transform lookAtObj = null;
        public Transform walkAtObj = null;
        private float timeleft;

        public float minTime = 15.0f;
        public float maxTime = 20.0f;

        public float walkDist = 0.11f;
        public float walkspeed = 0.01f;

        // Use this for initialization
        void Start () {
            anim = GetComponent<Animator> ();
            timeleft = 0.0f;
            currentState = anim.GetCurrentAnimatorStateInfo (0);
        }

        void  Update () {
            //30-60秒ごとにランダムなアニメーションを再生
            timeleft -= Time.deltaTime;
            if (timeleft <= 0.0) {
                timeleft = Random.Range(15.0f, 20.0f);
                float animrand = Random.Range(0.0f,4.0f);
                if(animrand<1){
                    anim.SetTrigger("idle1");
                }else if(animrand<2){
                    anim.SetTrigger("idle2");
                }else if(animrand<3){
                    anim.SetTrigger("idle3");
                }else{
                    anim.SetTrigger("idle4");
                }
            }

            //walkatがwalkDist以上離れたら歩く
            Vector3 vecdelta = transform.position - walkAtObj.position;

            //歩行アニメーション
            if (walkAtObj != null) {
                if (vecdelta.magnitude > walkDist) {
                    anim.SetBool("walk", true);
                }else{
                    anim.SetBool("walk", false);
                }
            }

            //オブジェクトの移動
            if (vecdelta.magnitude > walkDist) {
                transform.position = transform.position - walkspeed * vecdelta.normalized;
                transform.LookAt(new Vector3(walkAtObj.position.x, 0, walkAtObj.position.z), new Vector3(0,1,0));
            }else {
                transform.position = walkAtObj.position;
                transform.LookAt(new Vector3(lookAtObj.position.x, 0, lookAtObj.position.z), new Vector3(0,1,0));
            }
        }

    }
}