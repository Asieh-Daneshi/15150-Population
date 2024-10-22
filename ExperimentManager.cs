using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
// using scripts.Jatos;
using Random=UnityEngine.Random;
using System.Linq;

public class ExperimentManager : MonoBehaviour
{
	// google form data collection :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	[SerializeField]
	public string BASE_URL="https://docs.google.com/forms/u/0/d/e/1FAIpQLSezZyRRFzd8c6idOIBzqDD77i4Rcx_2mGOkexh-85yqSBbJfA/formResponse"; // URL of the google form 

	// address contains addresses to each question field in the form ...............................................................
	// private string[] address = new string[] {"entry.1999917522","entry.837571715","entry.176587697","entry.1787402673","entry.645230853","entry.1158964578","entry.1888521446","entry.1785148826","entry.1394827684","entry.1357288164","entry.1827920477","entry.302692730","entry.1456553159","entry.2052447624","entry.599168045","entry.467797710","entry.1865651058","entry.1675183321","entry.859251791","entry.696583781","entry.1284083772","entry.617047882","entry.1602804280","entry.951861515","entry.842002701","entry.284653438","entry.155309467","entry.1630217206","entry.2028926723","entry.2024761984","entry.661151237","entry.1178273108","entry.1329495400","entry.1139834709","entry.861050361","entry.1363107039","entry.1248845983","entry.1443573082","entry.1616533018","entry.1215157525","entry.1632204790","entry.1626818057","entry.783133901","entry.1113319548","entry.1912182312","entry.63626121","entry.1439549708","entry.1292592469","entry.881909567","entry.268394484","entry.175889029","entry.219129905","entry.1178279973","entry.1193313861","entry.269001236","entry.498042810","entry.1964346856","entry.1230472364","entry.490942525","entry.638722599","entry.523715843","entry.671168823","entry.2035768229","entry.1663006433","entry.312288105","entry.1890441255","entry.1034032106","entry.608746679","entry.1585984491","entry.1712233666","entry.1402477302","entry.249327086","entry.1023571914","entry.1795777164","entry.1770767467","entry.1479324078","entry.1112170689","entry.1932108477","entry.820178464","entry.350787996","entry.1409061982","entry.667413866","entry.1487611046","entry.2040376192","entry.1040871654","entry.1861826531","entry.2132736982","entry.871385182","entry.1049104815","entry.431728064","entry.1590663591","entry.1946225607","entry.1574780830","entry.198231677","entry.1159930255","entry.1975336631","entry.1692964721","entry.2143890128","entry.925973439","entry.1931616011","entry.2124937293","entry.1114139210","entry.863128398","entry.707546952","entry.1766919119","entry.2018322132","entry.52513326","entry.858640675","entry.1199244880","entry.1288493091","entry.1393610336","entry.738493828","entry.473216645","entry.45989188","entry.193829703","entry.921152083","entry.692028319","entry.1018916758","entry.234519000","entry.1143670093","entry.1005746394","entry.1943693350","entry.668704061","entry.724720495","entry.1951565246","entry.1167283984","entry.682597900","entry.879788461","entry.1708913631","entry.652439124","entry.1406295844","entry.190529595","entry.2059805969","entry.1658603072","entry.1520181620","entry.7386447","entry.26076756","entry.2114767445","entry.1823182001","entry.850868066","entry.1901665168","entry.1697756291","entry.1963042950","entry.909711823","entry.1449930848","entry.1527769768","entry.688371065","entry.298988769","entry.830912850","entry.530693406","entry.860295148","entry.1495030444","entry.1123811225","entry.1373176950","entry.123288071","entry.724891871","entry.892197776","entry.205387242","entry.693108893","entry.1918189599","entry.999938520","entry.2130008863","entry.150105084","entry.700995234","entry.1981750551","entry.1049208918","entry.864017416","entry.2125446824","entry.18139483","entry.624310178","entry.1628290583","entry.1335338178","entry.2028107917","entry.1740575523","entry.2037492634","entry.1612810593","entry.301963123","entry.39644151","entry.175358090","entry.849024451","entry.207447425","entry.169608679","entry.173216614","entry.492838079","entry.436746779","entry.628256499","entry.432592843","entry.741206404","entry.1718454535","entry.1220394426","entry.1005362392","entry.219770821","entry.1924154443","entry.1294786518","entry.856744231","entry.22946595","entry.551510588","entry.228782302","entry.627863738","entry.1710424788","entry.2019800477","entry.1830246119","entry.661345846","entry.207288098","entry.1108544641","entry.1399526167","entry.1201478875","entry.1053231874","entry.970451269","entry.591870739","entry.493350169","entry.1204826234","entry.742915224","entry.574111814","entry.134518324","entry.1305189404","entry.1343014516","entry.840913051","entry.1836465148","entry.215031337","entry.1718293256","entry.58152714","entry.1673723508","entry.1638424792","entry.269872164","entry.386407090","entry.2089528528","entry.891188137","entry.810174557","entry.1823357824","entry.1094158169","entry.798680036","entry.494617990","entry.227182486","entry.879941624","entry.1772489561","entry.86539778","entry.1860853812","entry.111239946","entry.709073174","entry.1819740215","entry.1961167804","entry.80842377","entry.1587375263","entry.1024229239","entry.2108942993","entry.1986760620","entry.1859066258","entry.666315091","entry.64169819","entry.1627287267","entry.3183685","entry.1364408679","entry.671919623","entry.221593198","entry.775937613","entry.485068460","entry.556643711","entry.983891918","entry.573529892","entry.1825441849","entry.333755488","entry.324752715","entry.891780518","entry.1966089024","entry.1765708170","entry.1411544531","entry.1857636600","entry.452534403","entry.1341923408","entry.29053707","entry.678495468","entry.116353755","entry.928882619","entry.1981204197","entry.483223132","entry.1903255055","entry.2038639014","entry.1263105767","entry.288556374","entry.662336667","entry.401616238","entry.850733817","entry.1084684316","entry.1730699912","entry.835069292","entry.170024417","entry.1369225654","entry.2062914969","entry.1177731949","entry.1653990885","entry.1032390956","entry.1935328693","entry.984311859","entry.129768363","entry.995220679","entry.1661282944","entry.120038658","entry.1986476869","entry.1970950147","entry.1271859807","entry.363707897","entry.950083611","entry.1067329322","entry.1248503470","entry.265477592","entry.1321942044","entry.2047496503","entry.316618822","entry.811908953"};
	private string[] address = new string[] {"entry.1999917522","entry.837571715","entry.176587697","entry.1787402673","entry.645230853","entry.1158964578","entry.1888521446","entry.1785148826","entry.1394827684","entry.1357288164","entry.1827920477","entry.302692730","entry.1456553159","entry.2052447624","entry.599168045","entry.467797710","entry.1865651058","entry.1675183321","entry.859251791","entry.696583781","entry.1284083772","entry.617047882","entry.1602804280","entry.951861515","entry.842002701","entry.284653438","entry.155309467","entry.1630217206","entry.2028926723","entry.2024761984","entry.661151237","entry.1178273108","entry.1329495400","entry.1139834709","entry.861050361","entry.1363107039","entry.1248845983","entry.1443573082","entry.1616533018","entry.1215157525","entry.1632204790","entry.1626818057","entry.783133901","entry.1113319548","entry.1912182312","entry.63626121","entry.1439549708","entry.1292592469","entry.881909567","entry.268394484","entry.175889029","entry.219129905","entry.1178279973","entry.1193313861","entry.269001236","entry.498042810","entry.1964346856","entry.1230472364","entry.490942525","entry.638722599","entry.523715843","entry.671168823","entry.2035768229","entry.1663006433","entry.312288105","entry.1890441255","entry.1034032106","entry.608746679","entry.1585984491","entry.1712233666","entry.1402477302","entry.249327086","entry.1023571914","entry.1795777164","entry.1770767467","entry.1479324078","entry.1112170689","entry.1932108477","entry.820178464","entry.350787996","entry.1409061982","entry.667413866","entry.1487611046","entry.2040376192","entry.1040871654","entry.1861826531","entry.2132736982","entry.871385182","entry.1049104815","entry.431728064","entry.1590663591","entry.1946225607","entry.1574780830","entry.198231677","entry.1159930255","entry.1975336631","entry.1692964721","entry.2143890128","entry.925973439","entry.1931616011","entry.2124937293","entry.1114139210","entry.863128398","entry.707546952","entry.1766919119","entry.2018322132","entry.52513326","entry.858640675","entry.1199244880","entry.1288493091","entry.1393610336","entry.738493828","entry.473216645","entry.45989188","entry.193829703","entry.921152083","entry.692028319","entry.1018916758","entry.234519000","entry.1143670093","entry.1005746394","entry.1943693350","entry.668704061","entry.724720495","entry.1951565246","entry.1167283984","entry.682597900","entry.879788461","entry.1708913631","entry.652439124","entry.1406295844","entry.190529595","entry.2059805969","entry.1658603072","entry.1520181620","entry.7386447","entry.26076756","entry.2114767445","entry.1823182001","entry.850868066","entry.1901665168","entry.1697756291","entry.1963042950","entry.909711823","entry.1449930848","entry.1527769768","entry.688371065","entry.298988769","entry.830912850","entry.530693406","entry.860295148","entry.1495030444","entry.1123811225","entry.1373176950","entry.123288071","entry.724891871","entry.892197776","entry.205387242","entry.693108893","entry.1918189599","entry.999938520","entry.2130008863","entry.150105084","entry.700995234","entry.1981750551","entry.1049208918","entry.864017416","entry.2125446824","entry.18139483","entry.624310178","entry.1628290583","entry.1335338178","entry.2028107917","entry.1740575523","entry.2037492634","entry.1612810593","entry.301963123","entry.39644151","entry.175358090","entry.849024451","entry.207447425","entry.169608679","entry.173216614","entry.492838079","entry.436746779","entry.628256499","entry.432592843","entry.741206404","entry.1718454535","entry.1220394426","entry.1005362392","entry.219770821","entry.1924154443","entry.1294786518","entry.856744231","entry.22946595","entry.551510588","entry.228782302","entry.627863738","entry.1710424788","entry.2019800477","entry.1830246119","entry.661345846","entry.207288098","entry.1108544641","entry.1399526167","entry.1201478875","entry.1053231874","entry.970451269","entry.591870739","entry.493350169","entry.1204826234","entry.742915224","entry.574111814","entry.134518324","entry.1305189404","entry.1343014516","entry.840913051","entry.1836465148","entry.215031337","entry.1718293256","entry.58152714","entry.1673723508","entry.1638424792","entry.269872164","entry.386407090","entry.2089528528","entry.891188137","entry.810174557","entry.1823357824","entry.1094158169","entry.798680036","entry.494617990","entry.227182486","entry.879941624","entry.1772489561","entry.86539778","entry.1860853812","entry.111239946","entry.709073174","entry.1819740215","entry.1961167804","entry.80842377","entry.1587375263","entry.1024229239","entry.2108942993","entry.1986760620","entry.1859066258","entry.666315091","entry.64169819","entry.1627287267","entry.3183685","entry.1364408679","entry.671919623","entry.221593198","entry.775937613","entry.485068460","entry.556643711","entry.983891918","entry.573529892","entry.1825441849","entry.333755488","entry.324752715","entry.891780518","entry.1966089024","entry.1765708170","entry.1411544531","entry.1857636600","entry.452534403","entry.1341923408","entry.29053707","entry.678495468","entry.116353755","entry.928882619","entry.1981204197","entry.483223132","entry.1903255055","entry.2038639014","entry.1263105767","entry.288556374","entry.662336667","entry.401616238","entry.850733817","entry.1084684316","entry.1730699912","entry.835069292","entry.170024417","entry.1369225654","entry.2062914969","entry.1177731949","entry.1653990885","entry.1032390956","entry.1935328693","entry.984311859","entry.129768363","entry.995220679","entry.1661282944","entry.120038658","entry.1986476869","entry.1970950147","entry.1271859807","entry.363707897","entry.950083611","entry.1067329322","entry.1248503470","entry.265477592","entry.1321942044","entry.2047496503","entry.316618822","entry.811908953","entry.608718462","entry.1224087367","entry.1583137170","entry.1254516156","entry.243586825","entry.1438961647","entry.737227053","entry.1956432739","entry.798079666","entry.83035810","entry.1717104473","entry.1480619059","entry.1939729890","entry.266396299","entry.1996690541","entry.571150899","entry.1513110063","entry.1562634277","entry.1052248417","entry.250282914","entry.1103799768","entry.539811530","entry.1753000301","entry.465675106","entry.322908781","entry.340622628","entry.683677146","entry.331697978","entry.39875966","entry.768054433","entry.109514446","entry.74990949","entry.1623452669","entry.1292713961","entry.1104675523","entry.1002471127","entry.1741151431","entry.1741323370","entry.1781361339","entry.1173108785","entry.1833278363","entry.1857091987","entry.1969643442","entry.559164012","entry.858299723","entry.2019442093","entry.1562365174","entry.1719477608","entry.384267838","entry.1844589316","entry.101042868","entry.1625063368","entry.1199107435","entry.754884522","entry.1998024600","entry.27088701","entry.1037803176","entry.485497029","entry.980717862","entry.1740639835","entry.464978284","entry.1070474601","entry.311946643","entry.436777101","entry.1547379977","entry.1702577301","entry.365177029","entry.1515467289","entry.1457256941","entry.367476037"};
	
