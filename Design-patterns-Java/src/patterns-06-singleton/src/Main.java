public class Main {

	public static void main(String[] args) {
		// TekilSinif t = new TekilSinif();
		TekilSinif t = TekilSinif.Instance();
		System.out.println(t.degerAl());
		t.degerYaz(20);
		TekilSinif u = TekilSinif.Instance();
		System.out.println(u.degerAl());
	}

}
