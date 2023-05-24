public class Main {
	public static void main(String[] args) {
		Player p = new Player();
		p.listeyeEkle(new Muzik("Metallica - One"));
		p.listeyeEkle(new Muzik("Iron Maiden - Wasted Years"));
		// p.listeyeEkle(new OGG("Bon Jovi - These Days"));
		p.listeyeEkle(new OGGAdaptoru("Bon Jovi - These Days"));
		p.Play();
	}
}