	public List<String> MyList = new List<String>();
	public IEnumerator googleCoroutine;
	public IEnumerator dataStringCoroutine;
	private string prolificIdString1;
	private string prolificIdString2;
	public GameObject prolificID;
	public GameObject CanvasObject;
	public GameObject CanvasBKG;
	public GameObject myButton;
	// public Button myButton;
	public int InstructionPick;
	public GameObject InstructionGeneral1;
	public GameObject InstructionGeneral2;
	public GameObject Error;
	public GameObject Instruction1;
	public GameObject Instruction2;
	public GameObject Thank;
	public GameObject CorrectScreen;
	public GameObject WrongScreen;
	public GameObject MissedScreen;
	public GameObject Feedback10ScreenGood;
	public GameObject Feedback10ScreenBad;
	public GameObject Feedback20ScreenGood;
	public GameObject Feedback20ScreenBad;
	//public GameObject ExpManager;
	public int trialCounter;
	public float[,] responses;
	private string tempStr;
	
	public float referenceTime;
	public float referenceTime1;
	// =============================================================================================================================
	// here we introduce variables needed for changing the group density. We make three cocentric circles and consider five equidistance 
	// radiuses on them. Then, we add a random number (it can be negative) to these values to make sure that everything is random.
    // Agents will be positioned on the intersections of these circles and radiuses ................................................
	public List<float> shuffledAnglesArray = new List<float>();
	public List<float> shuffledRadiusArray = new List<float>();
	public float shuffledAnglesArrayHuge;
	public float shuffledRadiusArrayHuge;
	public List<float> xPos = new List<float>();
	public List<float> zPos = new List<float>();
	float R;
	float Rmax;
	float Rmin;
	// =============================================================================================================================
    public GameObject[] squares;							// This is the list of game objects that the CubeClrUpdate() method will iterate through
	public Material Clr0;									// Initial color of the screen
    public Material Clr1;									// this is one of the two material that the squares (or any object) in the greed can have
    public Material Clr2;									// same as Color1
    public float x_Start, y_Start, z_Start; 				// this three floats are used to control the position of the grid
    public int columnLength; 								// this is the length (how many cells) are in a column of the grid
    public int rowLength; 									// this is the length (how many rows) are in a column of the grid
    public float x_Space, y_Space; 							// the distance between a the starting point of a square and the next one (should be the same as the size of the object that will be dropped and dragged in the "smallSquare" field, in the inspector)
    public GameObject smallSquare; 							// this line create a public field in the GUI in which the object that is cloned in every cell should be placed
    public MeshRenderer meshRenderer; 						// this line create a public field in which the object that is cloned in every cell should be placed (as above), but this one controls only the mesh renderer of the object
    
    public  Material RndClrMaterial; 						// this is not to be filled with anything in the GUI, is used in this script, and it is public because I will refer to it in the animater

    public int gridSize;
    public float randomThreshold;							// a number between 0 and 1, indicating the percentage of blue and yellow in the stimulus
	public float correctnessCriterion;						// a number indicating the percentage of correct trials (practice and catch: 90%; main: there is no correct answer)
	public List<int> numberList = new List<int>();			// numberList and shuffledList are used to make the stimulus
	public List<int> shuffledList = new List<int>();
	public int rndIndex;									// the indices for shuffling the pixels in the stimulus
	public int range;
	public int ac;
	public int catchTrial;									// a number indicating catch trials. In current setup, only 20 percent of trials are catch
	public int catchInd;									// an index indicating catch trials. It is one, when the trial is a catch trial
	public int SessionInd;								    // this number is one in practice session, and 2 in test session
    public bool S = false;									// internal parameter for making the stimulus
	
	public int densitySelect;								// 1:high-density; 2:low-density
	public float Rp, Rt1, Rt2;								// radius of the group in the practice session and test sessions
	public float DC;
	public float DominColor;
	public float DominantColor;
	public float raisedColor;
	
	// public GameObject beepObject;
	// public AudioSource audioSource;
	// public AudioClip beeep;
	
