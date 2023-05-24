
public class BuyuluOyunFactory extends OyunFactory {

	@Override
	public SoyutOyun yeniOyun() {
		return new BuyuluOyun();
	}

	@Override
	public SoyutKapi kapiYarat() {
		return new BuyuluKapi();
	}

	@Override
	public SoyutOda odaYarat() {
		return new BuyuluOda();
	}

}
