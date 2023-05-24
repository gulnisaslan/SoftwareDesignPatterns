public class OGGAdaptoru extends Muzik {
	private OGG ogg;
	
	public OGGAdaptoru(String i) {
		super(i);
		ogg = new OGG(i);
	}
	
	@Override
	public void MP3Oynat() {
		ogg.OGGOynat(1);
	}

}
