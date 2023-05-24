public class Main {
	public static void main(String[] args) {
		Listeleme.Listele(new Dizi());
		
		Agac agac = new Agac(12);
		Agac sag = new Agac(13);
		Agac sol = new Agac(15);
		Agac sag2 = new Agac(20);
		agac.solaEkle(sol);
		agac.sagaEkle(sag);
		sag.sagaEkle(sag2);
		
		Listeleme.Listele(agac);
		
	}
}
