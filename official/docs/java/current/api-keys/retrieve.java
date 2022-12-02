package api_keys;

import com.easypost.exception.EasyPostException;
import com.easypost.model.ApiKeys;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient(System.getenv("EASYPOST_API_KEY"));

        ApiKeys parentKeys = client.apikeys.all();

        System.out.println(parentKeys);
    }
}
