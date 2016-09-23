using UnityEngine;
using System.Collections.Generic;

namespace Assets.Lecture2
{
	public class TempMain : MonoBehaviour
	{
		private void Awake()
		{
			ShapeCalculator calcualte = new ShapeCalculator();

			//float rectArea = calcualte.GetArea( new Rectangle( 4, 5 ) );
			//float triArea = calcualte.GetArea( new Triangle(4, 5) );

			//Debug.Log("Rectangle : " + rectArea);
			//Debug.Log("Triangle : " + triArea);

			//List<object> shapeList = new List<object>();

			//shapeList.Add(new Rectangle(4, 5));
			//shapeList.Add(new Triangle(4, 5));

			//float totalArea = calcualte.GetTotalArea( shapeList );
			//Debug.Log("total : " + totalArea);

			var rectAngle = new Rectangle( 4, 5 );
			var triAngle = new Triangle( 4, 5 );

			List<IShape> shapeList = new List<IShape>();
			shapeList.Add( rectAngle );
			shapeList.Add( triAngle );

			Debug.Log("Rectangle : " + rectAngle.Area );
			Debug.Log("Triangle : " + triAngle.Area );
			Debug.Log("total : " + calcualte.TotalArea(shapeList) );

			DoWorkRectAngle doworkAngle = new DoWorkRectAngle();

			doworkAngle.DoWork();
			
			Debug.Log("----------------------------------------" );
			
			Calculator calc = new Calculator();
			calc.DoCalculate();
		}
	}
}
