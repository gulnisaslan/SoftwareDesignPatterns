public class GoruntuVekili extends Grafik {
	
	private Goruntu v; 
	
	public GoruntuVekili(String p) {
		dosyaYolu = p;
		v = new Goruntu(p);
	}
	
	@Override
	public void Ciz() {
		v.Ciz();
	}

	@Override
	public void grafikBilgisi() {
		System.out.println("Dosya adı: " + dosyaYolu);
	}

}
