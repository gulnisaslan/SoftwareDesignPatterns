public class Main {

	public static void bilgiler(Grafik g) {
		g.grafikBilgisi();
	}
	
	public static void ekranaCiz(Grafik g) {
		g.Ciz();
	}
	
	public static void main(String[] args) {
		GoruntuVekili g = new GoruntuVekili("resim.jpg");
		bilgiler(g);
		ekranaCiz(g);
		
		GoruntuVekili h = new GoruntuVekili("foto.jpg");
		bilgiler(h);
		ekranaCiz(h);
		ekranaCiz(g);
	}

}
