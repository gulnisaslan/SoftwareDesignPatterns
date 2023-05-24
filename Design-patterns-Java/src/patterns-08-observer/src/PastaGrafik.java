import java.util.ArrayList;

public class PastaGrafik implements Observer {
	private Veri kaynak;
	private ArrayList<Integer> veri; 
	
	public PastaGrafik(Veri k) {
		veri = new ArrayList<Integer>();
		kaynak = k;
		for(int i : kaynak.veriAl()) veri.add(i);
	}
	
	@Override
	public void Update() {
		veri.clear();
		for(int i : kaynak.veriAl()) veri.add(i);
		System.out.println("Pasta grafik güncellendi.");
		System.out.println(veri);
	}

}
