public class Main {
	public static void araba(ArabaFactory f) {
		Araba a = f.ArabaUret();
		System.out.println(a.marka() + " marka araba üretildi.");
	}
	
	public static void main(String[] args) {
		araba(new SahinFactory());
		araba(new MercedesFactory());
	}
}