	public int numberOfAgents;								// number of agents responding in each trial
	public List<int> respondingAgents = new List<int>();	// indices of responding agents
	public List<int> OriginalArray = new List<int>();		// OriginalArray and shuffledArray help for shuffling the agents
	public List<int> shuffledArray = new List<int>();
	public List<float> distance = new List<float>();
	public List<float> distanceSorted = new List<float>();
	public List<float> distanceBackup = new List<float>();
	
	public int randomIndex;
	
	public GameObject fixationSign;							// fixation cross

	
	public IEnumerator C1;									// coroutine for temporal orgnaizing the change of the stimulus (currently, each trial is 15 seconds)
	public IEnumerator C2;									// coroutine for changing the stimulus
	
	
	// entroducing the parameters that control the experiment
	#region entroducing the parameters that control the experiment
	// Introducing Agents ==================================================================================================================
	public List<GameObject> Agents;
	public GameObject Participant;
	// Introducing Animators ===============================================================================================================
	public Animator fAnimator1, fAnimator2, fAnimator3, fAnimator4, fAnimator5;
	public Animator mAnimator1, mAnimator2, mAnimator3, mAnimator4;
	public Animator pAnimator;
	public IEnumerator raiseHandCoroutine;
	public IEnumerator raiseBalloonCoroutine;
	public int numberOfPracticeTrials;
	public int numberOfTestTrials;
	public int NumberOfBlocks;
	public int numberOfRounds;		// indicating how many times the whole setup will repeat. For example if we have a high-density, then low-density, then again high-density and low-density, it is "2"
	public float refTime;
	public float timePass;
	public float trialDuration;
	public float newTrialDuration;
	public float fixationDuration;	// the duration that the fixation cross would be shown -------------------------------------------------
	public float agentsRHTime;		// the time point that the agents are supposed to raise their hand in each trial -----------------------
	public float agentsHUDuration;	// the duration that agents keep their hands up --------------------------------------------------------
	// RightLeftF is the parameter that if a female avatar is supposed to raise her hand, it indicates the suitable animation. right: (1~6) 
	// left: (7~9) -------------------------------------------------------------------------------------------------------------------------
	public int RightLeftF1, RightLeftF2, RightLeftF3, RightLeftF4, RightLeftF5, RightLeftF6, RightLeftF7, RightLeftF8;
	// RightLeftM is the parameter that if a male avatar is supposed to raise his hand, it indicates the suitable animation. right: (1~6) --
	// left: (7~13) ------------------------------------------------------------------------------------------------------------------------
	public int RightLeftM1, RightLeftM2, RightLeftM3, RightLeftM4, RightLeftM5, RightLeftM6, RightLeftM7, RightLeftM8;	
	public int RightLeftP;
	public float LR;
	public int congruencyFactor;
	public int correctCount;
	public float percentCorrect;
	
	public Material yellowMaterial;
	public Material blueMaterial;
	
	
	private Vector3[] myPos;	
																										   			   // position of one avatar 
	private float thetaPos;
	private float RPos;
    private int[] posList;					                										 // list of positions of all avatars (elements of this list come from myPos)
	private int[] randomList;
	public GameObject[] avatarPrefabs;
	public int stimSize;	
	public float gridSpacing;																								 // the common distance between each pair of avatars
	private Animator[] Animators;											   							  			   // animations of the avatars that we are going to control
	private GameObject[] myAvatars;
	private int avatarCounter = 0;	
	public Material[] clothingMaterialTemplates;
	public int Rem;
	// private int cnt1;
	// private int cnt2;
	
	#endregion
	// =====================================================================================================================================
	
    void Start()
	// private IEnumerator Start()
    {	
		// stimSize=10;	
		// InstructionPick=Random.Range(1,3);
		InstructionPick=2;
		if (InstructionPick==1)
		{
			InstructionGeneral1.SetActive(true);
		}
		else
		{
			InstructionGeneral2.SetActive(true);
		}
		// Initializing parameters ---------------------------------------------------------------------------------------------------------
		trialDuration=5f;									// the duration of each trial
		newTrialDuration=5f;
		agentsRHTime=0.1f;									// the time between the onset of each trial and agents' responses
		agentsHUDuration=2f;								// the time that agents keep their hand raised
		NumberOfBlocks=2;									// number of blocks of the experiment (one practice and one test)
		fixationDuration=1f;
		numberOfRounds=2;
		// Starting the stimulus ===========================================================================================================
        GenerationCube();
		gridSize=columnLength * rowLength;
		
		numberOfPracticeTrials=2;		//10
		numberOfTestTrials=2;			//75
		// =================================================================================================================================
		// Starting to control the experiment ==============================================================================================
		// Initiating  animators -----------------------------------------------------------------------------------------------------------
		// Female animators ----------------------------------------------------------------------------------------------------------------
		fAnimator1 = Agents[0].GetComponent<Animator>();
		fAnimator2 = Agents[1].GetComponent<Animator>();
		fAnimator3 = Agents[2].GetComponent<Animator>();
		fAnimator4 = Agents[3].GetComponent<Animator>();
		fAnimator5 = Agents[4].GetComponent<Animator>();
        // Male animators ------------------------------------------------------------------------------------------------------------------
		mAnimator1 = Agents[8].GetComponent<Animator>();
		mAnimator2 = Agents[9].GetComponent<Animator>();
		mAnimator3 = Agents[10].GetComponent<Animator>();
		mAnimator4 = Agents[11].GetComponent<Animator>();
		pAnimator = Participant.GetComponent<Animator>();
		// yield return null;	

		
        
		// RightLeft = new int[stimSize * stimSize];

        // Step 1: Generate Positions
        // StartCoroutine(GeneratePositions());

        // Step 2: Instantiate Avatars
	}
    // Update is called once per frame
    void Update()
    {
    }
	
	
	
	
	private IEnumerator GeneratePositions()						   			    // in this coroutine, we generate an array of positions that each avatar will be located (myPos)
    {
        // int counter = 0;
		myPos = new Vector3[6 * 10];
		
		
		List<float> numbers = new List<float>();
		
		List<float> Numbers = new List<float>();
		// cnt1=0;
		// cnt2=0;
		// for (int j1 = 1; j1 <= 6; j1++) // Loop from 1 to 6
        // {
            // for (int j2 = 0; j2 < 10; j2++) // Add each number 10 times
            // {
                // numbers.Add(j1*Mathf.Pow(-1,j1));
				// // cnt1++;
            // }
        // }
		int ct=0;
		for (int i1 = 1; i1 <= 10; i1++) 
		{
			for (int j1 = 1; j1 <= 3; j1++) 
			{
				xPos.Add((i1*0.7f+4.5f+Random.Range(-1.5f,1.5f))*Mathf.Sin(((2*j1-1)*(10f+Random.Range(-2f,2f)))*(Mathf.PI)/180f));
				zPos.Add(-(i1*0.7f+4.5f+Random.Range(-1.5f,1.5f))*Mathf.Cos(((2*j1-1)*(10f+Random.Range(-2f,2f)))*(Mathf.PI)/180f));
				ct++;
				xPos.Add(-(i1*0.7f+4.5f+Random.Range(-1.5f,1.5f))*Mathf.Sin(((2*j1-1)*(10f+Random.Range(-2f,2f)))*(Mathf.PI)/180f));
				zPos.Add(-(i1*0.7f+4.5f+Random.Range(-1.5f,1.5f))*Mathf.Cos(((2*j1-1)*(10f+Random.Range(-2f,2f)))*(Mathf.PI)/180f));
				ct++;
			}
		}
		Shuffle(xPos);
		Shuffle(zPos);
        

		
		for (int counter = 0; counter < 60; counter++)
        {
			myPos[counter] = new Vector3(xPos[counter], -0.24f, zPos[counter]);
            yield return null; // Yield each iteration
        }
		StartCoroutine(InstantiateAvatars());
    }
	
