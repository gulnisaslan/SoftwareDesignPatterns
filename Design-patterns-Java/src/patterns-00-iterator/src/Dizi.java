import java.util.ArrayList;

public class Dizi extends Aggregate {
	public ArrayList<Integer> liste;
	public Dizi() {
		liste = new ArrayList<>();
		liste.add(1); liste.add(3); liste.add(6); 
		liste.add(5); liste.add(2); liste.add(4); 
	}
	
	@Override
	public Iterator createIterator() {
		return new DiziIterator(this);
	}

}
