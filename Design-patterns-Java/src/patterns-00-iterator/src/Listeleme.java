public class Listeleme {
	public static void Listele(Aggregate a) {
		Iterator i = a.createIterator();
		for(i.First();!i.IsDone();i.Next()) {
			System.out.println(i.CurrentItem());
		}
	}
}
