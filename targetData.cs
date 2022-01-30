using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
    public class targetData : MonoBehaviour
    {

        public Transform TextTargetName;
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;

        public AudioSource soundTarget;
        public AudioClip clipTarget;

        // Use this for initialization
        void Start()
        {
		//add Audio Source as new game object component
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);
			
//Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

               
                ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);


//If the target name was “zombie” then add listener to ButtonAction with location of the zombie sound (locate in Resources/sounds folder) and set text on TextDescription a description of the zombie

                if(name == "alligator"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/crocodile"); });
                    TextDescription.GetComponent<Text>().text = "";
                }
               
                  if(name == "hippopotamus"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/hippo"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 
                 
                if(name == "pigTarget"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/pig"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 
 
                
                  if(name == "WolfTarget"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/wolf"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 

                if(name == "CrowTarget"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/crow"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 

                
                  if(name == "bear"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/bear"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 

                if(name == "FoxTarget"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/fox"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 

                if(name == "DuckTarget"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Duck"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 

                
                  if(name == "BoarTarget"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/boar"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 

                
                  if(name == "DeerTarget"){
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/deer"); });
                    TextDescription.GetComponent<Text>().text = "";
                } 
                if (name == "elephant")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/elephant"); });
                    TextDescription.GetComponent<Text>().text = "";
                }
                if (name == "Zebra")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/zebra"); });
                    TextDescription.GetComponent<Text>().text = "";
                }
               
                

                if (name == "chickenTarget")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/chicken"); });
                    TextDescription.GetComponent<Text>().text = "";
                }

                if (name == "alligator")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/crocodile"); });
                    TextDescription.GetComponent<Text>().text = "";
                }







//If the target name was “unitychan” then add listener to ButtonAction with location of the unitychan sound (locate in Resources/sounds folder) and set text on TextDescription a description of the unitychan / robot

                if (name == "unitychan")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/rhinoceros"); });
                    TextDescription.GetComponent<Text>().text = "";
                }
            }
        }

//function to play sound
        void playSound(string ss){
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }
    }
}
