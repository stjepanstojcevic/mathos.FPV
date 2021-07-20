using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;

public class Customatization2 : MonoBehaviour
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

    public string myRecepie;

    Dictionary<AppearanceDetail, int> chosenApperenc;


    int propIndex = 0;
    int motorIndex = 0;
    int bodyIndex = 0;

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
                //activeMotor.transform.ResetTransform();
                break;

            case AppearanceDetail.BODY_MODEL:
                if (activeBody != null)
                    GameObject.Destroy(activeBody);

                activeBody = GameObject.Instantiate(bodyModel[id]);
                activeBody.transform.SetParent(bodyAnchor);
                //activeBody.transform.ResetTransform();
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



}



