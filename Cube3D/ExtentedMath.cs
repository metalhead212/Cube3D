using static System.Math;
using Cube3D;

namespace XMath
{
	public static class Math3D
	{
		public enum Axis
		{
			OX, OY, OZ
		}
		/// <summary>
		/// Finds some point C that divides a segment AB in the given ratio  
		/// </summary>
		/// <param name="A">First point of segment</param>
		/// <param name="B">Second point of segment</param>
		/// <param name="lambda">Ratio = AB/BC, where C - unknown point</param>
		/// <returns>Point on segment AB</returns>
		public static Point3D BetweenAnB(Point3D A, Point3D B, float lambda)
		{
			float X = ( A.X + lambda * B.X ) / ( 1 + lambda );
			float Y = ( A.Y + lambda * B.Y ) / ( 1 + lambda );
			float Z = ( A.Z + lambda * B.Z ) / ( 1 + lambda );

			return new Point3D( X, Y, Z );
		}
		
		public static float DistanceTo( this Point3D p1, Point3D p2 )
		{
			return ( float )Sqrt(
				Pow( p1.X - p2.X, 2 ) +
				Pow( p1.Y - p2.Y, 2 ) +
				Pow( p1.Z - p2.Z, 2 ) );
		}
		public static float ToRad( this float angleDeg )
		{
			return ( angleDeg / 180.0f ) * ( float )PI;
		}

		public static void Rotate(this Point3D p, Axis axis, float angleDeg , Point3D rotateCenter )
		{
			float angleRad = angleDeg.ToRad();
			switch ( axis )
			{
				case Axis.OX:
				p.RotateAround_OX_axis( angleRad, rotateCenter );
				return;

				case Axis.OY:
				p.RotateAround_OY_axis( angleRad, rotateCenter );
				return;

				case Axis.OZ:
				p.RotateAround_OZ_axis( angleRad, rotateCenter );
				return;
			}
		}
			
		/// <summary>
		/// converts degrees to radians
		/// </summary>
		

		private static void RotateAround_OX_axis( this Point3D point, float angleRad, Point3D rotateCenter )
		{
			//поднимаем rotateCenter на уровень вращаемой точки point
			Point3D C = new Point3D( point.X, rotateCenter.Y, rotateCenter.Z);

			double newY = C.Y + ( point.Y - C.Y ) * Cos( angleRad ) - ( point.Z - C.Z ) * Sin( angleRad );
			double newZ = C.Z + ( point.Y - C.Y ) * Sin( angleRad ) + ( point.Z - C.Z ) * Cos( angleRad );

			point.Z = ( float )newZ;
			point.Y = ( float )newY;
		}

		private static void RotateAround_OY_axis( this Point3D point, float angleRad, Point3D rotateCenter )
		{
			//поднимаем rotateCenter на уровень вращаемой точки point
			Point3D C = new Point3D( rotateCenter.X, point.Y, rotateCenter.Z );

			double newX = C.X + ( point.X - C.X ) * Cos( angleRad ) - ( point.Z - C.Z ) * Sin( angleRad );
			double newZ = C.Z + ( point.X - C.X ) * Sin( angleRad ) + ( point.Z - C.Z ) * Cos( angleRad );

			point.X = ( float )newX;
			point.Z = ( float )newZ;
		}

		private static void RotateAround_OZ_axis( this Point3D point, float angleRad, Point3D rotateCenter )
		{
			//поднимаем rotateCenter на уровень вращаемой точки point
			Point3D C = new Point3D( rotateCenter.X, rotateCenter.Y, point.Z );

			double newX = C.X + ( point.X - C.X ) * Cos( angleRad ) - ( point.Y - C.Y ) * Sin( angleRad );
			double newY = C.Y + ( point.X - C.X ) * Sin( angleRad ) + ( point.Y - C.Y ) * Cos( angleRad );

			point.X = ( float )newX;
			point.Y = ( float )newY;
		}

		/// <summary>
		/// retruns ratio of two segments: AB and BC;
		/// ratio = AB /BC
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="C"></param>
		/// <returns> ratio = AB / BC</returns>
		public static float GetLambda( Point3D A, Point3D B, Point3D C )
		{
			return A.DistanceTo( B ) / B.DistanceTo( C );
		}

		public static bool IsEqualFloats( float f1, float f2, float allowedDifference = 0.001f)
		{
			return Abs( f1 - f2 ) <= allowedDifference;
		}
	}
}

