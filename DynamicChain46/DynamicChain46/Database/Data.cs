namespace DynamicChain46.Database
{
	public enum MemoryUnit
	{
		None,
		File,
		Folder,
		Container
	}

	public class Data
	{
		private Dictionary<long, string> @object { get; set; }
		protected Queue<string> schema { get; set; }
		protected Stack<string> symbol { get; set; }

		public Data()
		{
			this.@object = new Dictionary<long, string>();
			this.schema = new Queue<string>();
			this.symbol = new Stack<string>();
		}

		private string PrimitiveType(Dictionary<long, string> @object)
		{
			this.@object = @object;
			string instance = this.@object.ToString() ?? string.Empty;
			return instance;
		}

		protected string ReferentialData(Queue<string> schema)
		{
			this.schema = schema;
			string storage = this.schema.ToString() ?? string.Empty;
			return storage;
		}

		protected string AssociativeClass(Stack<string> symbol)
		{
			this.symbol = symbol;
			string model = this.symbol.ToString() ?? string.Empty;
			return model;
		}

		~Data()
		{
			this.@object = new Dictionary<long, string>();
			this.schema = new Queue<string>();
			this.symbol = new Stack<string>();
		}
	}
}