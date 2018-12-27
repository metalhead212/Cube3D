using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using static XMath.Math3D;
namespace Cube3D
{
	public partial class MainForm : Form
	{
		Space3D Space;
		public MainForm()
		{
			InitializeComponent();
			Space = new Space3D();
			Space.ClientRect = Display.ClientRectangle;

			ColorEditor.Enabled = false;
			RedChannel_trackBar.DataBindings.Add( new Binding( "Value", Red_UpDown, "Value" ) );
			Red_UpDown.DataBindings.Add( new Binding( "Value", RedChannel_trackBar, "Value" ) );


			BlueChannel_trackBar.DataBindings.Add( new Binding( "Value", Blue_UpDown, "Value" ) );
			Blue_UpDown.DataBindings.Add( new Binding( "Value", BlueChannel_trackBar, "Value" ) );

			GreenChannel_trackBar.DataBindings.Add( new Binding( "Value", Green_UpDown, "Value" ) );
			Green_UpDown.DataBindings.Add( new Binding( "Value", GreenChannel_trackBar, "Value" ) );
			offset_UpDown.Value = 15;

			Display.Select();
			Space.DrawCube( Display.CreateGraphics() ); 
			Display.Image = Space.GetBitmap();
		}

		private void Display_PreviewKeyDown( object sender, PreviewKeyDownEventArgs e )
		{
			
			switch ( e.KeyData )
			{
				case Keys.Right:
				Space.Cube.Rotate( Axis.OY, ( int ) offset_UpDown.Value );
				break;

				case Keys.Left:
				Space.Cube.Rotate( Axis.OY, -1 * ( int )offset_UpDown.Value );
				break;

				case Keys.Up:
				Space.Cube.Rotate( Axis.OX, -1 * ( int )offset_UpDown.Value );
				break;
				case Keys.Down:
				Space.Cube.Rotate( Axis.OX, ( int )offset_UpDown.Value );
				break;

				case Keys.PageDown:
				Space.Cube.Rotate( Axis.OZ, ( int )offset_UpDown.Value );
				break;
				case Keys.PageUp:
				Space.Cube.Rotate( Axis.OZ, -1 * ( int )offset_UpDown.Value );
				break;

			}

			Display_Paint( null, null );
		}

		private void Display_Click( object sender, EventArgs e )
		{
			Display.Select();
			Display_Paint( null, null );
		}

		private void Display_Paint( object sender, PaintEventArgs e )
		{
			Space.ClientRect = Display.ClientRectangle;
			if ( new Rectangle(0,0,0,0) != Display.ClientRectangle )
				using ( BufferedGraphicsContext myContext = new BufferedGraphicsContext() )
				{
					BufferedGraphics bufferedGraphics = myContext.Allocate( Display.CreateGraphics(), Display.ClientRectangle );
					bufferedGraphics.Graphics.FillRectangle( new SolidBrush( Display.BackColor ), Display.ClientRectangle );
					Space.DrawCube( bufferedGraphics.Graphics);
					bufferedGraphics.Render();
				}
		}


		private void Display_Resize( object sender, EventArgs e )
		{
			if ( Space != null )
			{
				Display.Image = Space.GetBitmap();
				Display_Paint( sender, null );
			}
		}

		private void exitToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Application.Exit();
		}

		private void Display_MouseClick( object sender, MouseEventArgs e )
		{
			int face_numb = Space.TrySelectCubeFace( e.Location );
			if ( -1 != face_numb )
			{
				ColorEditor.Enabled = true;
				Color color = Color.FromArgb( Space.Cube.ColorsARGB[ face_numb ] );
				Red_UpDown.Value = color.R;
				Green_UpDown.Value = color.G;
				Blue_UpDown.Value = color.B;

				Color_pictureBox.BackColor = Color.FromArgb( Space.Cube.ColorsARGB[ face_numb ] );
			}
			else
			{
				Color_pictureBox.BackColor = ColorEditor.BackColor;
				ColorEditor.Enabled = false;
			}
		}

		private void Color_pictureBox_BackColorChanged( object sender, EventArgs e )
		{
			Space.ChangeSelectedFaceColor( Color_pictureBox.BackColor.ToArgb() );
			Display_Paint( null, null );
		}

		private void Red_UpDown_ValueChanged( object sender, EventArgs e )
		{
			Color_pictureBox.BackColor = Color.FromArgb( (int)Red_UpDown.Value, Color_pictureBox.BackColor.G, Color_pictureBox.BackColor.B );

		}

