
public class Yonetici implements State {
	
	private Program program;
	
	public Yonetici(Program p) {
		program = p;
	}

	@Override
	public void Handle() {
		System.out.println("1) Kullanıcı Ekle");
		System.out.println("2) Kullanıcı Güncelle");
		System.out.println("3) Kullanıcı Sil");
		System.out.println("4) Çıkış");
		
		program.Cikis();
	}

}
