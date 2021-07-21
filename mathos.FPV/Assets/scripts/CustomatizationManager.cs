using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;

public class CustomatizationManager : MonoBehaviour
{
    enum AppearanceDetail
    {
        PROP_MODEL,
        MOTOR_MODEL,
        BODY_MODEL
    }
    [SerializeField] private GameObject[] propModel;
    [SerializeField] private GameObject[] motorModel;
    [SerializeField] private GameObject[] bodyModel;

    [SerializeField] private Transform propAnchor;
    [SerializeField] private Transform motorAnchor;
    [SerializeField] private Transform bodyAnchor;


    public class MyClass
    {
        public int PROPMODEL;
        public int MOTORMODEL;
        public int BODYMODEL;
    }

    GameObject activeProp;
    GameObject activeMotor;
    GameObject activeBody;

    int i = 0;
    int racunanjedrona = -1;
    public int ukupna_tezina;

    public string myRecepie;

    Dictionary<AppearanceDetail, int> chosenApperenc;


    int propIndex = 0;
    int motorIndex = 0;
    int bodyIndex = 0;

    enum motorDetail {
        motorTezina,
        motorKV,
        Maxtorque,
        MaxThrust,
        Type
    }
    public class MotoClass
    {
        public int motorTezina;
        public int motorKV;
        public string Maxtorque;
        public string MaxThust;
        public string Type;
    }

    enum frameDetail
    {   
        Frametezina,
        width,
        Length,
        Lift_effecent,
        Drag_coefficient,
        Type
    }
    public class DroneClass
    {
        public int Frametezina;
        public string width;
        public string Length;
        public string Lift_effecent;
        public string Drag_coefficient;
        public string Type;
    }



    public void PropModelUp()
    {
        if (propIndex < propModel.Length - 1)
            propIndex++;
        else
            propIndex = 0;

        ApplyModification(AppearanceDetail.PROP_MODEL, propIndex);
    }
    public void PropModelDown()
    {
        if (propIndex > 0)
            propIndex--;
        else
            propIndex = propModel.Length - 1;
        ApplyModification(AppearanceDetail.PROP_MODEL, propIndex);

    }



    public void motorModelUp()
    {
        if (motorIndex < motorModel.Length - 1)
            motorIndex++;
        else
            motorIndex = 0;

        ApplyModification(AppearanceDetail.MOTOR_MODEL, motorIndex);
    }
    public void motorModelDown()
    {
        if (motorIndex > 0)
            motorIndex--;
        else
            motorIndex = motorModel.Length - 1;
        ApplyModification(AppearanceDetail.MOTOR_MODEL, motorIndex);
    }




    public void bodyModelUp()
    {
        if (bodyIndex < bodyModel.Length - 1)
            bodyIndex++;
        else
            bodyIndex = 0;

        ApplyModification(AppearanceDetail.BODY_MODEL, bodyIndex);
    }
    public void bodyModelDown()
    {
        if (bodyIndex > 0)
            bodyIndex--;
        else
            bodyIndex = bodyModel.Length - 1;
        ApplyModification(AppearanceDetail.BODY_MODEL, bodyIndex);


    }





    void ApplyModification(AppearanceDetail detail, int id)
    {
        switch (detail)
        {
            case AppearanceDetail.PROP_MODEL:
                if (activeProp != null)
                    GameObject.Destroy(activeProp);

                activeProp = GameObject.Instantiate(propModel[id]);
                activeProp.transform.SetParent(propAnchor);
                //activeBody.transform.ResetTransform();
                break;

            case AppearanceDetail.MOTOR_MODEL:
                if (activeMotor != null)
                    GameObject.Destroy(activeMotor);

                activeMotor = GameObject.Instantiate(motorModel[id]);
                activeMotor.transform.SetParent(motorAnchor);
                activeMotor.transform.ResetTransform();
                break;

            case AppearanceDetail.BODY_MODEL:
                if (activeBody != null)
                    GameObject.Destroy(activeBody);

                activeBody = GameObject.Instantiate(bodyModel[id]);
                activeBody.transform.SetParent(bodyAnchor);
                activeBody.transform.ResetTransform();
                break;
        }
    }
    MyClass myObject = new MyClass();



