public class TekilSinif {
	
	private int deger; 
	private TekilSinif() {
		deger = 12; 
	}
	
	public int degerAl() { return deger; }
	public void degerYaz(int a) {
		deger = a;
	}
	
	// singleton
	private static TekilSinif uniqueInstance = null;
	public static TekilSinif Instance() {
		if(uniqueInstance == null) { 
			uniqueInstance = new TekilSinif();
		}
		return uniqueInstance;
	}

}
