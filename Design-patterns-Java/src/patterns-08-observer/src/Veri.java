import java.util.ArrayList;
import java.util.Random;

public class Veri implements Subject {
	private ArrayList<Integer> liste;
	private ArrayList<Observer> gozlemciler;
	private Random rastgele;
	
	public Veri() {
		rastgele = new Random(System.currentTimeMillis());
		liste = new ArrayList<Integer>();
		liste.add(rastgele.nextInt(100)); 
		liste.add(rastgele.nextInt(100)); 
		liste.add(rastgele.nextInt(100));
		gozlemciler = new ArrayList<Observer>();
	}
	
	@Override
	public void Attach(Observer o) {
		gozlemciler.add(o);
	}

	@Override
	public void Detach(Observer o) {
		gozlemciler.remove(o);
	}

	@Override
	public void Notify() {
		for(Observer o : gozlemciler) {
			o.Update();
		}
	}
	
	public void yeniVeri() {
		liste.add(rastgele.nextInt(100));
		Notify();
	}
	
	public ArrayList<Integer> veriAl() {
		return liste;
	}

}
