public class DiziIterator extends Iterator {
	private Dizi dizi; 
	private int idx;
	
	public DiziIterator(Dizi d) {
		dizi = d;
		idx = 0;
	}
	
	@Override
	public void First() { idx = 0; }

	@Override
	public void Next() { idx++; }

	@Override
	public boolean IsDone() { return idx == dizi.liste.size(); }

	@Override
	public int CurrentItem() { return dizi.liste.get(idx); }
}
