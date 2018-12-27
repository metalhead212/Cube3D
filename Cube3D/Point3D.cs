using System;

namespace Cube3D
{
	[Serializable]
	public class Point3D : ICloneable
	{
		public float X, Y, Z;
		public Point3D()
		{
			X = Y = Z = 0;	
		}
		public Point3D( float x, float y, float z )
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}
		public Point3D( Point3D p): this(p.X, p.Y, p.Z){}


		public object Clone()
		{
			return new Point3D( this );
		}

	}
}
