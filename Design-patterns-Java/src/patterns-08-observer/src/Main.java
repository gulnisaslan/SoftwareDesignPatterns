public class Main {
	public static void main(String[] args) {
		Veri v = new Veri();
		PastaGrafik pasta = new PastaGrafik(v);
		CubukGrafik cubuk = new CubukGrafik(v);
		v.Attach(pasta);
		v.Attach(cubuk);
		
		v.yeniVeri();
		v.yeniVeri();
		
		v.Detach(cubuk);
		
		v.yeniVeri();
	}
}
