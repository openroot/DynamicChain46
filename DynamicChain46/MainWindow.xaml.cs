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
			Network.Channel newChannel = new Network.Channel();
			Information.Subject firstSubject = new Information.Subject();
		}
	}
}