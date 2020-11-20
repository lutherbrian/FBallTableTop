using UnityEngine;

namespace KoganeUnityLib.Example
{
	public class Example : MonoBehaviour
	{
		public TMP_Typewriter   m_typewriter    ;
		public float            m_speed         ;
        public AudioSource TeletypeSound;
        public AudioClip teletypeaudio;


        private void Start()
        {
			LeanTween.delayedCall(gameObject, 2.0f, StartText);

		}
        private void Update()
		{
			
               
		}

		public void StartText()

		{
				m_typewriter.Play
							   (
								   text: "Birmingham<pos=30%>3<pos=50%>West Ham<pos=80%>0\nChelsea<pos=30%>3<pos=50%>Man United<pos=80%>0",
								   speed: m_speed,
								   onComplete: () => TeletypeSound.Stop()
							   );
				playSound();
			

			if (Input.GetKeyDown(KeyCode.V))
			{

				m_typewriter.Skip();
			}
			if (Input.GetKeyDown(KeyCode.B))
			{

				m_typewriter.Skip(false);
			}
			if (Input.GetKeyDown(KeyCode.N))
			{

				m_typewriter.Pause();
			}
			if (Input.GetKeyDown(KeyCode.M))
			{

				m_typewriter.Resume();
			}
		}


        void playSound()

        {
            TeletypeSound.PlayOneShot(teletypeaudio, 1.0f);
        }
	}
}