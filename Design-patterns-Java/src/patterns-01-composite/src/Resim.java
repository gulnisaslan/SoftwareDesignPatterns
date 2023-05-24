
public class Resim implements Icerik {

	private String resimyolu; 
	
	public Resim(String r) {
		resimyolu = r;
	}
	
	@Override
	public void Operation() {
		System.out.println("<img src='" + resimyolu + "' />");
	}

	@Override
	public void Add(Icerik i) {
		return;
	}

	@Override
	public void Remove(Icerik i) {
		return;
	}

	@Override
	public Icerik GetChild(int i) {
		return null;
	}

}
