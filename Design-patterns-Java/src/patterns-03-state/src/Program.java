
public class Program {
	private State s;
	
	public Program() {
		s = new Tanimsiz(this);
	}
	
	public void calis() {
		s.Handle();
	}
	
	public void GirisYap() {
		s = new Kullanici(this);
		calis();
	}
	
	public void Yonetici() {
		s = new Yonetici(this);
		calis();
	}
	
	public void Cikis() {
		s = new Tanimsiz(this);
	}
}
