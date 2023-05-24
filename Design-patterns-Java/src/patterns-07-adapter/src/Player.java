import java.util.ArrayList;

public class Player {
	
	private ArrayList<Muzik> liste;
	
	public Player() {
		liste = new ArrayList<Muzik>();
	}
	
	public void listeyeEkle(Muzik m) {
		liste.add(m);
	}
	
	public void Play() {
		for(Muzik m : liste) {
			m.MP3Oynat();
		}
	}
}
