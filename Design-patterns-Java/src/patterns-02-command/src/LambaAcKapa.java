
public class LambaAcKapa implements Command {

	Lamba lamba; 
	
	public LambaAcKapa(Lamba l) {
		lamba = l;
	}
	
	@Override
	public void Execute() {
		// TODO Auto-generated method stub
		if(lamba.lambaDegeri() == 1) lamba.lambaKapa();
		else lamba.lambaAc();
	}
	
	@Override 
	public String toString() {
		if(lamba.lambaDegeri()==1) return "Lambayı Kapa";
		else return "Lambayı Aç";
	}

}