    public void SaveApperance1()
    {


        myObject.PROPMODEL = propIndex;
        myObject.MOTORMODEL = motorIndex;
        myObject.BODYMODEL = bodyIndex;

        string json = JsonUtility.ToJson(myObject);

        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone1.json";
        File.WriteAllText(m_Path, json);
        if (racunanjedrona == -1)
        {
            racunanjedrona += 1;
        }


    }
    public void SaveApperance2()
    {


        myObject.PROPMODEL = propIndex;
        myObject.MOTORMODEL = motorIndex;
        myObject.BODYMODEL = bodyIndex;

        string json = JsonUtility.ToJson(myObject);

        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone2.json";
        File.WriteAllText(m_Path, json);
        if (racunanjedrona == -1)
        {
            racunanjedrona += 1;
        }
    }
    public void SaveApperance3()
    {


        myObject.PROPMODEL = propIndex;
        myObject.MOTORMODEL = motorIndex;
        myObject.BODYMODEL = bodyIndex;

        string json = JsonUtility.ToJson(myObject);

        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone3.json";
        File.WriteAllText(m_Path, json);

        if (racunanjedrona == -1)
        {
            racunanjedrona += 1;
        }
    }
    public void SaveApperance4()
    {


        myObject.PROPMODEL = propIndex;
        myObject.MOTORMODEL = motorIndex;
        myObject.BODYMODEL = bodyIndex;

        string json = JsonUtility.ToJson(myObject);

        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone4.json";
        File.WriteAllText(m_Path, json);
        if (racunanjedrona == -1)
        {
            racunanjedrona += 1;
        }
    }





    public void LoadApperance1()
    {
        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone1.json";
        string json = File.ReadAllText(m_Path);

        myObject = JsonUtility.FromJson<MyClass>(json);

        ApplyModification(AppearanceDetail.PROP_MODEL, myObject.PROPMODEL);
        ApplyModification(AppearanceDetail.MOTOR_MODEL, myObject.MOTORMODEL);
        ApplyModification(AppearanceDetail.BODY_MODEL, myObject.BODYMODEL);

        string DroneGlavniPath = m_Path + "/scripts/Json/GlavniDron.json";
        File.WriteAllText(m_Path, json);
    }
    public void LoadApperance2()
    {
        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone2.json";
        string json = File.ReadAllText(m_Path);

        myObject = JsonUtility.FromJson<MyClass>(json);

        ApplyModification(AppearanceDetail.PROP_MODEL, myObject.PROPMODEL);
        ApplyModification(AppearanceDetail.MOTOR_MODEL, myObject.MOTORMODEL);
        ApplyModification(AppearanceDetail.BODY_MODEL, myObject.BODYMODEL);

        string DroneGlavniPath = m_Path + "/scripts/Json/GlavniDron.json";
        File.WriteAllText(m_Path, json);
    }
    public void LoadApperance3()
    {
        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone3.json";
        string json = File.ReadAllText(m_Path);

        myObject = JsonUtility.FromJson<MyClass>(json);

        ApplyModification(AppearanceDetail.PROP_MODEL, myObject.PROPMODEL);
        ApplyModification(AppearanceDetail.MOTOR_MODEL, myObject.MOTORMODEL);
        ApplyModification(AppearanceDetail.BODY_MODEL, myObject.BODYMODEL);

        string DroneGlavniPath = m_Path + "/scripts/Json/GlavniDron.json";
        File.WriteAllText(m_Path, json);
    }

    public void LoadApperance4()
    {
        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Drone4.json";
        string json = File.ReadAllText(m_Path);

        myObject = JsonUtility.FromJson<MyClass>(json);

        ApplyModification(AppearanceDetail.PROP_MODEL, myObject.PROPMODEL);
        ApplyModification(AppearanceDetail.MOTOR_MODEL, myObject.MOTORMODEL);
        ApplyModification(AppearanceDetail.BODY_MODEL, myObject.BODYMODEL);

        string DroneGlavniPath = m_Path + "/scripts/Json/GlavniDron.json";
        File.WriteAllText(m_Path, json);
    }
    public void PreloadDrone() {
        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/PreloadDrone.json";
        string json = File.ReadAllText(m_Path);

        myObject = JsonUtility.FromJson<MyClass>(json);

        ApplyModification(AppearanceDetail.PROP_MODEL, myObject.PROPMODEL);
        ApplyModification(AppearanceDetail.MOTOR_MODEL, myObject.MOTORMODEL);
        ApplyModification(AppearanceDetail.BODY_MODEL, myObject.BODYMODEL);

        string DroneGlavniPath = m_Path + "/scripts/Json/GlavniDron.json";
        File.WriteAllText(m_Path, json);

    }



