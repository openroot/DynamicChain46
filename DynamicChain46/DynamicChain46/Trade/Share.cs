// Main Namespaces (Libraries)

namespace DynamicChain46.Trade
{
	// Basic Enums (Options)

	public enum ShareCategory
	{
		Finance,
		Currency,
		Transport,
		Commodity,
		Technology,
		Healthcare,
		Agriculture,
		Textile,
		Power,
		Realty
	}

	// Generic Classes (Instances)

	public class Share
	{
		// General Properties (Attributes)

		private Dictionary<long, string> profile { get; set; }
		protected Queue<string> account { get; set; }
		public long id { get; set; }
		public string name { get; set; }
		public ShareCategory category { get; set; }
		public double balance { get; set; }
		public double fund { get; set; }
		public string reference { get; set; }
		public bool active { get; set; }
		protected Stack<string> inventory { get; set; }

		// Constructor Functions (Initialisations)

		public Share()
		{
			Console.WriteLine($"Share instance created successfully.");
			Console.WriteLine($"Initialising default values...");
			this.profile = new Dictionary<long, string>();
			this.account = new Queue<string>();
			this.id = 0;
			this.name = "Unnamed Share";
			this.category = ShareCategory.Finance;
			this.balance = 0.0;
			this.fund = 0.0;
			this.reference = "N/A";
			this.active = false;
			this.inventory = new Stack<string>();
		}

		// Regular Functions (Methods)

		private void SourceProfile(Dictionary<long, string> profile)
		{
			this.profile = profile;
			Console.WriteLine($"Total number of submitted source profiles: {this.profile.Count}");
		}

		protected void ResourceAccount(Queue<string> account)
		{
			this.account = account;
			Console.WriteLine($"Total number of trading resource accounts: {this.account.Count}");
		}

		public void BatchId(long id)
		{
			this.id = id;
			Console.WriteLine($"Batch ID updated to: {this.id}");
		}

		public void AssetName(string name)
		{
			this.name = name;
			Console.WriteLine($"Asset name assigned to: {this.name}");
		}

		public void SortCategory(ShareCategory category)
		{
			this.category = category;
			Console.WriteLine($"Share category sorted to: {this.category}");
		}

		public void RefreshBalance(double balance)
		{
			this.balance = balance;
			Console.WriteLine($"Total balance refreshed to: {this.balance}");
		}

		public void DistributeFund(double fund)
		{
			this.fund = fund;
			Console.WriteLine($"Investment fund distributed to: {this.fund}");
		}

		public void CompanyReference(string reference)
		{
			this.reference = reference;
			Console.WriteLine($"Company reference set to: {this.reference}");
		}

		public void IsActive(bool active)
		{
			this.active = active;
			string status = active ? "Active" : "Inactive";
			Console.WriteLine($"Availability status upgraded to: {status}");
		}

		protected void StockInventory(Stack<string> inventory)
		{
			this.inventory = inventory;
			Console.WriteLine($"Total number of allocated stock inventories: {this.inventory.Count}");
		}
	}
}