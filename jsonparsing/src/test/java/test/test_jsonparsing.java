package test;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;

import com.fasterxml.jackson.databind.ObjectMapper;

import jsonparsing.PersonDetails;

public class test_jsonparsing {
	public static void main(String[] args) throws IOException {
		// to read data from json
		byte[] jsonData=Files.readAllBytes(Paths.get("C:\\Users\\ASUS\\eclipse-workspace\\JSON_parsing\\Config\\Data.json"));
		ObjectMapper mapper=new ObjectMapper();//for mapping the objects
		PersonDetails person=mapper.readValue(jsonData, PersonDetails.class);//object of person class
		System.out.println(person.getEmail());
		System.out.println(person.getAddress().getCountry());
		System.out.print(person.getAddress().getDet().getDist());
		
	}
}
