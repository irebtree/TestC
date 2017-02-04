[System.AttributeUsage(System.AttributeTargets.All)]
public class Author : System.Attribute {
	private string name;
	public double virsion = 1.0;

	public Author(string name)
	{
		this.name = name;
		virsion = 1.0;
	}
	public string Name
	{
		get{return this.name;}
	}
}
