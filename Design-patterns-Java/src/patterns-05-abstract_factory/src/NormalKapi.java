
public class NormalKapi extends SoyutKapi {

	private boolean acik = false;
	
	@Override
	public boolean kapiAc() {
		acik = true;
		return acik;
	}

	@Override
	public void kapiKapat() {
		acik = false;
	}

}
