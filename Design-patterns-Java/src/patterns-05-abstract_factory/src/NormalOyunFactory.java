
public class NormalOyunFactory extends OyunFactory {

	@Override
	public SoyutOyun yeniOyun() {
		return new NormalOyun();
	}

	@Override
	public SoyutKapi kapiYarat() {
		return new NormalKapi();
	}

	@Override
	public SoyutOda odaYarat() {
		return new NormalOda();
	}

}
