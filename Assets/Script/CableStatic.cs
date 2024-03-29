using UnityEngine;

public class CableStatic : MonoBehaviour
{

	private LineRenderer line;

	// The Start of the cable will be the transform of the GameObject that has this component.
	// The Transform of the Gameobject where the End of the cable is. This needs to be assigned in the inspector.
	private Transform EndPointTransform;
	[SerializeField]  private GameObject EndPointPrefab;
	// Number of points per meter
	[SerializeField, Tooltip("Number of points per unit length, using the straight line from the start to the end transform.")] float pointDensity = 3;

	// How much the cable will sag by.
	[SerializeField] private float sagAmplitude = 1;

	// These are used later for calculations
	private int pointsInLineRenderer;
	private Vector3 vectorFromStartToEnd;
	private Vector3 sagDirection;
    private void Start()
    {
		line = GetComponent<LineRenderer>();
		EndPointPrefab = null;
    }
    public bool HasEndPoint
    {
		get { return EndPointPrefab != null; }
    }
	public void SetEndPoint(GameObject EndPoint)
    {
		EndPointPrefab = EndPoint;
    }
    public void DrawCable()
	{
		EndPointTransform = EndPointPrefab.transform;
		// Get direction Vector.
		vectorFromStartToEnd = EndPointTransform.position - transform.position;
		// Setting the Start object to look at the end will be used for making the wind be perpendicular to the cable later.
		transform.forward = vectorFromStartToEnd.normalized;
		// Get number of points in the cable using the distance from the start to end, and the point density
		pointsInLineRenderer = Mathf.FloorToInt(pointDensity * vectorFromStartToEnd.magnitude);
		// Set number of points in line renderer
		line.positionCount = pointsInLineRenderer;

		// The Direction of SAG is the direction of gravity
		sagDirection = Physics.gravity.normalized;

		// What point is being calculated
		int i = 0;

		while (i < pointsInLineRenderer)
		{
			// This is the fraction of where we are in the cable and it accounts for arrays starting at zero.
			float pointForCalcs = (float)i / (pointsInLineRenderer - 1);
			// This is what gives the cable a curve and makes the wind move the center the most.
			float effectAtPointMultiplier = Mathf.Sin(pointForCalcs * Mathf.PI);

			// Calculate the position of the current point i
			Vector3 pointPosition = vectorFromStartToEnd * pointForCalcs;
			// Calculate the sag vector for the current point i
			Vector3 sagAtPoint = sagDirection * sagAmplitude;
			// Calculate the sway vector for the current point i

			// Calculate the postion with Sag.
			Vector3 currentPointsPosition =
				transform.position +
				pointPosition +
				(Vector3.ClampMagnitude(sagAtPoint, sagAmplitude)) * effectAtPointMultiplier;

			// Set point
			line.SetPosition(i, currentPointsPosition);
			i++;
		}
	}
}