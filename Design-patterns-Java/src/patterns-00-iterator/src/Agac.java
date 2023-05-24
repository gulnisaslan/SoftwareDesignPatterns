public class Agac extends Aggregate {
	
	private int deger; 
	Agac sol;
	Agac sag;
	
	public Agac(int d) {
		deger = d; 
		sol = null;
		sag = null;
	}
	
	public int degeriAl() { return deger; }
	
	public void solaEkle(Agac a) { sol = a; }
	public void sagaEkle(Agac a) { sag = a; }
	
	@Override
	public Iterator createIterator() {
		return new AgacIterator(this);
	}
}
