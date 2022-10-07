using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private Transform circleMover;
    [SerializeField] private int speed;
    private List<Vector2>points;
    private int clicksMouse;
    private int nextPoint;
    //private int clickMinusPoint;
    //[SerializeField] private int maxClick;

    private void Start()
    {
        points = new List<Vector2>();
        nextPoint = 0;
        clicksMouse = 0;
       
    }

    /// <summary>
    /// —читаем количество кликов и добавл€м координаты клика в массив
    /// </summary>
    private void ClickMousePos()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clicksMouse++;
            points.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
    /// <summary>
    /// ≈сли число кликов привышает текущую точку то двигаем круг к следующей точке из листа
    /// </summary>
    private void Update()
    {
        //clickMinusPoint = clicksMouse - nextPoint;
        ClickMousePos();
        if (clicksMouse > nextPoint)
        {
            circleMover.position = Vector2.MoveTowards(circleMover.position, points[nextPoint], Time.deltaTime * speed);
            Vector2 circleMoverTmp = circleMover.position;
            if (circleMoverTmp == points[nextPoint])
            {
                nextPoint++;
            }
            
        }
        
    }
}
