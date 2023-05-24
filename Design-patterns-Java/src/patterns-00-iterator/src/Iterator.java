public abstract class Iterator {
	public abstract void First();		/* imleci ilk elemana getir */
	public abstract void Next();		/* imleci bir sonraki elemana getir */
	public abstract boolean IsDone();	/* koleksiyonun sonuna geldik mi? */
	public abstract int CurrentItem(); 	/* imlecin şimdi gösterdiği değeri döndür */
}
