namespace DynamicChain46.Hardware
{
	public enum UnitType
	{
		None,
		Machine,
		Chip,
		Frame
	}

	public class Execute
	{
		private Dictionary<long, string> dimension { get; set; }
		protected Queue<string> derivates { get; set; }
		protected Stack<string> procedure { get; set; }

		public Execute()
		{
			this.dimension = new Dictionary<long, string>();
			this.derivates = new Queue<string>();
			this.procedure = new Stack<string>();
		}

		private string CoreSession(Dictionary<long, string> dimension)
		{
			this.dimension = dimension;
			string volume = this.dimension.ToString() ?? string.Empty;
			return volume;
		}

		protected string MatrixValue(Queue<string> derivates)
		{
			this.derivates = derivates;
			string determinant = this.derivates.ToString() ?? string.Empty;
			return determinant;
		}

		protected string IntegralAmount(Stack<string> procedure)
		{
			this.procedure = procedure;
			string transformation = this.procedure.ToString() ?? string.Empty;
			return transformation;
		}

		~Execute()
		{
			this.dimension = new Dictionary<long, string>();
			this.derivates = new Queue<string>();
			this.procedure = new Stack<string>();
		}
	}
}