	void Shuffle(List<float> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            float temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
	
    private IEnumerator InstantiateAvatars()
    {
		posList = new int[6 * 10];
		randomList = new int[6 * 10];
		Animators = new Animator[6 * 10];
		myAvatars = new GameObject[6 * 10];
		
		int posCounter = 0;
        for (int i3 = 0; i3 < 60; i3++)			// in this loop, I make a list of numbers between 0 and expected total number of avatars
        {
            posList[i3] = i3;
			randomList[i3] = i3;
			
			Vector3 position = myPos[i3];
				
            // posList[posIndex] = posList[stimSize * stimSize - posCounter];
			// randomList[posIndex] = randomList[stimSize * stimSize - posCounter];
				
			if(position[1]!=0)
			{
				GameObject newAvatar = Instantiate(avatarPrefabs[(i3 % 9)], myPos[i3], Quaternion.identity);
				newAvatar.transform.Rotate(0f, 180.0f, 0.0f, Space.World);
				newAvatar.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
				Animator newAnimator = newAvatar.GetComponent<Animator>();
				Animators[i3]=newAnimator;
				myAvatars[i3]=newAvatar;
				Animators[i3].SetInteger("LR", 0);
				avatarCounter++;
			}
            yield return null; // Yield each iteration
        }

		// Step 3: Deactivate original avatars
        DeactivateOriginalAvatars();
		// Int his loop, we assign a name for each animator, and initiate the animators. "LR" is the parameter that when is not zero starts the animation in the idle mode!
		for (int j = 0; j< 60;j++)
		{
			Animators[j].gameObject.name="Animator"+(j+1);
			// Animators[j].SetInteger("LR", RightLeft[j]);
		}
		// yield return StartCoroutine(ControlAvatars(myAvatars));		                               // "StartCoroutine" is a coroutine that controls the timing of the actions of avatars
		C1=ExperimentStructure();
		StartCoroutine(C1);
		yield return null;	
		
    }

	private void DeactivateOriginalAvatars()
    {
        for (int i = 0; i < avatarPrefabs.Length; i++)
        {
            avatarPrefabs[i].SetActive(false);
        }
    }
	
	private Color GenerateNonYellowBlue()
    {
		// hue: 0-60:red; 61-120:yellow; 121-180:green; 181-240:cyan; 241-300: blue; 301-360:magenta
        float hue, sat, val;
		hue=2;
		while((hue>0.08f && hue<0.18f) || (hue>0.2f && hue<0.5f) || (hue>0.64f) )
		{ 
			hue = Random.Range(0f, 1f);
		}
        sat = Random.Range(0.2f, 1f);		// how strong is the color
        val = Random.Range(0.3f, 0.7f);		// how bright is the color
        
        return Color.HSVToRGB(hue, sat, val);
    }
	
	
	
	
	
	
	
	
	// =========================================================================================================================================
	// Stimulus functions ======================================================================================================================
	#region stimulus functions 
    void GenerationCube()
	{
		for (int i = 0; i < columnLength * rowLength; i++)
        {
			smallSquare.GetComponent<MeshRenderer>().material = Clr0;
            Instantiate(smallSquare, new Vector3(x_Start + x_Space * (i%rowLength), y_Start + (-y_Space * (i/columnLength)),z_Start), Quaternion.identity);
        }
		smallSquare.SetActive(false);
	}

    void CubeClrUpdate(List<int> myShuffledList1, float DC, int blockIndex)
    {
		catchInd=0;
		catchTrial=Random.Range(1,6);	// choose a random number between 1 and 5. Then, if this number is 5, it is catch trial, meaning that 20% of the trials are catch trial.
		if (catchTrial==5 & blockIndex!=1)
		{
			catchInd=1;					// when catchInd==1, that trial is a catch trial
		}
		if(catchTrial==5 | blockIndex==1)			//blockIndex=1: practice session; 
		{
			randomThreshold=0.6f;
		}
		else
		{
			randomThreshold=0.5f;
		}
		print(catchInd+"   ,   "+randomThreshold);
		if(DC==1)	// choose the dominant color (completely random 50-50)
		{
			randomThreshold=1-randomThreshold;
		}
		
        void SingleCubeRandom(int ACC, List<int> myShuffledList2)
        {
			int ClrChances = myShuffledList2[ACC];
			// int ClrChances = Random.Range(1, columnLength * rowLength + 1);
            if (ClrChances <= randomThreshold * columnLength * rowLength)
            {
                RndClrMaterial = Clr2;
            }
            else
            {
                RndClrMaterial = Clr1;
            }
        }
        
        if (squares == null)
        {
            squares = GameObject.FindGameObjectsWithTag("Squares");
        }
        else
        {
            squares = GameObject.FindGameObjectsWithTag("Squares");
        }

		ac=0;
		foreach (var element in squares)
        {
            SingleCubeRandom(ac,myShuffledList1);
            element.GetComponent<MeshRenderer>().material = RndClrMaterial; //here the value should be RndClrMaterial -  if it is Clr2 or Clr1 that is because the script is being tested with one of the two possible Clr value
			ac++;
        }
        if (S == false)
        {
            S = true;
        }
        else
        {
            S = false;
        }
    }
	#endregion

	// =========================================================================================================================================
	// Experiment Structure coroutine ==========================================================================================================
	#region Experiment Structure coroutine
	IEnumerator ExperimentStructure()
    {	
		responses = new float[400,10];		// The array that we are going to store the parameters of the experiment and participants' responses in it
		
		
		
		trialCounter=0;
		catchInd=0;
		correctCount=0;
		
		for(int ip = 0; ip < numberOfPracticeTrials/2; ip++)		// practice session
		{
			raisedColor=0;
			referenceTime1=Time.time;
			SessionInd=1;						// SessionInd indicates the practice trials (1) and test trials (2)
			
			
			// fixationSign.SetActive(true);		// fixation cross is on for "fixationDuration" seconds
			// yield return new WaitForSeconds(fixationDuration);
			// fixationSign.SetActive(false);

			DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
			C2=StimulusChange(gridSize, DominantColor, SessionInd);
			StartCoroutine(C2);
			
			raiseHandCoroutine = RaiseHand(DominantColor);
			StartCoroutine(raiseHandCoroutine);
			
			while (!(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) && (Time.time - referenceTime1) < trialDuration)
			{
				yield return new WaitForSeconds(Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				responses[trialCounter, 5] = 1;
				Input.ResetInputAxes();
			}
			else if(Input.GetKey(KeyCode.LeftArrow))
			{
				responses[trialCounter, 5] = 2;
				Input.ResetInputAxes();
			}
			else
			{
				responses[trialCounter, 5] = 0;
			}
			print("position!!!!!!!!!!!!!!!!!!!!!"+trialCounter);
			responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
			responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
			responses[trialCounter,2]=R; 			// radius of the circle that agents are standing in it (lower R, higher density)
			responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
			responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
			responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
			responses[trialCounter,7]=DominantColor;
			
			raisedColor=Mathf.Abs(responses[trialCounter,5]-InstructionPick);		// if 0: yellow raised; if 1: blue raised
			
			
			// DominantColor		// if 2: yellow; if 1: blue
			
			CanvasObject.GetComponent<Canvas>().enabled = true;
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
			
			// for(int a = 0; a < 9; a++)
			// {
				// Agents[a].SetActive(false);
			// }
			if((responses[trialCounter, 5]!=0 & raisedColor==0 & DominantColor==1) | (responses[trialCounter, 5]!=0 & raisedColor==1 & DominantColor==2))
			{
				CorrectScreen.SetActive(true);
				correctCount=correctCount+1;
			}
			else if(responses[trialCounter, 5]!=0)
			{
				WrongScreen.SetActive(true);
			}
			else
			{
				MissedScreen.SetActive(true);
			}
			print("position!!!!!!!!!!!!!!!!!!!!!"+trialCounter);
			trialCounter=trialCounter+1;
			// print("Responses:  "+responses[trialCounter,0]+ "  ,  "+responses[trialCounter,1]+"  ,  "+responses[trialCounter,2]+"  ,  "+responses[trialCounter,3]+"  ,  "+responses[trialCounter,4]+"  ,  "+responses[trialCounter,5]+"  ,  "+responses[trialCounter,6]+"  ,  "+responses[trialCounter,7]);
			percentCorrect=correctCount/(trialCounter+0f);
			// print("Responses:  "+responses[trialCounter,0]+ "  ,  "+responses[trialCounter,1]+"  ,  "+responses[trialCounter,2]+"  ,  "+responses[trialCounter,3]+"  ,  "+responses[trialCounter,4]+"  ,  "+responses[trialCounter,5]+"  ,  "+responses[trialCounter,6]+"  ,  "+responses[trialCounter,7]);
			// print("correctCount: "+percentCorrect);
			StopCoroutine(C2);
			dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
			StartCoroutine(dataStringCoroutine);
			
			yield return new WaitForSeconds(fixationDuration);
			yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
			StopCoroutine(raiseHandCoroutine);
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
			CorrectScreen.SetActive(false);
			WrongScreen.SetActive(false);
			MissedScreen.SetActive(false);
			CanvasObject.GetComponent<Canvas>().enabled = false;
			
			// for(int a = 0; a < 9; a++)
			// {
				// Agents[a].SetActive(true);
			// }
		}
		
		// ========================================================
		// for(int a = 0; a < 9; a++)
		// {
			// Agents[a].SetActive(false);
		// }
		// for(int a = 7; a < 12; a++)
		// {
			// Agents[a].SetActive(false);
		// }
		
		CanvasObject.GetComponent<Canvas>().enabled = true;
		CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
		if (percentCorrect>=0.75){
			Feedback10ScreenGood.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback10ScreenGood.SetActive(false);
		}		
		else if(percentCorrect<0.75){
			Feedback10ScreenBad.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback10ScreenBad.SetActive(false);
		}
		CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
		Feedback10ScreenGood.SetActive(false);
		Feedback10ScreenBad.SetActive(false);
		CanvasObject.GetComponent<Canvas>().enabled = false;	
		
		// for(int a = 0; a < 9; a++)
		// {
			// Agents[a].SetActive(true);
		// }		
		// ========================================================
		correctCount=0;	
		for(int ip = numberOfPracticeTrials/2; ip < numberOfPracticeTrials; ip++)		// practice session
		{
			raisedColor=0;
			referenceTime1=Time.time;
			SessionInd=1;						// SessionInd indicates the practice trials (1) and test trials (2)
			trialCounter=trialCounter+1;
			
			// fixationSign.SetActive(true);		// fixation cross is on for "fixationDuration" seconds
			// yield return new WaitForSeconds(fixationDuration);
			// fixationSign.SetActive(false);

			DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
			C2=StimulusChange(gridSize, DominantColor, SessionInd);
			StartCoroutine(C2);
			
			raiseHandCoroutine = RaiseHand(DominantColor);
			StartCoroutine(raiseHandCoroutine);
			// print("DominantColor"+DominantColor);
			
			while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (Time.time-referenceTime1)<trialDuration)
			{
				yield return new WaitForSeconds(Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				responses[trialCounter, 5] = 1;
				Input.ResetInputAxes();
			}
			else if(Input.GetKey(KeyCode.LeftArrow))
			{
				responses[trialCounter, 5] = 2;
				Input.ResetInputAxes();
			}
			else
			{
				responses[trialCounter, 5] = 0;
			}
			
			responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
			responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
			responses[trialCounter,2]=R; 			// radius of the circle that agents are standing in it (lower R, higher density)
			responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
			responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
			responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
			responses[trialCounter,7]=DominantColor;
			
			
			raisedColor=Mathf.Abs(responses[trialCounter,5]-InstructionPick);		// if 0: yellow raised; if 1: blue raised
			
			
			// DominantColor		// if 2: yellow; if 1: blue
			
			CanvasObject.GetComponent<Canvas>().enabled = true;
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
			
			// for(int a = 0; a < 15; a++)
			// {
				// Agents[a].SetActive(false);
			// }
			if((responses[trialCounter, 5]!=0 & raisedColor==0 & DominantColor==1) | (responses[trialCounter, 5]!=0 & raisedColor==1 & DominantColor==2))
			{
				CorrectScreen.SetActive(true);
				correctCount=correctCount+1;
			}
			else if(responses[trialCounter, 5]!=0)
			{
				WrongScreen.SetActive(true);
			}
			else
			{
				MissedScreen.SetActive(true);
			}
			
			// print("Responses:  "+responses[trialCounter,0]+ "  ,  "+responses[trialCounter,1]+"  ,  "+responses[trialCounter,2]+"  ,  "+responses[trialCounter,3]+"  ,  "+responses[trialCounter,4]+"  ,  "+responses[trialCounter,5]+"  ,  "+responses[trialCounter,6]+"  ,  "+responses[trialCounter,7]);
			percentCorrect=correctCount/(trialCounter-10f);
			// print("Responses:  "+responses[trialCounter,0]+ "  ,  "+responses[trialCounter,1]+"  ,  "+responses[trialCounter,2]+"  ,  "+responses[trialCounter,3]+"  ,  "+responses[trialCounter,4]+"  ,  "+responses[trialCounter,5]+"  ,  "+responses[trialCounter,6]+"  ,  "+responses[trialCounter,7]);
			// print("correctCount: "+percentCorrect);
			StopCoroutine(C2);
			dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
			StartCoroutine(dataStringCoroutine);
			
			yield return new WaitForSeconds(fixationDuration);
			yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
			StopCoroutine(raiseHandCoroutine);
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
			CorrectScreen.SetActive(false);
			WrongScreen.SetActive(false);
			MissedScreen.SetActive(false);
			CanvasObject.GetComponent<Canvas>().enabled = false;

			// for(int a = 0; a < 15; a++)
			// {
				// Agents[a].SetActive(true);
			// }
		}
		
		// ========================================================
		// for(int a = 0; a < 15; a++)
		// {
			// Agents[a].SetActive(false);
		// }
		CanvasObject.GetComponent<Canvas>().enabled = true;
		CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
		if (percentCorrect>=0.75){
			Feedback20ScreenGood.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback20ScreenGood.SetActive(false);
		}		
		else if(percentCorrect<0.75){
			Feedback20ScreenBad.SetActive(true);
			yield return new WaitForSeconds(5f);
			Feedback20ScreenBad.SetActive(false);
		}
		CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
		Feedback20ScreenGood.SetActive(false);
		Feedback20ScreenBad.SetActive(false);
		CanvasObject.GetComponent<Canvas>().enabled = false;	
		
		// for(int a = 0; a < 15; a++)
		// {
			// Agents[a].SetActive(true);
		// }	
		// ========================================================
		// after practice session and right before main session		
		// for(int a = 0; a < 15; a++)
		// {
			// Agents[a].SetActive(false);
		// }
		// CanvasObject.GetComponent<Canvas>().enabled = true;
		// CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
		// Instruction1.SetActive(true);
		// yield return new WaitForSeconds(10f);
		// CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
		// Instruction1.SetActive(false);
		// CanvasObject.GetComponent<Canvas>().enabled = false;
		// for(int a = 0; a < 15; a++)
		// {
			// Agents[a].SetActive(true);
		// }
		// .....................................................
		densitySelect=Random.Range(1,3);	// 1: high-density; 2: low-density
		if (densitySelect==1)
		{
			Rt1=Rmin;
			Rt2=Rmax;
		}
		else
		{
			Rt1=Rmax;
			Rt2=Rmin;
		}
		// Modifying the density of the group ==================================================================================================
		// shuffledAnglesArray=new List<float>{-56f,-32f,-8f,16f,40f,-48f,-24f,0f,24f,48f,-40f,-16f,8f,32f,56f};
		shuffledAnglesArray=new List<float>{-56f,56f,-32f,32f,-8f,8f,-48f,48f,-24f,24f,0f,-40f,40f,-16f,16f};
		// for(int a = 0; a < 15; a++)
		// {
			// shuffledAnglesArray[a]=shuffledAnglesArray[a]+Random.Range(-2f,2f);
		// }
		R=Rt1;	 // radius of the group in first test session
		shuffledRadiusArray=new List<float>{R/3,R/3,R/3,R/3,R/3,2*R/3,2*R/3,2*R/3,2*R/3,2*R/3,R,R,R,R,R};
		// for(int a = 0; a < 15; a++)
		// {
			// shuffledRadiusArray[a]=shuffledRadiusArray[a]+Random.Range(-1f,1f)*0.3f*R/3;
		// }
		
		xPos=new List<float>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
		zPos=new List<float>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
		// for(int b = 0; b < 15; b++)
		// {
			// xPos[b]=shuffledRadiusArray[b]*Mathf.Sin(shuffledAnglesArray[b]*(Mathf.PI)/180f);
			// zPos[b]=-shuffledRadiusArray[b]*Mathf.Cos(shuffledAnglesArray[b]*(Mathf.PI)/180f);
			// Agents[b].transform.position=new Vector3(xPos[b], -0.24f, zPos[b]);
		// } 
		// ======================================================================================================================================

		
		
		
		
		
		for(int rund = 0; rund < numberOfRounds; rund++)
		{
			// Modifying the density of the group ==================================================================================================
			// shuffledAnglesArray=new List<float>{-56f,-32f,-8f,16f,40f,-48f,-24f,0f,24f,48f,-40f,-16f,8f,32f,56f};
			shuffledAnglesArray=new List<float>{-56f,56f,-32f,32f,-8f,8f,-48f,48f,-24f,24f,0f,-40f,40f,-16f,16f};
			// for(int a = 0; a < 15; a++)
			// {
				// shuffledAnglesArray[a]=shuffledAnglesArray[a]+Random.Range(-2f,2f);
			// }
			// R=Rt1;	 // radius of the group in second test session
			// shuffledRadiusArray=new List<float>{R/3,R/3,R/3,R/3,R/3,2*R/3,2*R/3,2*R/3,2*R/3,2*R/3,R,R,R,R,R};
			// for(int a = 0; a < 15; a++)
			// {
				// shuffledRadiusArray[a]=shuffledRadiusArray[a]+Random.Range(-1f,1f)*0.3f*R/3;
			// }
			
			// xPos=new List<float>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
			// zPos=new List<float>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
			// for(int b = 0; b < 15; b++)
			// {
				// xPos[b]=shuffledRadiusArray[b]*Mathf.Sin(shuffledAnglesArray[b]*(Mathf.PI)/180f);
				// zPos[b]=-shuffledRadiusArray[b]*Mathf.Cos(shuffledAnglesArray[b]*(Mathf.PI)/180f);
				// Agents[b].transform.position=new Vector3(xPos[b], -0.24f, zPos[b]);
			// } 
			for(int it1 = 0; it1 < numberOfTestTrials; it1++)		// practice session
			{
				referenceTime1=Time.time;
				SessionInd=2;						// SessionInd indicates the practice trials (1) and test trials (2)
				trialCounter=trialCounter+1;
				
				fixationSign.SetActive(true);		// fixation cross is on for "fixationDuration" seconds
				yield return new WaitForSeconds(fixationDuration);
				fixationSign.SetActive(false);

				DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
				C2=StimulusChange(gridSize, DominantColor, SessionInd);
				StartCoroutine(C2);
				
				raiseHandCoroutine = RaiseHand(DominantColor);
				StartCoroutine(raiseHandCoroutine);
				
				while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (Time.time-referenceTime1)<trialDuration)
				{
					yield return new WaitForSeconds(Time.deltaTime);
				}
				if(Input.GetKey(KeyCode.RightArrow))
				{
					responses[trialCounter, 5] = 1;
					Input.ResetInputAxes();
				}
				else if(Input.GetKey(KeyCode.LeftArrow))
				{
					responses[trialCounter, 5] = 2;
					Input.ResetInputAxes();
				}
				else
				{
					responses[trialCounter, 5] = 0;
				}
				responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
				responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
				responses[trialCounter,2]=R; 			// radius of the circle that agents are standing in it (lower R, higher density)
				responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
				responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
				responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
				responses[trialCounter,7]=DominantColor;
				// print("Responses:  "+responses[trialCounter,0]+ "  ,  "+responses[trialCounter,1]+"  ,  "+responses[trialCounter,2]+"  ,  "+responses[trialCounter,3]+"  ,  "+responses[trialCounter,4]+"  ,  "+responses[trialCounter,5]+"  ,  "+responses[trialCounter,6]+"  ,  "+responses[trialCounter,7]);
				StopCoroutine(C2);
				dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
				StartCoroutine(dataStringCoroutine);
				yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
				StopCoroutine(raiseHandCoroutine);
			}
			
			// after block1
			// for(int a = 0; a < 15; a++)
			// {
				// Agents[a].SetActive(false);
			// }
			CanvasObject.GetComponent<Canvas>().enabled = true;
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
			Instruction2.SetActive(true);
			yield return new WaitForSeconds(2f);
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
			Instruction2.SetActive(false);
			CanvasObject.GetComponent<Canvas>().enabled = false;
			// for(int a = 0; a < 15; a++)
			// {
				// Agents[a].SetActive(true);
			// }
			// ............................................
			
			
			
			// Modifying the density of the group ==================================================================================================
			// shuffledAnglesArray=new List<float>{-56f,-32f,-8f,16f,40f,-48f,-24f,0f,24f,48f,-40f,-16f,8f,32f,56f};
			// for(int a = 0; a < 15; a++)
			// {
				// shuffledAnglesArray[a]=shuffledAnglesArray[a]+Random.Range(-2f,2f);
			// }
			// R=Rt2;	 // radius of the group in second test session
			// shuffledRadiusArray=new List<float>{R/3,R/3,R/3,R/3,R/3,2*R/3,2*R/3,2*R/3,2*R/3,2*R/3,R,R,R,R,R};
			// for(int a = 0; a < 15; a++)
			// {
				// shuffledRadiusArray[a]=shuffledRadiusArray[a]+Random.Range(-1f,1f)*0.3f*R/3;
			// }
			
			// xPos=new List<float>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
			// zPos=new List<float>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
			// for(int b = 0; b < 15; b++)
			// {
				// xPos[b]=shuffledRadiusArray[b]*Mathf.Sin(shuffledAnglesArray[b]*(Mathf.PI)/180f)-.5f;
				// zPos[b]=-shuffledRadiusArray[b]*Mathf.Cos(shuffledAnglesArray[b]*(Mathf.PI)/180f);
				// Agents[b].transform.position=new Vector3(xPos[b], -0.24f, zPos[b]);
			// } 
			
			
			for(int it2 = 0; it2 < numberOfTestTrials; it2++)		// practice session
			{
				referenceTime1=Time.time;
				SessionInd=3;						// SessionInd indicates the practice trials (1) and test trials (2)
				trialCounter=trialCounter+1;
				
				fixationSign.SetActive(true);		// fixation cross is on for "fixationDuration" seconds
				yield return new WaitForSeconds(fixationDuration);
				fixationSign.SetActive(false);

				DominantColor=Random.Range(1,3);	// DC=1: Orange; DC=2: Green
				C2=StimulusChange(gridSize, DominantColor, SessionInd);
				StartCoroutine(C2);
				
				raiseHandCoroutine = RaiseHand(DominantColor);
				StartCoroutine(raiseHandCoroutine);
				
				while(!(Input.GetKey(KeyCode.RightArrow)|Input.GetKey(KeyCode.LeftArrow))& (Time.time-referenceTime1)<trialDuration)
				{
					yield return new WaitForSeconds(Time.deltaTime);
				}
				if(Input.GetKey(KeyCode.RightArrow))
				{
					responses[trialCounter, 5] = 1;
					Input.ResetInputAxes();
				}
				else if(Input.GetKey(KeyCode.LeftArrow))
				{
					responses[trialCounter, 5] = 2;
					Input.ResetInputAxes();
				}
				else
				{
					responses[trialCounter, 5] = 0;
				}
				responses[trialCounter,0]=SessionInd; 	// if index==1, it is practice session, else, it is test session
				responses[trialCounter,1]=catchInd; 	// it is 1 if it is a catch. Otherwise, it is zero
				responses[trialCounter,2]=R; 			// radius of the circle that agents are standing in it (lower R, higher density)
				responses[trialCounter,3]=numberOfAgents; 			// number of responding agents
				responses[trialCounter,4]=LR; 			// right hand:2; left hand:1
				responses[trialCounter,6]=Time.time-referenceTime1; 			// response time
				responses[trialCounter,7]=DominantColor;
				// print("Responses:  "+responses[trialCounter,0]+ "  ,  "+responses[trialCounter,1]+"  ,  "+responses[trialCounter,2]+"  ,  "+responses[trialCounter,3]+"  ,  "+responses[trialCounter,4]+"  ,  "+responses[trialCounter,5]+"  ,  "+responses[trialCounter,6]+"  ,  "+responses[trialCounter,7]);
				StopCoroutine(C2);
				dataStringCoroutine = DataStringMaker(responses, trialCounter, MyList);
				StartCoroutine(dataStringCoroutine);
				yield return new WaitForSeconds(trialDuration-(Time.time-referenceTime1));
				StopCoroutine(raiseHandCoroutine);
				// after block2
			}
			if (rund==0)
			// if (rund==0 & it2 == numberOfTestTrials-1)
			{
				// for(int a = 0; a < 15; a++)
				// {
					// Agents[a].SetActive(false);
				// }
				CanvasObject.GetComponent<Canvas>().enabled = true;
				CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
				Instruction2.SetActive(true);
				yield return new WaitForSeconds(5f);
				CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
				Instruction2.SetActive(false);
				CanvasObject.GetComponent<Canvas>().enabled = false;
				// for(int a = 0; a < 15; a++)
				// {
					// Agents[a].SetActive(true);
				// }
			}
		}
		
		
		// for(int a = 0; a < 15; a++)
		// {
			// Agents[a].SetActive(false);
		// }
		CanvasObject.GetComponent<Canvas>().enabled = true;
		CanvasBKG.GetComponent<SpriteRenderer>().enabled = true;
		Thank.SetActive(true);
		// JatosInterface.StartNextJatosEvent();
	} 
	
	
	
	
	IEnumerator StimulusChange(int GridSize, float DominColor, int sessionIndex)
    {
		numberList.Clear();
		shuffledList.Clear();

		for(int i = 0; i < gridSize; i++)
		{
			numberList.Add(i);
		}
		range=gridSize-1;
		for(int j=0; j<gridSize; j++)
		{
			rndIndex=Random.Range(0,range);
			shuffledList.Add(numberList[rndIndex]);
			numberList.Remove(numberList[rndIndex]);
			range=range-1;
		}
		
		
		CubeClrUpdate(shuffledList, DominColor, sessionIndex);
		yield return null;
    } 
	#endregion
	// =========================================================================================================================================
	
	// ExperimentControl coroutines ============================================================================================================
	#region experimentControl coroutines

	public IEnumerator RaiseHand(float myDC)
    {
		// print("works");
		// here, we choose the percentage of the times that the group responds correctly.
		correctnessCriterion=Random.Range(1,11);	// make a randm number between 1 and 10, including 1 and 10
		if (correctnessCriterion<10)		// if the random number is less than 10 (not including 10), group respond correctly. In other words, 90% of the time!
		{
			LR=myDC;
		}
		else
		{
			LR=Random.Range(1,3);
		}		
		refTime=Time.time;
		// if in each trial a random number of agents (any number between 1 and 15) respond ================================================
		// =================================================================================================================================
		// OriginalArray=new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
		// shuffledArray=new List<int>{};		// a shuffled array of all the numbers between 1 and 15
		// for (int n=15; n>0;n--)
		// {
			// randomIndex=Random.Range(0,n);		// we have 15 agents. A number of them respond in each trial
			// shuffledArray.Add(OriginalArray[randomIndex]);
			// OriginalArray.RemoveAt(randomIndex);
		// }
		// numberOfAgents=Random.Range(1,16);		// we have 15 agents. A number of them respond in each trial
		// respondingAgents=new List<int>{};
		// for (int n = 0; n < numberOfAgents; n++)
		// {
			// respondingAgents.Add(shuffledArray[n]);		
		// }
		// =================================================================================================================================
		// if in each trial a random number of agents (any number between 1 and 15) respond ================================================
		// =================================================================================================================================
		// OriginalArray=new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
		// shuffledArray=new List<int>{};		// a shuffled array of all the numbers between 1 and 15
		// for (int n=15; n>0;n--)
		// {
			// randomIndex=Random.Range(0,n);		// we have 15 agents. A number of them respond in each trial
			// shuffledArray.Add(OriginalArray[randomIndex]);
			// OriginalArray.RemoveAt(randomIndex);
		// }
		// numberOfAgents=Random.Range(0,3)*5+3;		// either 3, or 8 or 13 agents respond.
		numberOfAgents=Random.Range(1,3)*3+1;		// 1, 4, or 7 agents respond.
		// if (numberOfAgents==4)
		// {
			// for (int Ndis=0; Ndis<14;Ndis++)
			// {
				// distance.Add(Vector3.Distance(Agents[14].transform.position, Agents[Ndis].transform.position));
			// }
			// distanceSorted = distance.OrderBy(n => n).ToList();
			// // for (int mm=0;mm<14;mm++)
				// // print(distance[mm]+ "  ,  "+distanceSorted[mm]);
			
			// // for (int nn=0; nn<3;nn++)
			// // {
				// // print(distance.IndexOf(distanceSorted[nn]));
			// // }
		// }
		// else if (numberOfAgents==7)
		// {
			// for (int Ndis=0; Ndis<14;Ndis++)
			// {
				// distance.Add(Vector3.Distance(Agents[14].transform.position,Agents[Ndis].transform.position));
			// }
			// distanceSorted = distance.OrderBy(n => n).ToList();
			// // for (int mm=0;mm<14;mm++)
				// // print(distance[mm]+ "  ,  "+distanceSorted[mm]);
			
			// // for (int nn=0; nn<6;nn++)
			// // {
				// // print(distance.IndexOf(distanceSorted[nn]));
			// // }
		// }

		// respondingAgents=new List<int>{};
		// for (int n = 0; n < numberOfAgents; n++)
		// {
			// respondingAgents.Add(shuffledArray[n]);	
			// // print("RS: "+shuffledArray[n]);
		// }
		
		// =================================================================================================================================
			if (LR==1)	// Agents are supposed to raise their left hand --------------------------------------------------------------------
			{
				for (int n = 0; n < numberOfAgents; n++)
				{
					
					// Rem=respondingAgents[n] % 15;
					Rem=1;
					switch (Rem)
					{
						case 1:
							RightLeftF1=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF1"+RightLeftF1);
							break;
						case 2:
							RightLeftF2=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF2"+RightLeftF2);
							break;
						case 3:
							RightLeftF3=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF3"+RightLeftF3);
							break;
						case 4:
							RightLeftF4=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF4"+RightLeftF4);
							break;
						case 5:
							RightLeftF5=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF5"+RightLeftF5);
							break;
						case 6:
							RightLeftF6=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF6"+RightLeftF6);
							break;
						case 7:
							RightLeftF7=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF7"+RightLeftF7);
							break;
						case 8:
							RightLeftF8=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for females raising left hand)
							print("RightLeftF8"+RightLeftF8);
							break;
						case 9:
							RightLeftM1=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
							print("RightLeftM1"+RightLeftM1);
							break;
						case 10:
							RightLeftM2=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
							print("RightLeftM2"+RightLeftM2);
							break;
						case 11:
							RightLeftM3=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
							print("RightLeftM3"+RightLeftM3);
							break;
						case 12:
							RightLeftM4=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
							print("RightLeftM4"+RightLeftM4);
							break;
						case 13:
							RightLeftM5=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
							print("RightLeftM5"+RightLeftM5);
							break;
						case 14:
							RightLeftM6=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
							print("RightLeftM6"+RightLeftM6);
							break;
						case 15:
							RightLeftM7=Random.Range(1,7);	 // choose a random number between 1 and 6 (we have 6 animations for males raising left hand)
							print("RightLeftM7"+RightLeftM7);
							break;
					}	
				}
			}
			else if (LR==2)		// Agents are supposed to raise their right hand -----------------------------------------------------------
			{
				for (int n = 0; n < numberOfAgents; n++)
				{
					// switch (respondingAgents[n])
					switch (Rem)
					{
						case 1:
							RightLeftF1=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF1"+RightLeftF1);
							break;
						case 2:
							RightLeftF2=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF2"+RightLeftF2);
							break;
						case 3:
							RightLeftF3=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF3"+RightLeftF3);
							break;
						case 4:
							RightLeftF4=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF4"+RightLeftF4);
							break;
						case 5:
							RightLeftF5=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF5"+RightLeftF5);
							break;
						case 6:
							RightLeftF6=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF6"+RightLeftF6);
							break;
						case 7:
							RightLeftF7=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF7"+RightLeftF7);
							break;
						case 8:
							RightLeftF8=Random.Range(7,9);	 // choose a random number between 7 and 8 (we have 3 animations for females raising right hand)
							print("RightLeftF8"+RightLeftF8);
							break;
						case 9:
							RightLeftM1=Random.Range(8,12);	 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
							print("RightLeftM1"+RightLeftM1);
							break;
						case 10:
							RightLeftM2=Random.Range(8,12);	 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
							print("RightLeftM2"+RightLeftM2);
							break;
						case 11:
							RightLeftM3=Random.Range(8,12);	 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
							print("RightLeftM3"+RightLeftM3);
							break;
						case 12:
							RightLeftM4=Random.Range(8,12);	 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
							print("RightLeftM4"+RightLeftM4);
							break;
						case 13:
							RightLeftM5=Random.Range(8,12);	 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
							print("RightLeftM5"+RightLeftM5);
							break;
						case 14:
							RightLeftM6=Random.Range(8,12);	 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
							print("RightLeftM6"+RightLeftM6);
							break;
						case 15:
							RightLeftM7=Random.Range(8,12);	 // choose a random number between 7 and 13 (we have 6 animations for males raising right hand)
							print("RightLeftM7"+RightLeftM7);
							break;
					}	
				}
			}
			for(int a=0; a<60; a++)
			{
				if (a % 15==1)
				{
					Animators[a].SetInteger("FLR", RightLeftF1);
					print("xxxxxxxxxxxxxxxxxxx");
				}
			}
			// Starting	idle position of all the avatars ---------------------------------------------------------------------------------------
			#region  StartIdle			
			// "F" for female idles ------------------------------------------------------------------------------------------------------------
			// Warning: for each avatar the value of "F", "FLR", "FI", and "RestartF" must be the same *****************************************
			// pAnimator.SetInteger("F", 0);
			fAnimator1.SetInteger("F", RightLeftF1); fAnimator2.SetInteger("F", RightLeftF2); fAnimator3.SetInteger("F", RightLeftF3); fAnimator4.SetInteger("F", RightLeftF4); fAnimator5.SetInteger("F", RightLeftF5); 
			// "M" for male idles --------------------------------------------------------------------------------------------------------------
			// Warning: for each avatar the value of "M", "MLR", "MI", and "RestartM" must be the same *****************************************
			mAnimator1.SetInteger("M", RightLeftM1); mAnimator2.SetInteger("M", RightLeftM2); mAnimator3.SetInteger("M", RightLeftM3); mAnimator4.SetInteger("M", RightLeftM4); 
			#endregion
			// =================================================================================================================================
			yield return new WaitForSeconds(agentsRHTime);		// wait for "agentsRHTime", then the agents raise their hand -------------------
			#region RaiseHand
			// Female avatars raise hand. "FLR" for female raise hand; FLR1~FLR6: left hand; FLR7~FLR9: right hand -----------------------------
			fAnimator1.SetInteger("FLR", RightLeftF1);fAnimator2.SetInteger("FLR", RightLeftF2);fAnimator3.SetInteger("FLR", RightLeftF3);fAnimator4.SetInteger("FLR", RightLeftF4);fAnimator5.SetInteger("FLR", RightLeftF5);
			// Male avatars raise hand. "MLR" for male raise hand; MLR1~MLR6: left hand; MLR7~MLR13: right hand --------------------------------
			mAnimator1.SetInteger("MLR", RightLeftM1);mAnimator2.SetInteger("MLR", RightLeftM2);mAnimator3.SetInteger("MLR", RightLeftM3);mAnimator4.SetInteger("MLR", RightLeftM4);
			print("handup"+numberOfAgents);
			#endregion
			
			// Beep ----------------------------------------------------------------------------------------------------------------------------
			// beepObject.SetActive(true);
			// audioSource.PlayOneShot(beeep, .01f);
			// =================================================================================================================================
			yield return new WaitForSeconds(agentsHUDuration);	// the duration that agents keep their hands up --------------------------------
			#region LowerHand
			// Female avatars lower their hands and go back to idle phase. "FI" for female lower hand; FI1~FI6: left hand; FI7~FI9: right hand -
			fAnimator1.SetInteger("FI", RightLeftF1);fAnimator2.SetInteger("FI", RightLeftF2);fAnimator3.SetInteger("FI", RightLeftF3);fAnimator4.SetInteger("FI", RightLeftF4);fAnimator5.SetInteger("FI", RightLeftF5);
			// =================================================================================================================================
			// Male avatars lower their hands and go back to idle phase. "MI" for male lower hand; MI1~MI6: left hand; MI7~M13: right hand -----
			mAnimator1.SetInteger("MI", RightLeftM1);mAnimator2.SetInteger("MI", RightLeftM2);mAnimator3.SetInteger("MI", RightLeftM3);mAnimator4.SetInteger("MI", RightLeftM4);
			print("handdown");
			#endregion
			// =================================================================================================================================
			timePass=Time.time-refTime;
			// yield return new WaitForSeconds((trialDuration-0.5f-timePass));
			#region OriginalIdle
			// *********************************************************************************************************************************
			// At the end of each trial we need to reset all the avatars to their first pose, to get ready for the next trial ------------------
			// "RestartF" to reset female avatars; RestartF1~RestartF9 -------------------------------------------------------------------------
			fAnimator1.SetInteger("RestartF", RightLeftF1);fAnimator2.SetInteger("RestartF", RightLeftF2);fAnimator3.SetInteger("RestartF", RightLeftF3);fAnimator4.SetInteger("RestartF", RightLeftF4);fAnimator5.SetInteger("RestartF", RightLeftF5);
			// "RestartM" to reset female avatars; RestartM1~RestartM13 ------------------------------------------------------------------------
			mAnimator1.SetInteger("RestartM", RightLeftM1);mAnimator2.SetInteger("RestartM", RightLeftM2);mAnimator3.SetInteger("RestartM", RightLeftM3);mAnimator4.SetInteger("RestartM", RightLeftM4);
			print("reset");
			// PlayerRightHand.transform.TransformPoint(PlayerRightHand.transform.position )=new Vector3(3.86f, 3.96f, -11.6f);
			// PlayerRightHand.localRotation=new Vector3(3.86f, 3.96f, -11.6f);
			#endregion
			#region  ResetAnimatorParameters
			// StopCoroutine(C2);
			// *********************************************************************************************************************************
			// yield return new WaitForSeconds(Time.deltaTime);	// wait for a glance and then reset all the animators, so that we can start over 
			// yield return new WaitForSeconds(1f);
			// on the next trial ---------------------------------------------------------------------------------------------------------------
			// *********************************************************************************************************************************
			// pAnimator.SetInteger("F", 0);
			fAnimator1.SetInteger("F", 0);fAnimator2.SetInteger("F", 0);fAnimator3.SetInteger("F", 0);fAnimator4.SetInteger("F", 0);fAnimator5.SetInteger("F", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("M", 0);mAnimator2.SetInteger("M", 0);mAnimator3.SetInteger("M", 0);mAnimator4.SetInteger("M", 0);
			// =================================================================================================================================
			fAnimator1.SetInteger("FLR", 0);fAnimator2.SetInteger("FLR", 0);fAnimator3.SetInteger("FLR", 0);fAnimator4.SetInteger("FLR", 0);fAnimator5.SetInteger("FLR", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("MLR", 0);mAnimator2.SetInteger("MLR", 0);mAnimator3.SetInteger("MLR", 0);mAnimator4.SetInteger("MLR", 0);
			// =================================================================================================================================
			fAnimator1.SetInteger("FI", 0);fAnimator2.SetInteger("FI", 0);fAnimator3.SetInteger("FI", 0);fAnimator4.SetInteger("FI", 0);fAnimator5.SetInteger("FI", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("MI", 0);mAnimator2.SetInteger("MI", 0);mAnimator3.SetInteger("MI", 0);mAnimator4.SetInteger("MI", 0);
			// =================================================================================================================================
			RightLeftF1=0; RightLeftF2=0; RightLeftF3=0; RightLeftF4=0; RightLeftF5=0; 
			RightLeftM1=0; RightLeftM2=0; RightLeftM3=0; RightLeftM4=0;
			yield return new WaitForSeconds(1f);
			// =================================================================================================================================
			fAnimator1.SetInteger("RestartF", 0);fAnimator2.SetInteger("RestartF", 0);fAnimator3.SetInteger("RestartF", 0);fAnimator4.SetInteger("RestartF", 0);fAnimator5.SetInteger("RestartF", 0);
			// ---------------------------------------------------------------------------------------------------------------------------------
			mAnimator1.SetInteger("RestartM", 0);mAnimator2.SetInteger("RestartM", 0);mAnimator3.SetInteger("RestartM", 0);mAnimator4.SetInteger("RestartM", 0);
			print("end");
			#endregion
		// }
    }
	#endregion
	// ExperimentControl coroutines ============================================================================================================
	
	
	// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                   make data string                   ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		IEnumerator DataStringMaker(float[,] responses, int trialNumber, List<string> myList){
			tempStr=(((responses[trialNumber, 0]).ToString())+", "+((responses[trialNumber, 1]).ToString())+", "+((responses[trialNumber, 2]).ToString())+", "+((responses[trialNumber, 3]).ToString())+", "+((responses[trialNumber, 4]).ToString())+", "+((responses[trialNumber, 5]).ToString())+", "+((responses[trialNumber, 6]).ToString())+", "+((responses[trialNumber, 7]).ToString()));
			// trialDataString.Add(new string(tempStr));
			myList.Add(tempStr);
			
			if (trialNumber==(numberOfPracticeTrials+numberOfTestTrials*2*numberOfRounds))		// *2 because we have two test sessions (blocks). Since the trialNumber starts at 1, no need to subtract 1 from the summation
			{
				WWWForm form=new WWWForm();
				prolificIdString2=prolificID.GetComponent<InputField>().text;
				// prolificIdString2="Asi";
				form.AddField(address[0],prolificIdString2);
				form.AddField(address[1],"DensityOverall");		// a code to simplify distinguishing the data from each experiment
				form.AddField(address[2],InstructionPick);		// a code to simplify distinguishing the data from each experiment
				for(int i = 0; i < (numberOfPracticeTrials+numberOfTestTrials*2*numberOfRounds); i++)
				{
					form.AddField(address[i+3],myList[i]);
				}
				byte[] rawData=form.data;
				WWW www=new WWW(BASE_URL, rawData);
				yield return www;
			}
			
			
			yield return null;
		}	
	
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::     get basic information from the participant       ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		IEnumerator PID(string MyProlificIdString){
		WWWForm form=new WWWForm();
		// form.AddField(address[0],MyProlificIdString);
		byte[] rawData=form.data;
		WWW www=new WWW(BASE_URL, rawData);
		//Input.ResetInputAxes();
		yield return null;
		// yield return new WaitForSeconds(0.5f);
		//yield return www;
		}
		
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::   save basic information of the participant  on google form   :::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::                                                      ::::::::::::::::::::::::::::::::::::::
		// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	public void Send(){
		prolificIdString1=prolificID.GetComponent<InputField>().text;
		int count = prolificIdString1.Length;
		InstructionGeneral1.SetActive(false);
		InstructionGeneral2.SetActive(false);
		if (count<20)
		{
			Error.SetActive(true);
		}
		else
		{
			Error.SetActive(false);
			// prolificIdString1="Asi";
			// StartCoroutine(PID(prolificIdString1));
			prolificID.SetActive(false);
			// 
			myButton.SetActive(false);	// This removes the button from the UI entirely:
			CanvasObject.GetComponent<Canvas>().enabled = false;
			CanvasBKG.GetComponent<SpriteRenderer>().enabled = false;
			Input.ResetInputAxes();
			StartCoroutine(GeneratePositions());
		}
	}
}