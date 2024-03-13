package addresses;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Address;

import java.util.HashMap;

public class CreateAndVerify {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = "EASYPOST_API_KEY";

        HashMap<String, Object> addressParams = new HashMap<String, Object>();

        addressParams.put("street1", "417 Montgomery Street");
        addressParams.put("street2", "FL 5");
        addressParams.put("city", "San Francisco");
        addressParams.put("state", "CA");
        addressParams.put("zip", "94104");
        addressParams.put("country", "US");
        addressParams.put("company", "EasyPost");
        addressParams.put("phone", "415-123-4567");

        Address address = Address.createAndVerify(addressParams);

        System.out.println(address);
    }
}
