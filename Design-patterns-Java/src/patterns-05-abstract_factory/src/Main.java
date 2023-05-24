public class Main {
	
	public static SoyutOyun oyunYarat(OyunFactory f) {
		SoyutOyun oyun = f.yeniOyun();
		SoyutOda oda1 = f.odaYarat();
		SoyutOda oda2 = f.odaYarat();
		SoyutKapi kapi1 = f.kapiYarat();
		SoyutKapi kapi2 = f.kapiYarat();
		oda1.kapiEkle(kapi2);
		oda2.kapiEkle(kapi1);
		oyun.odaEkle(oda1);
		oyun.odaEkle(oda2);
		return oyun;
	}
	
	public static void main(String[] args) {
		SoyutOyun normalOyun = oyunYarat(new NormalOyunFactory());
		normalOyun.oyunCalistir();
		
		SoyutOyun buyuluOyun = oyunYarat(new BuyuluOyunFactory());
		buyuluOyun.oyunCalistir();
	}
}
