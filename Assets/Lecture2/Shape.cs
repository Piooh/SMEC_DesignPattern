using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Lecture2
{
	#region SRP
	public class Student
	{
		public void Study()
		{
		}

		//public void Work()
		//{
		//}
	}

	public class Employee
	{
		public void Work()
		{
		}
	}
	#endregion SRP

	#region OCP
	public interface IShape
	{
		float Area { get; }
	}

	public class Rectangle : IShape
	{
		public virtual float Width		{ get; protected set; }
		public virtual float Height		{ get; protected set; }
		public float Area					{ get { return Width * Height; }	}

		public Rectangle( float width, float height )
		{
			Width = width;
			Height = height;
		}
	}

	public class Triangle : IShape
	{
		public float Bottom				{ get; private set; }
		public float Height				{ get; private set; }
		public float Area					{ get { return ( Bottom * Height ) / 2; }	}

		public Triangle( float bottom, float height )
		{
			Bottom = bottom;
			Height = height;
		}
	}

	public class Circle : IShape
	{
		public float Radius	{ get; set; }
		public float Area		{ get { return Radius * Radius * Mathf.PI; } }

		public Circle( float radius )
		{
			Radius = radius;
		}
	}

	public class ShapeCalculator
	{
		#region Old
		//public float GetArea( Rectangle rect )
		//{
		//	return rect.Width * rect.Height;
		//}

		//public float GetArea( Triangle tri  )
		//{
		//	return (tri.Bottom * tri.Height) / 2 ;
		//}

		//public float GetTotalArea( List<object> list )
		//{
		//	float totalArea = 0f;

		//	for( int  i = 0; i < list.Count; i++ )
		//	{
		//		var shape = list[i];
		//		if( shape is Rectangle )
		//		{
		//			var rect = shape as Rectangle;
		//			totalArea += GetArea( rect );
		//		}
		//		else if(  shape is Triangle )
		//		{
		//			var tri = shape as Triangle;
		//			totalArea += GetArea( tri );
		//		}
		//		/// todo.....
		//	}

		//	return totalArea;
		//}
		#endregion Old

		public float TotalArea( List<IShape> list )
		{
			float totalArea = 0f;

			for( int i = 0; i < list.Count; i++ )
			{
				totalArea += list[i].Area;
			}

			return totalArea;
		}
	}
	#endregion OCP

	#region LSP
	public class Square : Rectangle
	{
		public override float Width
		{
			get
			{
				return base.Width;
			}

			protected set
			{
				base.Width = value;
				base.Height = value;
			}
		}

		public override float Height
		{
			get
			{
				return base.Height;
			}

			protected set
			{
				base.Width = value;
				base.Height = value;
			}
		}

		public Square( float width, float height ) : base( width, height )
		{
		}
	}

	public class DoWorkRectAngle
	{
		public bool CheckArea( Rectangle rect )
		{
			return 20 == rect.Area;
		}

		public void DoWork()
		{
			//Rectangle rect = new Rectangle(4, 5);
			Rectangle rect = new Square(4, 5);

			if( true == CheckArea(rect) )
			{
				Debug.Log( "Do Work!" );
			}
			else
			{
				Debug.LogError( "Error!!! : " + rect.Area );
			}
		}
	}

	#endregion LSP

	#region ISP
	public interface IBird
	{
		void Fly();
		void Swim();
	}

	public class Duck : IBird
	{
		public void Fly()
		{
			Debug.Log( "I can Fly!" );
		}

		public void Swim()
		{
			Debug.Log( "I can Swim!" );
		}
	}

	public class Penguin : IBird
	{
		public void Fly()
		{
			Debug.Log( "I can't Fly...." );
		}

		public void Swim()
		{
			Debug.Log( "I can Swim!" );
		}
	}

	public class Kiwi : IBird
	{
		public void Fly()
		{
			Debug.Log( "I can't Fly...." );
		}

		public void Swim()
		{
			Debug.Log( "I can't Swim...." );
		}
	}

	#endregion ISP

	#region DIP
	public interface ISum
	{
		int Sum( int value1, int value2 );
	}

	public class NormalSum : ISum
	{
		public int Sum( int value1, int value2 )
		{
			return value1 + value2;
		}
	}

	public class X2Sum : ISum
	{
		public int Sum( int value1, int value2 )
		{
			return (value1 + value2) * 2;
		}
	}

	public class Calculator
	{
		//private NormalSum sumAction = new NormalSum();
		//private ISum sumAction = new NormalSum();
		private ISum sumAction = new X2Sum();

		public void DoCalculate()
		{
			var result = sumAction.Sum( 1, 2 );
			Debug.Log( sumAction.ToString() + " : " + result );
		}
	}

	#endregion DIP

}