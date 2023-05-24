public class Main {
	
	public static void main(String[] args) {
		Bolum kitap = new Bolum("Programlamaya Giriş");
		Bolum b1 = new Bolum("Giriş");
		b1.Add(new Metin("hello, world"));
		b1.Add(new Metin("diger programlar"));
		Bolum b12 = new Bolum("Temel Programlama");
		b12.Add(new Metin("değişkenler"));
		b12.Add(new Metin("kontrol"));
		b12.Add(new Metin("döngüler"));
		b12.Add(new Metin("fonksiyonlar"));
		b1.Add(b12);
		
		Bolum b2 = new Bolum("Değişkenler");
		b2.Add(new Resim("degisken.jpg"));
		b2.Add(new Metin("int, double, float, boolean"));
		
		kitap.Add(b1);
		kitap.Add(b2);
		
		yazdir(kitap);
		System.out.println();
		yazdir(b12);
	}
	
	public static void yazdir(Icerik icerik) {
		icerik.Operation();
	}
}
