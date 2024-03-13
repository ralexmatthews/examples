package pickups;

import com.easypost.exception.EasyPostException;
import com.easypost.model.Pickup;
import com.easypost.service.EasyPostClient;

public class Retrieve {
    public static void main(String[] args) throws EasyPostException {
        EasyPostClient client = new EasyPostClient("EASYPOST_API_KEY");

        Pickup pickup = client.pickup.retrieve("pickup_...");

        System.out.println(pickup);
    }
}
