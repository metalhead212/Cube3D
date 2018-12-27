using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using static XMath.Math3D;

namespace Cube3D
{
	public class Cube3D
	{
		public List<Point3D> Points { get; private set; } = new List<Point3D>( 8 );
		public List<CubeFace> Faces { get; private set; } = new List<CubeFace>();

		public int[] ColorsARGB = new int[ 6 ];


		public Point3D Center { get { return BetweenAnB( Points[ 0 ], Points[ 6 ], 1 ); } }
		public Cube3D( IEnumerable<Point3D> points )
		{
			if ( points.Count() != 8 )
				throw new ArgumentException( "Count of points is not 8" );

			Points = points.ToList();

			InitializeFaces();
		}
		private void InitializeFaces()
		{
			int t = Int32.MaxValue;
			for ( int i = 0, k = 0; i < 6; i++, k = 0 )
			{
				Random R = new Random( DateTime.Now.Millisecond );
				unchecked
				{
					ColorsARGB[ i ] = ( t + DateTime.Now.Millisecond ^ t << ( t + 15 * ( R.Next() | t ) % 29 ) ) | ( int )0xFF000000;
					t /= -3;
				}
				Faces.Add( new CubeFace()
				{
					FaceTips = new Point3D[] {
											Points[ Cube3D.fields[i, k++] ],
											Points[ Cube3D.fields[i, k++] ],
											Points[ Cube3D.fields[i, k++] ],
											Points[ Cube3D.fields[i, k++] ] }
				} );
			}
		}

		public Cube3D( Point3D center, float rib_lenth )
		{
			Points.Add( new Point3D(
									center.X + rib_lenth / 2,
									center.Y + rib_lenth / 2,
									center.Z - rib_lenth / 2 ) );

			Points.Add( new Point3D( Points[ 0 ] ) );
			Points[ 1 ].Y = Points[ 1 ].Y - rib_lenth;

			Points.Add( new Point3D( Points[ 1 ] ) );
			Points[ 2 ].X = Points[ 2 ].X - rib_lenth;

			Points.Add( new Point3D( Points[ 2 ] ) );
			Points[ 3 ].Y = Points[ 3 ].Y + rib_lenth;
			for ( int i = 0; i < 4; i++ )
			{
				Points.Add( new Point3D( Points[ i ] ) );
				Points[ i + 4 ].Z = Points[ i ].Z + rib_lenth;
			}

			InitializeFaces();
		}
		private static readonly int[,] fields = new int[ 6, 4 ]{
								{ 0,3,7,4 },
								{ 1,5,4,0 },
								{ 2,3,0,1 },
								{ 3,7,6,2 },
								{ 4,5,6,7 },
								{ 5,6,2,1 }};


		public void Rotate( Axis axis, float angleDeg )
		{
			Point3D oldCenter = new Point3D( Center );
			for ( int i = 0; i < 8; i++ )
				Points[ i ].Rotate( axis, angleDeg, oldCenter );
		}

		public class CubeFace
		{
			public Point3D[] FaceTips = new Point3D[ 4 ];
			public Point3D FieldCenter
			{
				get
				{
					return BetweenAnB(
									FaceTips[ 0 ],
									FaceTips[ 2 ],
									1.0f );
				}
			}
		}

	}
	
	[Serializable]
	[DataContract]
	public class Cube3DSerializer
	{
		[DataMember]
		public List<Point3D> Points;
		[DataMember]
		public int[] ColorsARGB;
		public Cube3DSerializer( Cube3D cube )
		{
			Points = cube.Points;
			ColorsARGB = cube.ColorsARGB;
		}
		public Cube3DSerializer(){}


		public static implicit operator Cube3D( Cube3DSerializer cubeserializer )
		{
			return new Cube3D( cubeserializer.Points ) { ColorsARGB = cubeserializer.ColorsARGB };
		}

		public static implicit operator Cube3DSerializer( Cube3D cube )
		{
			return new Cube3DSerializer( cube );
		}
	}
}

