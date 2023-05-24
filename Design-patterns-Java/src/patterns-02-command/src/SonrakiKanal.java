
public class SonrakiKanal implements Command {
	private Televizyon tv;
	
	public SonrakiKanal(Televizyon t) {
		tv = t; 
	}
	
	@Override
	public void Execute() {
		tv.birSonrakiKanal();
		System.out.println("Geçerli Kanal: " + tv.gecerliKanal());
	}
	
	@Override 
	public String toString() {
		return "Sonraki Kanal";
	}

}
