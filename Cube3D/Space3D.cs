using System.Drawing;
using static System.Math;
using static XMath.Math3D;


namespace Cube3D
{
	public class SceneCamera
	{
		public static SceneCamera DefaultCam
		{
			get
			{
				return new SceneCamera()
				{
					ViewPoint = new Point3D( 0, 0, -100 ),
					screenCenter = new Point3D( 0,  0, 0 )
				};
			}
		}
		public Point3D ViewPoint = new Point3D( 0, 0, -1000 );
		public Point3D screenCenter = new Point3D( 0, 0, 0 );
	}

	class Vector2D
	{
		public float X, Y;

		public virtual float Lenth
		{
			get { return ( float )Sqrt( Pow( this.X, 2 ) + Pow( this.Y, 2 ) ); }
		}
		public Vector2D() { X = Y = 0; }
		public Vector2D( float x, float y )
		{
			this.X = x;
			this.Y = y;
		}

		public Vector2D( Point begin, Point end )
		{
			X = end.X - begin.X;
			Y = end.Y - begin.Y;
		}

		public static float operator *( Vector2D v1, Vector2D v2 )
		{
			return ( v1.X * v2.X ) +
				( v1.Y * v2.Y );
		}
		public static float GetCosBetween( Vector2D v1, Vector2D v2 )
		{
			return ( v1 * v2 ) / ( v1.Lenth * v2.Lenth );
		}
	}
	class Vector3D : Vector2D
	{
		public float  Z;

		public override float Lenth => ( float )Sqrt( Pow( this.X, 2 ) + Pow( this.Y, 2 ) + Pow( this.Z, 2 ) );
		public Vector3D( float x, float y, float z ) : base( x, y ) { this.Z = z; }

		public Vector3D( Point3D begin, Point3D end ): base( end.X - begin.X, end.Y - begin.Y )
		{
			Z = end.Z - begin.Z;
		}

		public static float operator *( Vector3D v1, Vector3D v2 )
		{
			return ( v1.X * v2.X) + 
				(v1.Y * v2.Y) + 
				(v1.Z * v2.Z );
		}
		public static float GetCosBetween( Vector3D v1, Vector3D v2)
		{ 	
			return ( v1 * v2 ) / ( v1.Lenth * v2.Lenth );
		}

	}

	class Space3D
	{
		public Cube3D Cube;
		private SceneCamera Camera;
		public Rectangle ClientRect;
		public Graphics Grph;
		public float PenWidth = 1.3f;
		public int SelectedFace = -1;
		public Bitmap GetBitmap()
		{
			Bitmap bmp = new Bitmap( ClientRect.Width, ClientRect.Height );
			Grph = Graphics.FromImage( bmp );
			DrawCube( Grph );
			return bmp;			
		}
		public Space3D()
		{
			Camera = new SceneCamera();

			Cube = new Cube3D( new Point3D( 0, 0, 600 ), 300.0f );
		}


		public void DrawCube(Graphics grph)
		{
			Grph = grph;
			for ( int i = 0, check = 0; i < 6 && check < 3 ; i++ )
				if ( IsCubeFaceVisible( i ) )
				{
					check++;
					DrawCubeField( i );
				}
		}
		private void DrawCubeField( int face_number )
		{

			Point[] screen_points = To2DPolygon( face_number );

			Grph.DrawPolygon( 
							new Pen( Color.Black, PenWidth ), 
							screen_points );

			Grph.FillPolygon( 
							new SolidBrush( Color.FromArgb( Cube.ColorsARGB[face_number] ) ), 
							screen_points );
		}


		private bool IsCubeFaceVisible( int face_number )
		{
			Point3D face_center = Cube.Faces[ face_number ].FieldCenter;

			Vector3D NormalVector = new Vector3D( Cube.Center, face_center );
			Vector3D View = new Vector3D( Camera.ViewPoint, face_center );

			return Vector3D.GetCosBetween( View, NormalVector ) <= 0;
		}

		internal void ChangeSelectedFaceColor(int argb)
		{
			if(-1 != SelectedFace)
			Cube.ColorsARGB[ SelectedFace ] = argb;
		}

		/// <summary>
		///Вычисляет, где должна находиться проекция данной точки point на екране
		/// </summary>
		/// <param name="point"></param>
		/// <returns></returns>
		public Point ToScreenPoint( Point3D point )
		{
			Point DisplayCenter = new Point( ClientRect.Width / 2, ClientRect.Height / 2 );

			float lambda = GetLambda(
									new Point3D( 0, 0, point.Z ),
									Camera.screenCenter,
									Camera.ViewPoint );

			//получаем точку-проекцию на екране
			Point3D result = BetweenAnB( point, Camera.ViewPoint, lambda );

			//возвращаем двумерную версию result
			return new Point(	( int )( result.X + DisplayCenter.X ), 
								( int )( result.Y + DisplayCenter.Y ) );
		}

		public int TrySelectCubeFace( Point location )
		{
			for ( int i = 0, check = 0; i < 6 && check < 3; i++ )
				if ( IsCubeFaceVisible( i ) )
				{
					check++;
					Point[] polygon_points = To2DPolygon( i );
					Vector2D[] vectors = new Vector2D[4];
					float angle_sum = 0;

					int k = 0;
					vectors[ k ] = new Vector2D( polygon_points[ k++ ], location );
					while ( k != 4 )
					{
						vectors[ k ] = new Vector2D( polygon_points[ k ], location );
						angle_sum += ( float )Acos( Vector2D.GetCosBetween( vectors[ k - 1 ], vectors[ k++ ] ) );
					}

					angle_sum += ( float )Acos( Vector2D.GetCosBetween( vectors[ 3 ], vectors[ 0 ] ) );

					if ( IsEqualFloats( angle_sum, 2.0f * ( float )PI ) )
						return SelectedFace = i;
				}
			return SelectedFace = -1;
		}

		private Point[] To2DPolygon( int face_number )
		{
			Point[] screen_points = new Point[ 4 ];
			for ( int i = 0; i < 4; i++ )
				screen_points[ i ] = ToScreenPoint( Cube.Faces[ face_number ].FaceTips[ i ] );
			return screen_points;
		}
	}
}




