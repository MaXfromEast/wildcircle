using UnityEngine;

public class WriteLine : MonoBehaviour
{
    public LineRenderer line;
    [SerializeField] private Transform circleWL;
    private Vector2 startPoint;
    private void Start()
    {
        line.startWidth = 0.03f;
        line.endWidth = 0.03f;
        line.positionCount = 1;
        startPoint = circleWL.position; // запоминаем начальную позицию круга
        line.SetPosition(0, startPoint); // точку 0 устанавливаем в нач. поз. круга 
    }

    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 currentPosition = GetWorldCoordinate(Input.mousePosition);
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, currentPosition);
        }
       
    }
    /// <summary>
    /// мировые координаты мыши
    /// </summary>
    /// <param name="mousePosition"></param>
    /// <returns></returns>
    private Vector2 GetWorldCoordinate(Vector3 mousePosition)
    {
        Vector2 mousePoint = new Vector2(mousePosition.x, mousePosition.y);
        return (Camera.main.ScreenToWorldPoint(mousePoint));
    }

  
}
