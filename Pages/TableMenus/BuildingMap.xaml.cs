using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Info_module.Pages.TableMenus
{
	/// <summary>
	/// Interaction logic for BuildingMap.xaml
	/// </summary>
	/// 

	

	public partial class BuildingMap : Page
	{
		//these are for the zooming and panning funcs
		private ScaleTransform scaleTransform = new ScaleTransform(1, 1);
		private Point origin;
		private Point start;
		//private double zoomMax = 5.0;  // Max zoom scale
		//private double zoomMin = 0.5;  // Min zoom scale


		public BuildingMap()
		{
			InitializeComponent();
			TopBar topBar = new TopBar();
			topBar.txtPageTitle.Text = "Building Map";
			topBar.Visibility = Visibility.Visible;
			topBar.BackButtonClicked += TopBar_BackButtonClicked;
			TopBarFrame.Navigate(topBar);

			//this is for the zooming and panning
			//canvasMap.MouseWheel += Map_Mousewheel;
			//canvasMap.Height = 100;


		}



		/*private void Map_Mousewheel(object sender, MouseWheelEventArgs e)
		{
			// Get the current scale
			var scale = zoom.ScaleX;

			// Calculate the zoom factor based on the scroll direction
			if (e.Delta > 0 && scale < zoomMax)
			{
				scale += 0.1; // Zoom in
			}
			else if (e.Delta < 0 && scale > zoomMin)
			{
				scale -= 0.1; // Zoom out
			}

			// Apply the scale
			zoom.ScaleX = scale;
			zoom.ScaleY = scale;

			// Optionally, adjust the position of the canvas for a smoother zoom
			Point mousePosition = e.GetPosition(canvasMap);
			panning.X = (1 - scale) * mousePosition.X;
			panning.Y = (1 - scale) * mousePosition.Y;
		}*/

		// Zoom in and out methods
		private void ZoomIn()
		{
			scaleTransform.ScaleX *= 1.1;
			scaleTransform.ScaleY *= 1.1;
		}

		private void ZoomOut()
		{
			scaleTransform.ScaleX /= 1.1;
			scaleTransform.ScaleY /= 1.1;
		}


		private void TopBar_BackButtonClicked(object sender, EventArgs e)
		{
			var mainWindow = (MainWindow)Application.Current.MainWindow;
			mainWindow.MainFrame.Navigate(new MainMenu());
		}

		private void mt_bldg_click(object sender, RoutedEventArgs e)
		{

			Button clickedButton = sender as Button;
			if (clickedButton != null && clickedButton.Tag != null)
			{
				// XAML Tag to int function, which is then used to open a specific set of details in another page
				int buildingId = Convert.ToInt32(clickedButton.Tag);
				CSVRooms rooms = new CSVRooms(buildingId);
				NavigationService.Navigate(rooms);

			}

			else
			{
				MessageBox.Show("Error");
			}

		}

		private void ov_bldg_click(object sender, RoutedEventArgs e)
		{
			Button clickedButton = sender as Button;
			if (clickedButton != null && clickedButton.Tag != null)
			{
				// XAML Tag to int function, which is then used to open a specific set of details in another page
				int buildingId = Convert.ToInt32(clickedButton.Tag);
				CSVRooms rooms = new CSVRooms(buildingId);
				NavigationService.Navigate(rooms);

			}

			else
			{
				MessageBox.Show("Error");
			}

		}

		private void nv_bldg_click(object sender, RoutedEventArgs e)
		{
			Button clickedButton = sender as Button;
			if (clickedButton != null && clickedButton.Tag != null)
			{
				// XAML Tag to int function, which is then used to open a specific set of details in another page
				int buildingId = Convert.ToInt32(clickedButton.Tag);
				CSVRooms rooms = new CSVRooms(buildingId);
				NavigationService.Navigate(rooms);

			}

			else
			{
				MessageBox.Show("Error");
			}

		}


		private void en_bldg_click(object sender, RoutedEventArgs e)
		{
			Button clickedButton = sender as Button;
			if (clickedButton != null && clickedButton.Tag != null)
			{

				// XAML Tag to int function, which is then used to open a specific set of details in another page
				int buildingId = Convert.ToInt32(clickedButton.Tag);
				CSVRooms rooms = new CSVRooms(buildingId);
				NavigationService.Navigate(rooms);

			}

			else
			{
				MessageBox.Show("Error");
			}

		}

        private void buildingMenu_btn_Click(object sender, RoutedEventArgs e)
        {
			NavigationService.Navigate(new BuildingMenu());

        }
    }
}
