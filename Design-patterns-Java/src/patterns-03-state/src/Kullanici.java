public class Kullanici implements State {
	private Program program;
	
	public Kullanici(Program p) {
		program = p;
	}
	
	@Override
	public void Handle() {
		System.out.println("1) Kullanıcı Ayarları");
		System.out.println("2) Hizmet 1");
		System.out.println("3) Hizmet 2");
		System.out.println("4) Çıkış");
		
		program.Cikis();
	}

}
