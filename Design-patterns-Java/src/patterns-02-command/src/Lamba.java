
public class Lamba {
	private int lamba;
	public Lamba() {
		lamba = 0;
	}
	public void lambaAc() {
		System.out.println("Lamba açıldı");
		lamba = 1;
	}
	
	public void lambaKapa() {
		System.out.println("Lamba kapandı");
		lamba = 0;
	}
	
	public int lambaDegeri() { return lamba; }
}