    public void DroneModelUp()
    {


        if (racunanjedrona == -1)
        {
            PreloadDrone();
        }
        else
        {
            if (racunanjedrona < bodyModel.Length - 1)
                racunanjedrona++;
            else
                racunanjedrona = 0;

            if (racunanjedrona == 0)
                LoadApperance1();
            else if (racunanjedrona == 1)
                LoadApperance2();
            else if (racunanjedrona == 2)
                LoadApperance3();
            else if (racunanjedrona == 3)
                LoadApperance4();
        }
    }

    public void DroneModelDown()
    {

        if (racunanjedrona == -1)
        {
            PreloadDrone();
        }
        else
        {

            if (racunanjedrona > 0)
                racunanjedrona--;
            else
                racunanjedrona = bodyModel.Length - 1;

            if (racunanjedrona == 0)
                LoadApperance1();
            else if (racunanjedrona == 1)
                LoadApperance2();
            else if (racunanjedrona == 2)
                LoadApperance3();
            else if (racunanjedrona == 3)
                LoadApperance4();

            if (racunanjedrona == -1)
            {
                PreloadDrone();
            }
        }

    }

    private void Update()
    {
        if (i == 1)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GameScene"))
            {
                string m_Path = Application.dataPath;
                m_Path = m_Path + "/scripts/Json/GlavniDron.json";

                string json = File.ReadAllText(m_Path);

                myObject = JsonUtility.FromJson<MyClass>(json);

                ApplyModification(AppearanceDetail.PROP_MODEL, myObject.PROPMODEL);
                ApplyModification(AppearanceDetail.MOTOR_MODEL, myObject.MOTORMODEL);
                ApplyModification(AppearanceDetail.BODY_MODEL, myObject.BODYMODEL);
            }
        }
        i = i + 1;
    }


    public void izlazak()
    {
        Application.Quit();
    }


    MotoClass tezina_motora= new MotoClass();

    public void TezinaMotora1()
    {
        tezina_motora.motorTezina = 1;
        tezina_motora.motorKV = 2400;
        tezina_motora.Maxtorque = "0.1800Nm";
        tezina_motora.MaxThust = "1368g";
        tezina_motora.Type = "1";


        string motorjs = JsonUtility.ToJson(tezina_motora);

        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Motor1.json";
        File.WriteAllText(m_Path, motorjs);
        
    }


    DroneClass myframe = new DroneClass();

    public void TezinaBody1()
    {
        myframe.Frametezina = 2;
        myframe.width = "1cm";
        myframe.Length = "2cm";
        myframe.Lift_effecent = "0.0400";
        myframe.Drag_coefficient = "666.666";
        myframe.Type = "5";


        string Bodyjs = JsonUtility.ToJson(myframe);

        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/Body1.json";
        File.WriteAllText(m_Path, Bodyjs);
    }
    
    public int LoadTezinu()
    {
        int tezinamoto = 0;
        int tezinabody = 0;
        
        string m_Path = Application.dataPath;
        m_Path = m_Path + "/scripts/Json/GlavniDron.json";
        string json = File.ReadAllText(m_Path);
        myObject = JsonUtility.FromJson<MyClass>(json);

        
        
        string moto_Path = Application.dataPath;
        moto_Path = moto_Path + "/scripts/Json/Motor1.json";
        string motorjs = File.ReadAllText(moto_Path);
        tezina_motora = JsonUtility.FromJson<MotoClass>(motorjs);

       string body_Path = Application.dataPath;
        body_Path = body_Path + "/scripts/Json/Body1.json";
        string bodyjs = File.ReadAllText(body_Path);
        myframe = JsonUtility.FromJson<DroneClass>(bodyjs);

        
        
        if (myObject.MOTORMODEL==0)
        {
            tezinamoto = tezina_motora.motorTezina;
            tezinabody = myframe.Frametezina;
            Debug.Log("radi if");
            Debug.Log(tezinamoto);
            Debug.Log(tezinabody);
        }


        



        return ukupna_tezina = tezinamoto + tezinabody;
    }

    private void Start()
    {
        LoadTezinu();
        Debug.Log(ukupna_tezina);
        TezinaMotora1();


        TezinaBody1();
    }



}
