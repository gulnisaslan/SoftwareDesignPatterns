import java.util.ArrayList;

public class NormalOyun extends SoyutOyun {

	ArrayList<SoyutOda> odalar;
	
	NormalOyun() {
		odalar = new ArrayList<SoyutOda>();
	}
	
	@Override
	public void odaEkle(SoyutOda a) {
		odalar.add(a);
	}

	@Override
	public void oyunCalistir() {
		System.out.println("Normal oyun çalışıyor...");
		System.out.println("Oda sayısı: " + odalar.size());
	}

}
