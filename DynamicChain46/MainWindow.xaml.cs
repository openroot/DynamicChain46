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

			Trade.Share aShare = new Trade.Share();
			Learn.Study myStudy = new Learn.Study();
		}
	}
}