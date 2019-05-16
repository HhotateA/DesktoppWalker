using UnityEngine;
using System.Collections;

namespace DesktopWalker {
	public class IKLookAt : MonoBehaviour {

        private Animator avator;
		
		public Transform lookAtObj = null;
		
    	[SerializeField, Range(0, 1)]
		public float lookAtWeight = 1.0f;
    	[SerializeField, Range(0, 1)]
		public float bodyWeight = 0.3f;
    	[SerializeField, Range(0, 1)]
		public float headWeight = 0.8f;
   		[SerializeField, Range(0, 1)]
		public float eyesWeight = 1.0f;
    	[SerializeField, Range(0, 1)]
		public float clampWeight = 0.5f;

		void Start () {
            avator = GetComponent<Animator>();            
		}

		void OnAnimatorIK(int layorIndex) {	
			avator.SetLookAtWeight(lookAtWeight,bodyWeight,headWeight,eyesWeight,clampWeight);	
			avator.SetLookAtPosition(lookAtObj.position);
		}		  
	}
}
