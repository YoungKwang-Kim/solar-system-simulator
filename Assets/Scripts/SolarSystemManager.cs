using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemManager : MonoBehaviour
{
    [SerializeField] private GameObject sun;
    [SerializeField] private GameObject mercury;
    [SerializeField] private GameObject venus;
    [SerializeField] private GameObject earth;
    [SerializeField] private GameObject moon;
    [SerializeField] private GameObject mars;
    [SerializeField] private GameObject jupiter;
    [SerializeField] private GameObject saturn;
    [SerializeField] private GameObject uranus;
    [SerializeField] private GameObject neptune;
    [SerializeField] private GameObject asteroidsSphere;

    private float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        RotationAxis();
    }

    // Update is called once per frame
    void Update()
    {
        Orbit(mercury, 80);
        Orbit(venus, 50);
        Orbit(earth, 25);
        OrbitMoon(150);
        Orbit(mars, 20);
        Orbit(jupiter, 10);
        Orbit(saturn, 8);
        Orbit(uranus, 5);
        Orbit(neptune, 3);
        Orbit(asteroidsSphere, 50);
        Rotate(mercury, 100);
        Rotate(venus, 80);
        Rotate(earth, 50);
        Rotate(moon, 90);
        Rotate(mars, 50);
        Rotate(jupiter, 40);
        Rotate(saturn, 30);
        Rotate(uranus, 50);
        Rotate(neptune, 50);
    }

    // 공전 함수
    void Orbit(GameObject planet, float orbitSpeed)
    {
        planet.transform.RotateAround(sun.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
    // 달의 공전 함수
    void OrbitMoon(float orbitSpeed)
    {
        moon.transform.RotateAround(earth.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }

    // 자전축을 실제처럼 기울이게하는 함수
    void RotationAxis()
    {
        mercury.transform.Rotate(0, 0, 10);
        venus.transform.Rotate(0, 0, 30);
        earth.transform.Rotate(0, 0, 30);
        mars.transform.Rotate(0, 0, 20);
        jupiter.transform.Rotate(0, 0, 50);
        saturn.transform.Rotate(0, 0, 50);
        uranus.transform.Rotate(0, 0, 50);
    }

    // 자전 함수
    void Rotate(GameObject planet, float rotateSpeed)
    {
        planet.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
    }
}