		private void Green_UpDown_ValueChanged( object sender, EventArgs e )
		{
			Color_pictureBox.BackColor = Color.FromArgb(  Color_pictureBox.BackColor.R, ( int )Green_UpDown.Value, Color_pictureBox.BackColor.B );
		}

		private void Blue_UpDown_ValueChanged( object sender, EventArgs e )
		{
			Color_pictureBox.BackColor = Color.FromArgb( Color_pictureBox.BackColor.R, Color_pictureBox.BackColor.G, ( int )Blue_UpDown.Value );
		}

		private void Save_MenuItem_click( object sender, EventArgs e )
		{
			SaveFileDialog save = new SaveFileDialog();
			save.AddExtension = true;
			save.Filter = "XML|*.xml|JSON|*.json|Bitmap|*.bmp";
			if ( DialogResult.OK != save.ShowDialog() )
				return;

			string file_ext = save.FileName.Substring( save.FileName.LastIndexOf( '.' ) );
			switch ( file_ext )
			{
				case ".xml":
					XMLSerialize( save.FileName );
				break;

				case ".json":
					JSONSerialize( save.FileName );
				break;

				case ".bmp":
					SaveToBmp( save.FileName );
				break;

				default:
				throw new ArgumentException( "Incorrect type of file" );				
			}

		}
		private void SaveToBmp(string filename)
		{
			Display.Image = Space.GetBitmap();
			new Bitmap( Display.Image ).Save( filename );
		}

		private void XMLSerialize(string filename)
		{
			Cube3DSerializer cubeSerializer = Space.Cube;
			XmlSerializer xmlFormat = new XmlSerializer( typeof( Cube3DSerializer ) );
			using ( Stream fStream = new FileStream( filename, FileMode.Create, FileAccess.Write, FileShare.None ) )
			{
				xmlFormat.Serialize( fStream, cubeSerializer );
			}
		}

		private void SOAPSerialize( string filename )
		{
			Cube3DSerializer cubeSerializer = Space.Cube;
			SoapFormatter formatter = new SoapFormatter();		
			using ( FileStream fStream = new FileStream( filename, FileMode.Create, FileAccess.Write, FileShare.None ) )
			{
				formatter.Serialize( fStream, cubeSerializer );
			}

		}
		private void JSONSerialize( string filename )
		{
			Cube3DSerializer cubeSerializer = Space.Cube;
			DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer( typeof( Cube3DSerializer ) );
			using ( FileStream fStream = new FileStream( filename, FileMode.Create, FileAccess.Write, FileShare.None ) )
			{
				jsonFormatter.WriteObject( fStream, cubeSerializer );
			}
		}

		private void Open_MenuItem_Click( object sender, EventArgs e )
		{
			OpenFileDialog open = new OpenFileDialog();
			open.AddExtension = true;
			open.Filter = "XML|*.xml|JSON|*.json";
			if ( DialogResult.OK != open.ShowDialog() )
				return;


			string file_ext = open.FileName.Substring( open.FileName.LastIndexOf( '.' ) );
			switch ( file_ext )
			{
				case ".xml":
				XMLSDeserialize( open.FileName );
				break;

				case ".json":
				JSONDeserialize( open.FileName );
				break;

				case ".bmp":
				break;

				default:
				throw new ArgumentException( "Incorrect type of file" );
			}
			Display_Paint( null, null );
		}

		private void JSONDeserialize( string filename )
		{
			Cube3DSerializer cubeSerializer = Space.Cube;
			DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer( typeof( Cube3DSerializer ) );
			using ( FileStream fStream = new FileStream( filename, FileMode.OpenOrCreate) )
			{
				Space.Cube = ( Cube3DSerializer )jsonFormatter.ReadObject( fStream );
			}
		}

		private void XMLSDeserialize( string filename )
		{

			XmlSerializer xmlFormat = new XmlSerializer( typeof( Cube3DSerializer ), new Type[] { typeof( Cube3DSerializer ) } );
			using ( FileStream fStream = File.OpenRead( filename ) )
			{
				Space.Cube = ( Cube3DSerializer )xmlFormat.Deserialize( fStream );
			}
		}

		private void instructionsToolStripMenuItem_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "In order to rotate cube use keys:\n'Left'\n'Right'\n'Up'\n'Down'\n'PgUp'\n'PgDown'\n" +
							"Also you can save your cube to the file and load from file\n" +
							"Click on the cube area to be able to rotate it",
							"Instructions");
		}

		private void aboutToolStripMenuItem1_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "Rostovski Nikita\r\nKIUKI-16-7", "About" );
		}
	}
}
