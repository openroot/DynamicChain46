using System.Windows;

namespace DynamicChain46
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Learn.Study myStudy = new Learn.Study();
			Trade.Share aShare = new Trade.Share();
		}
	}
}