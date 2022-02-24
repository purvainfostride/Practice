package jsonparsing;

public class Address {
	private String state;
	private String country;
	private Details Detail;
	
	public String getState() {
		return state;
	}
	public void setState(String state) {
		this.state = state;
	}
	public String getCountry() {
		return country;
	}
	public void setCountry(String country) {
		this.country = country;
	}
	public Details getDet() {
		return Detail;
	}
	public void setDet(Details Detail ) {
		this.Detail = Detail;
	}

}
